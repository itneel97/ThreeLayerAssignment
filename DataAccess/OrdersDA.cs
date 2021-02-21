using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class OrdersDA
    {
        /// <summary>
        /// we can either use dataTable or we can use list as a type of method 
        /// </summary>
        /// <returns></returns>
        public DataTable BindGridView()
        {
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["firstDBConnectionString"].ConnectionString))
            {
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open(); 
		//My Task 1
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(tbl);
            }

            return tbl;
        }
    }
}
