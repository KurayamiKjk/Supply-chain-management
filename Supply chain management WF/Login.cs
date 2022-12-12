using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Supply_chain_management_WF
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        private SqlConnection con = DBConnection.GetConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            usernameInput.Text = String.Empty;
            passwordInput.Text = String.Empty;
            usernameInput.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String userName, password;
            userName= usernameInput.Text;
            password= passwordInput.Text;
            if(userName != String.Empty || password != String.Empty)
            {
                try
                {
                    string querry = "SELECT * FROM Employees Where UserName = '" + userName + "' AND UserPassword = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        userName = usernameInput.Text;
                        password = passwordInput.Text;
                        this.Hide();
                        Product product = new Product();
                        product.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong user name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordInput.Text = String.Empty;
                        usernameInput.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("There was a error");
                    MessageBox.Show(userName);
                    MessageBox.Show(password);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("You are missing some infomation");
                usernameInput.Focus();
            }
            

            //TO DO: Check user login info: username and password


        }
    }
}
