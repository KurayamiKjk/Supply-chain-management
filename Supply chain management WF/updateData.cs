using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Supply_chain_management_WF
{
    internal class updateData
    {
        public static SqlConnection con = DBConnection.GetConnection();

        public static void updateOrderPaymentStatus(string orderId ,int status)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"UPDATE [dbo].[Order] SET PaymentStatus = '"+ status +"'  WHERE OrderId = '" + orderId + "';", con);
            int isExecute = com.ExecuteNonQuery();
            if (isExecute == 0)
                MessageBox.Show("Update payment status failed, there was an error!");
            else
                MessageBox.Show("Update payment status successed!");
            con.Close();
        }
        public static void updateOrderStatus(string orderId, int status)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"UPDATE [dbo].[Order] SET OrderStatus = '" + status + "'  WHERE OrderId = '" + orderId + "';", con);
            int isExecute = com.ExecuteNonQuery();
            if (isExecute == 0)
                MessageBox.Show("Update order status failed, there was an error!");
            else
                MessageBox.Show("Update order status successed!");
            con.Close();
        }
        public static void updateProductStock(string productId, int productQuantity)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"UPDATE [dbo].[Product] SET ProductQuantity = ProductQuantity - '" + productQuantity + "'  WHERE ProductId = '" + productId + "';", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void updateAgentTotalRevenue(string agentId, decimal total)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"UPDATE [dbo].[Agent] SET TotalRevenue = TotalRevenue + '" + total + "'  WHERE AgentId = '" + agentId + "';", con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public static void refreshNewData()
        {
            Product product = new Product();
            product.ReloadForm();
        }
        public static void updateRevenue()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[Revenue]([Revenue],[TotalRevenue],[SoldProduct]) VALUES((SELECT SUM(TotalPrice) FROM[dbo].[Order] WHERE OrderStatus = 1 AND MONTH([CreateDate]) = DATEPART(MONTH,GETDATE())),(SELECT SUM(Revenue) FROM[dbo].[Revenue]), (SELECT SUM(Quantity) FROM[dbo].[OrderDetail] JOIN[dbo].[Order] ON OrderDetail.OrderId = [dbo].[Order].OrderId WHERE[dbo].[Order].OrderStatus = 1))", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
