using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomersDA
    {

        public DataTable BindGridView()
        {
            DataTable tbl = new DataTable();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["firstDBConnectionString"].ConnectionString))
            {
                string query = "SELECT * FROM Customers";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(tbl);
            }

            return tbl;
        }
    }
}
