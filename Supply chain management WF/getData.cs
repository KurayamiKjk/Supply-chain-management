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
        public static DataTable getTopProductData()
        {
            con.Open();
            string querry = "SELECT TOP(5)* FROM (SELECT ProductId AS ID, ProductName AS Name FROM Product ) t1 \r\nLEFT JOIN (SELECT ProductId, Sum(Quantity) AS Sell_Number , Sum(Quantity * PriceEach) AS Total_Sale FROM OrderDetail JOIN [dbo].[Order] ON OrderDetail.OrderId = [dbo].[Order].OrderId WHERE [dbo].[Order].OrderStatus = 1 GROUP BY ProductId\r\n) t2 ON t1.ID = t2.ProductId ORDER BY t2.Total_Sale DESC";
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
        public static DataTable getTopAgentData()
        {
            con.Open();
            string querry = "SELECT TOP(5)* FROM [dbo].[Agent] ORDER BY TotalRevenue DESC";
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
        public static DataTable getAgentHistoryData()
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[History] WHERE SubjectName = 'Agent'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
        public static DataTable getProductHistoryData()
        {
            con.Open();
            string querry = "SELECT * FROM [dbo].[History] WHERE SubjectName = 'Product'";
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
        public static DataTable getRevenue()
        {
            con.Open();
            string querry = "SELECT Revenue, UpdateDate , SoldProduct FROM [dbo].[Revenue] ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, con);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            con.Close();
            return dataTable;
        }
    }

}
