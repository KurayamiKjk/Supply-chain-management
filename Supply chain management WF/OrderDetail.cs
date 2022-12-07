using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supply_chain_management_WF
{
    public partial class OrderDetail : Form
    {
        private string orderId;
        private SqlConnection con = DBConnection.GetConnection();
        public OrderDetail()
        {
            InitializeComponent();
        }
        public OrderDetail(string id) : this()
        {
            orderId = id;
            orderDetailId.Text = orderId;
        }
            private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }
        public void loadOrderDetailProductData()
        {
            orderDetailView.DataSource = getData.getOrderDetailData(orderId);
            this.orderDetailView.Columns.Add("ProductName", "Product Name");
            this.orderDetailView.Columns["ProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetailView.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in orderDetailView.Rows)
            {
                string productId = row.Cells[2].Value.ToString();
                con.Open();
                string querry = "SELECT ProductName FROM [dbo].[Product] WHERE ProductId = '" + productId + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        row.Cells[6].Value = dr[0].ToString();
                    }
                }
                con.Close();
            }
        }
        public string reqProductId;
        public int reqProductQuantity;
        public int stockProductQuantity;
        public void checkProductStock()
        {
            // check each product in order list is in stock
            
            foreach (DataGridViewRow row in orderDetailView.Rows)
            {
                reqProductId = row.Cells["ProductId"].Value.ToString();
                reqProductQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                con.Open();
                string querry = "SELECT ProductQuantity FROM [dbo].[Product] WHERE ProductId = '" + reqProductId + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count != 0)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        stockProductQuantity = Convert.ToInt32(dr[0]);
                    }
                }
                con.Close();
                if(stockProductQuantity - reqProductQuantity < 0)
                {
                    MessageBox.Show("Product Id : " + reqProductId + " is out of stock" + "\n Require : " + reqProductQuantity + "\n In stock : " + stockProductQuantity);
                    orderConfirmBtn.Enabled= false;
                }
            }
        }
        // passing all order infomation from order data into order detaill
        public void getOrderData()
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[Order] where OrderId = '"+ orderId + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count != 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    orderDetailAgentId.Text = dr[2].ToString();
                    orderDetailCreatedDate.Text = dr[3].ToString();
                    orderDetailTotal.Text = dr[4].ToString();
                    if (Convert.ToInt32(dr[5]) == 0)
                    {
                        unpaidRadio.Checked = true;
                    }
                    else
                    {
                        paidRadio.Checked= true;
                    }
                }
            }
            con.Close();
        }
        public void loadOrderDetailAgentData()
        {
            orderDetailAgentName.Enabled= false;
            orderDetailAgentPhone.Enabled = false;
            orderDetailAgentAddress.Enabled = false;
            orderDetailAgentEmail.Enabled = false;
            con.Open();
            string querry = "SELECT AgentName, AgentNumber, AgentAddress, AgentEmail FROM [dbo].[Agent] WHERE AgentId = '" + orderDetailAgentId.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            if (dataTable.Rows.Count != 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    orderDetailAgentName.Text = dr[0].ToString();
                    orderDetailAgentPhone.Text = dr[1].ToString();
                    orderDetailAgentAddress.Text = dr[2].ToString();
                    orderDetailAgentEmail.Text = dr[3].ToString();
                }
            }
        }
        private void OrderDetail_Load(object sender, EventArgs e)
        {
            //do not change this funtion order
            getOrderData();
            loadOrderDetailAgentData();
            loadOrderDetailProductData();
            checkPaymentStatus();
            if(paidRadio.Checked)
            {
                paidRadio.Enabled= false;
            }
            if (unpaidRadio.Checked)
            {
                unpaidRadio.Enabled= false;
            }
            checkProductStock();
        }

        private void paidRadio_CheckedChanged(object sender, EventArgs e)
        {

        }
        public int paymentStatus;
        public int checkPaymentStatus()
        {
            
            if (paidRadio.Checked)
            {
                paymentStatus = 1;
            }
            else
            {
                paymentStatus = 0;
            }
            return paymentStatus;
        }
        private void paidRadio_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Confirm payment this order ?", "Confirm payment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    paidRadio.Checked = true;
                    unpaidRadio.Checked = false;
                    checkPaymentStatus();
                    updateData.updateOrderPaymentStatus(orderId, paymentStatus);
                }
            else
            {
                paidRadio.Checked = false;
                unpaidRadio.Checked = true;
            }
        }
        private void orderConfirmBtn_Click(object sender, EventArgs e)
        {
            int isConfirm = 1;
            string productId;
            int productQuantity;
            if (MessageBox.Show("Confirm this order ?", "Confirm order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateData.updateOrderStatus(orderId, isConfirm);
                foreach (DataGridViewRow row in orderDetailView.Rows)
                {
                    productId = row.Cells["ProductId"].Value.ToString();
                    productQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    updateData.updateProductStock(productId, productQuantity);
                }
                updateData.updateAgentTotalRevenue(orderDetailAgentId.Text, Convert.ToDecimal(orderDetailTotal.Text));
                updateData.refreshNewData();
                this.Close();
            }
            
        }
        private void unpaidRadio_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Unconfirm payment this order ?", "Confirm payment", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    paidRadio.Checked = false;
                    unpaidRadio.Checked = true;
                    checkPaymentStatus();
                    updateData.updateOrderPaymentStatus(orderId, paymentStatus);
                }
            else
            {
                paidRadio.Checked = true;
                unpaidRadio.Checked = false;
            }
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
