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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Supply_chain_management_WF
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KURAYAMIPC;Initial Catalog=SupplyChainManagement;Integrated Security=True");
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public int status;
        private void checkAvailable()
        {
            bool isAvailable = availableRadio.Checked;
            if (isAvailable)
            {
                status = 1;
            }
            else
            {
                status = 0;
            }
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            checkAvailable();
            SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[Product]
           ([ProductId]
           ,[ProductName]
           ,[ProductUnit]
           ,[ProductQuantity]
           ,[ProductDocument]
           ,[ProductUnitPrice]
           ,[TotalCost]
           ,[ProductStatus])
     VALUES
           ((SELECT MAX(Id) FROM Product) + 1,'" + productNameInput.Text+"','"+productUnitDropDown.Text+"','"+productQuantityInput.Value+"','"+productDescriptionInput.Text+"','"+productUnitPriceInput.Value+"','"+productUnitPriceInput.Value * productQuantityInput.Value+"','"+status+"')",con);
            com.ExecuteNonQuery();
            con.Close();
            this.Hide();
            Product product = new Product();
            product.Show();
        }

        private void cancleAddingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();
        }

        private void resetAddingBtn_Click(object sender, EventArgs e)
        {
            productNameInput.Clear();
            productUnitDropDown.ResetText();
            productQuantityInput.ResetText();
            productDescriptionInput.Clear();
            productUnitPriceInput.ResetText();
            totalPriceDisplay.ResetText();
        }

        private void productQuantityInput_ValueChanged(object sender, EventArgs e)
        {
            if(productQuantityInput.Value > 0 && productUnitPriceInput.Value > 0) 
            {
                try
                {
                    totalPriceDisplay.Value = Convert.ToDecimal(productQuantityInput.Value) * productUnitPriceInput.Value;
                    


                }
                catch (Exception ex) { }
            }
        }

        private void productUnitPriceInput_ValueChanged(object sender, EventArgs e)
        {
            if (productQuantityInput.Value > 0 && productUnitPriceInput.Value > 0)
            {
try
                {
                    totalPriceDisplay.Value = Convert.ToDecimal(productQuantityInput.Value) * productUnitPriceInput.Value;
                    

                }
                catch (Exception ex) { }
            }
        }

        private void totalPriceDisplay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
