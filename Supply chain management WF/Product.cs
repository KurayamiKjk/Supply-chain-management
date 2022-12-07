using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using System.Xml.Linq;

namespace Supply_chain_management_WF
{
    public partial class Product : Form
    {

        
        public Product()
        {
            InitializeComponent();
            

        }
        private SqlConnection con = DBConnection.GetConnection();

        private void button2_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTab = homePage;
        }
        public void loaddata()
        {
            //do what you do in load data in order to update data in datagrid
            
            productView.DataSource = getData.getProductData();
            this.productView.Columns["ProductUnit"].Visible = false; //col 4
            this.productView.Columns["ProductQuantity"].Visible = false; // col 5
            this.productView.Columns["ProductUnitPrice"].Visible = false; // col 7
            this.productView.Columns["ProductDocument"].Visible = false; // col 6
            this.productView.Columns["TotalCost"].Visible = false; // col 8

            // Display product for billing page

            buyProductView.DataSource = getData.getProductData();
            orderView.DataSource = getData.getOrderData();

        }
        public void loadAgents() 
        {
            agentIdInput.Visible= false;           
            agentsView.DataSource = getData.getAgentData();
            this.agentsView.Columns["Id"].Visible= false;
            this.agentsView.Columns["AgentName"].HeaderCell.Value = "Name";
            this.agentsView.Columns["AgentName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.agentsView.Columns["AgentNumber"].HeaderCell.Value = "Number";
            this.agentsView.Columns["AgentEmail"].HeaderCell.Value = "Email";
            this.agentsView.Columns["AgentAddress"].HeaderCell.Value = "Address";
            this.agentsView.Columns["AgentAddress"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.agentsView.Columns["AgentJoinDate"].HeaderCell.Value = "Join Date";
            this.agentsView.Columns["TotalRevenue"].HeaderCell.Value = "Total Revenue";
            this.agentsView.Columns["AgentStatus"].HeaderCell.Value = "Status";
        }
        public void loadOrderHistory()
        {
            orderHistoryView.DataSource = getData.getOrderHistoryData();
            this.orderHistoryView.Columns["Id"].Visible = false;
        }
        public void loadAgentNameComboBox()
        {
            selectedAgentId.DataSource = getData.getAgentData();
            selectedAgentId.ValueMember = "AgentId";
            selectedAgentId.DisplayMember= "AgentId";
        }
        public void openChangeSection() 
        {
            productNameInfo.Enabled = true;
            productUnitInfo.Enabled = true;
            productQuantityInfo.Enabled = true;
            productUnitPriceInfo.Enabled = true;
            productDescriptionInfo.Enabled = true;
            saveChangeBtn.Visible = true;
            availableRadioInfo.Enabled = true;
            unavailableRadioInfo.Enabled = true;
        }
        public void closeChangeSection()
        {
            productNameInfo.Enabled = false;
            productUnitInfo.Enabled = false;
            productQuantityInfo.Enabled = false;
            productUnitPriceInfo.Enabled = false;
            productDescriptionInfo.Enabled = false;
            saveChangeBtn.Visible = false;
            availableRadioInfo.Enabled = false;
            unavailableRadioInfo.Enabled = false;
        }
        public void closeCreateAgentSection()
        {
            agentNameInput.Enabled = false;
            agentPhoneInput.Enabled = false;
            agentEmailInput.Enabled = false;
            agentAddressInput.Enabled = false;
            agentAvailableInput.Enabled = false;
            agentUnavailableInput.Enabled = false;
            saveCreateAgent.Visible = false;
        }
        public void searchAgentById(string id) 
        {
            string querry = "SELECT * FROM Agent where AgentId LIKE '"+id+"%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            agentsView.DataSource = dataTable;
        }
        
        public void searchAgentByName(string name)
        {
            string querry = "SELECT * FROM Agent where AgentName LIKE '%" + name + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            agentsView.DataSource = dataTable;
        }
        public void searchOrderById(string id)
        {
            string querry = "SELECT * FROM [dbo].[Order] where OrderId LIKE '" + id + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            orderView.DataSource = dataTable;
        }
        public void searchOrderByAgentId(string id)
        {
            string querry = "SELECT * FROM [dbo].[Order] where AgentId LIKE '" + id + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            orderView.DataSource = dataTable;
        }

        public int status;
        private void checkAvailable()
        {
            bool isAvailable = availableRadioInfo.Checked;
            if (isAvailable)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
        }
        private void checkAgentAvailable()
        {
            bool isAvailable = agentAvailableInput.Checked;
            if (isAvailable)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
        }
        public void checkProductStock()
        {
            if (selectedProductQuantity.Value > stockMaxAvailible)
            {
                
            }
        }
        public void ReloadForm()
        {
            this.Refresh();
            loaddata();
            loadAgents();
            loadAgentNameComboBox();
            loadOrderHistory();
        }
            private void Main_Load(object sender, EventArgs e)
        {
            statusDropDown.SelectedIndex = 0;
            agentStatusSearch.SelectedIndex = 0;
            ReloadForm();
            con.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void statusDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addProductBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct addProduct = new AddProduct();
            addProduct.Show();

        }

        private void productView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productView.Rows[e.RowIndex];
                productCodeInput.Text = row.Cells[0].Value.ToString();
                productNameInput.Text = row.Cells[1].Value.ToString();
                productIdInfo.Text = row.Cells[0].Value.ToString();
                productNameInfo.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "1")
                {
                    statusDropDown.SelectedIndex = 1;
                    availableRadioInfo.Checked = true;
                    unavailableRadioInfo.Checked = false;

                }
                if(row.Cells[2].Value.ToString() == "0")
                {
                    statusDropDown.SelectedIndex = 2;
                    availableRadioInfo.Checked = false;
                    unavailableRadioInfo.Checked= true;
                }
                productUnitInfo.Text = row.Cells[4].Value.ToString();
                productQuantityInfo.Text = row.Cells[5].Value.ToString();
                productUnitPriceInfo.Text = row.Cells[7].Value.ToString();
                productDescriptionInfo.Text = row.Cells[6].Value.ToString();
                totalPriceInfo.Text = row.Cells[8].Value.ToString() + "$";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void productView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productView.Rows[e.RowIndex];
                productIdInfo.Text = row.Cells[0].Value.ToString();
                productNameInfo.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "1")
                { 
                    statusDropDown.SelectedIndex = 1;
                }
                if (row.Cells[2].Value.ToString() == "0")
                {
                    statusDropDown.SelectedIndex = 2;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTab = agentPage;

        }

        private void productNameInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this product ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand com = new SqlCommand(@"DELETE FROM Product WHERE ProductId = '" + productIdInfo.Text + "';", con);
                int isExecute = com.ExecuteNonQuery();
                if (isExecute == 0)
                    MessageBox.Show("Delete failed, there was an error!");
                else
                    MessageBox.Show("Delete product successed!");
            }
            con.Close();
            loaddata();
        }

        private void changeProductBtn_Click(object sender, EventArgs e)
        {
            openChangeSection();
        }
        private void saveChangeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void productQuantityInfo_ValueChanged(object sender, EventArgs e)
        {
            
            if (productQuantityInfo.Value > 0 && productUnitPriceInfo.Value > 0)
            {
                try
                {
                    totalPriceInfo.Text = Convert.ToString(productQuantityInfo.Value * productUnitPriceInfo.Value) + "$";

                }
                catch (Exception ex) { }
            }
        }

        private void productUnitPriceInfo_ValueChanged_1(object sender, EventArgs e)
        {
            if (productQuantityInfo.Value > 0 && productUnitPriceInfo.Value > 0)
            {
                try
                {
                    totalPriceInfo.Text = Convert.ToString(productQuantityInfo.Value * productUnitPriceInfo.Value) + "$";
                }
                catch (Exception ex) { }
            }
        }

        private void availableRadioInfo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productNavBtn_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTab = productPage;
        }

        private void productCodeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void productView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productView_Click(object sender, EventArgs e)
        {

        }

        private void saveChangeBtn_Click_1(object sender, EventArgs e)
        {
            if (productNameInfo.Text == string.Empty || productUnitInfo.Text == string.Empty || productQuantityInfo.Text == string.Empty || productUnitPriceInfo.Text == string.Empty || productDescriptionInfo.Text == string.Empty)
            {
                MessageBox.Show("This some empty infomation");
            }
            else
            {
                if (MessageBox.Show("Change this product ?", "Confirm change", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    checkAvailable();
                    SqlCommand com = new SqlCommand(@"UPDATE Product SET 
                    ProductName = '" + productNameInfo.Text + "', ProductUnit = '" + productUnitInfo.Text + "', ProductQuantity = '" + productQuantityInfo.Value + "' , ProductDocument = '" + productDescriptionInfo.Text + "', ProductUnitPrice = '" + productUnitPriceInfo.Value + "', ProductStatus = '" + status + "', TotalCost = '" + productQuantityInfo.Value * productUnitPriceInfo.Value + "' WHERE ProductId = '" + productIdInfo.Text + "';", con);
                    int isExecute = com.ExecuteNonQuery();
                    if (isExecute == 0)
                        MessageBox.Show("Change failed, there was an error!");
                    else
                        MessageBox.Show("Change product infomation successed!");
                    closeChangeSection();
                    con.Close();
                    loaddata();
                }
            }
        }

        private void totalPriceInfo_Click(object sender, EventArgs e)
        {

        }

        private void availableRadioInfo_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand command = new SqlCommand("SELECT MAX(Id)+1 From Agent", con))
            {
                
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    agentIdInput.Visible= true;
                    agentIdInput.Text = reader.GetInt32(0).ToString();
                }
            }
            con.Close();
            agentsView.ClearSelection();
            agentNameInput.Enabled= true;
            agentPhoneInput.Enabled= true;
            agentEmailInput.Enabled= true;
            agentAddressInput.Enabled= true;
            agentAvailableInput.Enabled= true;
            agentUnavailableInput.Enabled= true;
            saveCreateAgent.Visible= true;
            agentNameInput.Clear();
            agentPhoneInput.Clear();
            agentEmailInput.Clear();
            agentAddressInput.Clear();
            agentAvailableInput.PerformClick();
        }

        private void saveCreateAgent_Click(object sender, EventArgs e)
        {
            if (agentNameInput.Text != string.Empty && agentPhoneInput.Text != string.Empty && agentEmailInput.Text != string.Empty && agentAddressInput.Text != string.Empty ) 
            {
                con.Open();
                checkAgentAvailable();
                SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[Agent]
           ([AgentId]
           ,[AgentName]
           ,[AgentNumber]
           ,[AgentEmail]
           ,[AgentAddress]
           ,[AgentStatus])
     VALUES
           ((SELECT MAX(Id) FROM Agent) + 1,'" + agentNameInput.Text + "','" + agentPhoneInput.Text + "','" + agentEmailInput.Text + "','" + agentAddressInput.Text + "','" + status + "')", con);
                int isExecute = com.ExecuteNonQuery();
                if (isExecute == 0)
                    MessageBox.Show("Create agent failed, there was an error!");
                else
                    MessageBox.Show("Create agent successed!");
                con.Close();
                loadAgents();
                updateHistory.updateAgentHistory(agentIdInput.Text,"agent","Create","",agentNameInput.Text, "","");
                closeCreateAgentSection();
                
            }
            else
            {
                MessageBox.Show("You are missing infomation");
            }
        }

        private void deleteAgentBtn_Click(object sender, EventArgs e)
        {
            if (agentsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a exist agent to delete!");
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this agent ? '"+ agentIdInput.Text + "'", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand com = new SqlCommand(@"DELETE FROM Agent WHERE AgentId = '" + agentIdInput.Text + "';", con);
                    int isExecute = com.ExecuteNonQuery();
                    if (isExecute == 0)
                        MessageBox.Show("Delete failed, there was an error!");
                    else
                        MessageBox.Show("Delete agent successed!");
                }
                con.Close();
                loadAgents();
            }
        }

        private void agentsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.agentsView.Rows[e.RowIndex];
                agentIdInput.Text = row.Cells[1].Value.ToString();
                agentNameInput.Text = row.Cells[2].Value.ToString();
                agentPhoneInput.Text = row.Cells[3].Value.ToString();
                agentEmailInput.Text = row.Cells[4].Value.ToString();
                agentAddressInput.Text = row.Cells[5].Value.ToString();
                if (row.Cells[8].Value.ToString() == "1")
                {
                    agentAvailableInput.Checked = true;
                    

                }
                if (row.Cells[8].Value.ToString() == "0")
                {
                    agentUnavailableInput.Checked = true;
                }
            }
        }

        private void agentStatusSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agentStatusSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void agentCodeSearch_TextChanged(object sender, EventArgs e)
        {
            searchAgentById(agentCodeSearch.Text);
        }

        private void agentNameSearch_TextChanged(object sender, EventArgs e)
        {
            searchAgentByName(agentNameSearch.Text);
        }

        private void agentsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void addToBillBtn_Click(object sender, EventArgs e)
        {
            /*TODO
             check if the selected product is already in the purchase list
            if yes then confirm to update the quantity to selected product
            if no then create new one 
            check the quantity before at to bill > 0
             */
            bool isInList = false;
            
            if (purchaseListView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in purchaseListView.Rows)
                {
                    if (row.Cells[0].Value.ToString() == selectedProductId.Text)
                    {
                        int i = row.Index;
                        //number of products allowed to be added = max stock - number of product added
                        if (Convert.ToInt32(purchaseListView[2, i].Value) > stockMaxAvailible - Convert.ToInt32(selectedProductQuantity.Value))
                        {
                            MessageBox.Show("The amount of production has reached the limit");
                        }
                        else
                        {
                            int sum = Convert.ToInt32(purchaseListView[2, i].Value) + Convert.ToInt32(selectedProductQuantity.Value);
                            purchaseListView[2, i].Value = sum;
                        }
                        isInList = true;
                    }           
                }
            }
            if (isInList == false)
            {
                if (selectedProductQuantity.Value > 0)
                {
                    this.purchaseListView.Rows.Add(selectedProductId.Text, selectedProductName.Text, selectedProductQuantity.Value , selectedProductUnitPrice.Value);
                }
                if (selectedProductQuantity.Value == 0)
                {
                    MessageBox.Show("Quantity must be greater than 0!");
                }
            }
            purchaseTotalPrice.Text = purchaseListView.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
        }
        private void BillingFormBtn_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTab = billingPage;
        }

        private void saveOrderBtn_Click(object sender, EventArgs e)
        {
            string agnetId = selectedAgentId.Text;
            string agentPhone = selectedAgentPhone.Text;
            string agentAddress = selectedAgentAddress.Text;
            if (MessageBox.Show("Are you sure you have fully rechecked?", "Confirm create order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (purchaseListView.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in purchaseListView.Rows)
                    {
                        int i = row.Index;
                        int id = Convert.ToInt32(purchaseListView[0, i].Value);
                        string querry = "SELECT * FROM Product WHERE ProductId = '" + id + "'";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        string productId = dataTable.Rows[0]["ProductId"].ToString();
                        string productName = dataTable.Rows[0]["ProductName"].ToString();
                        int productQuantity = Convert.ToInt32(row.Cells[2].Value.ToString());
                        string productUnitPrice = dataTable.Rows[0]["ProductUnitPrice"].ToString();
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [PriceEach], [PurchaseDate]) 
                VALUES ((SELECT MAX(Id) FROM [dbo].[Order]) + 1, '" + productId + "', '" + productQuantity + "', '" + productUnitPrice + "', GETDATE())", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    con.Open();
                    SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[Order] ([OrderId], [AgentId], [TotalPrice], [PaymentStatus], [OrderStatus]) 
                VALUES ((SELECT MAX(Id) FROM [dbo].[Order]) + 1, '" + agnetId + "', '" + purchaseTotalPrice.Text + "', '" + 0 + "', '" + 0 + "')",con);
                    int isExecute = com.ExecuteNonQuery();
                    if (isExecute == 0)
                        MessageBox.Show("Create order failed, there was an error!");
                    else
                        MessageBox.Show("Create order successed!");
                    con.Close();
                    loaddata();
                    string orderId = "";
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT MAX(Id)+1 From [dbo].[Order]", con))
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            orderId = reader.GetInt32(0).ToString();
                        }
                    }
                    con.Close();
                    updateHistory.updateOrderHistory(orderId, "Order", "Create", "0","0","","");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("The purchase list is empty !");
                }
            }
        }
        private void changeAgentBtn_Click(object sender, EventArgs e)
        {

        }
        /*TODO
            Select the product to add to list
            Click "Add to bill button"
            Update the selected product
            Display the total price at the end of list
            Click "Save" button to create the order
            Update the selected list to "Order" table and "OrderDetail " table by "ProductId" and "AgentId"
            Update "TotalRevenue" to the ordered agent
            Update stock product by reduce the quantity of selected product in the "OrderDetail" table
            Click "" button to printing the bill
            Update to "History" table
        */
        public int stockMaxAvailible;
        private void buyProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.buyProductView.Rows[e.RowIndex];

                if (Convert.ToInt32(row.Cells[2].Value) == 0)
                {
                    MessageBox.Show("This product is unavailable");
                }
                else
                {
                    selectedProductId.Text = row.Cells[0].Value.ToString();
                    selectedProductName.Text = row.Cells[1].Value.ToString();
                    selectedProductUnitPrice.Text = row.Cells[7].Value.ToString();
                }
                stockMaxAvailible = Convert.ToInt32(row.Cells[5].Value);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear the list ?", "Clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                purchaseListView.Rows.Clear();
            }
        }

        private void selectedProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            selectedProductQuantity.Minimum = 0;
            selectedProductQuantity.Maximum = stockMaxAvailible;
            checkProductStock();
        }

        private void removeFromBillBtn_Click(object sender, EventArgs e)
        {
            if (purchaseListView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in purchaseListView.SelectedRows)
                {
                    purchaseListView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void productIdInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedAgentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string cmd = "SELECT AgentNumber, AgentAddress FROM Agent WHERE AgentId = '"+selectedAgentId.Text+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count != 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    selectedAgentPhone.Text = row[0].ToString();
                    selectedAgentAddress.Text = row[1].ToString();
                }
            }
            con.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            searchOrderById(orderIdSearch.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searchOrderByAgentId(orderAgentIdSearch.Text);
        }

        private void HistoryFormBtn_Click(object sender, EventArgs e)
        {
            pageControl.SelectedTab = historyPage;
        }

        private void orderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void orderView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string getId = "";
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.orderView.Rows[e.RowIndex];
                getId = row.Cells[0].Value.ToString();
            }
            OrderDetail orderDetail = new OrderDetail(getId);
            orderDetail.ShowDialog();
            ReloadForm();
            orderDetail.Dispose();
        }
    }
}
