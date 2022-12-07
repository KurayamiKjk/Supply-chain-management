using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_chain_management_WF
{
    internal class updateHistory
    {
        public static SqlConnection con = DBConnection.GetConnection();

        public static void updateProductHistory(string subId, string name, string activity, string oldValue, string newValue, string preUpdateDate, string editBy)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[History] ([SubjectId], [SubjectName], [Activity], [OldValue], [NewValue], [PreUpdateDate], [EditedBy]) 
                VALUES ('"+subId+"', '" + name + "', '" + activity + "', '" + oldValue + "', '" + newValue + "' ,'"+preUpdateDate+"','"+editBy+"')", con);
            int isExecute = com.ExecuteNonQuery();
            if (isExecute == 0)
                MessageBox.Show("There was an error when save to history!");
            else
            con.Close();
        }
        public static void updateOrderHistory(string subId, string name, string activity, string oldStatus, string newStatus, string preUpdateDate, string editBy)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[History] ([SubjectId], [SubjectName], [Activity], [OldValue], [NewValue], [PreUpdateDate], [EditedBy]) 
                VALUES ('" + subId + "', '" + name + "', '" + activity + "', '" + oldStatus + "', '" + newStatus + "' ,'" + preUpdateDate + "','" + editBy + "')", con);
            int isExecute = com.ExecuteNonQuery();
            if (isExecute == 0)
                MessageBox.Show("There was an error when save to history!");
            else
                con.Close();
        }
        public static void updateAgentHistory(string subId, string name, string activity, string oldValue, string newValue, string preUpdateDate, string editBy)
        {
            con.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO [dbo].[History] ([SubjectId], [SubjectName], [Activity], [OldValue], [NewValue], [PreUpdateDate], [EditedBy]) 
                VALUES ('" + subId + "', '" + name + "', '" + activity + "', '" + oldValue + "', '" + newValue + "' ,'" + preUpdateDate + "','" + editBy + "')", con);
            int isExecute = com.ExecuteNonQuery();
            if (isExecute == 0)
                MessageBox.Show("There was an error when save to history!");
            else
                con.Close();
        }
    }
}
