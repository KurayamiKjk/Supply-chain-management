using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_chain_management_WF
{
    public static class getData
    {
        public static SqlConnection con = DBConnection.GetConnection();
        public static DataTable getProductData()
        {
            con.Open();
            string querry = "SELECT ProductId as 'Product ID',ProductName as 'Product Name',ProductStatus as 'Available',ProductCreateDate as 'Create Date',ProductUnit,ProductQuantity,ProductDocument,ProductUnitPrice,TotalCost FROM Product";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public static DataTable getAgentData()
        {
            con.Open();
            string querry = "SELECT * FROM Agent";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public static DataTable getOrderData()
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[Order]";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public static DataTable getOrderHistoryData()
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[History] WHERE SubjectName = 'Order'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public static DataTable getOrderDetailData(string id)
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[OrderDetail] WHERE OrderId = '"+id+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }

}
