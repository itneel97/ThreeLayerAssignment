using BusinessObject;
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
    public class SalesmanDA
    {
        /// <summary>
        ///  This method is being used to fetch data and load it into the grid view.
        /// </summary>
        public DataSet BindGridView()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["firstDBConnectionString"].ConnectionString))
            {
                string query = "select * from Salesman";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
            }

            return ds;
        }
        /// <summary>
        /// This method inserts new salesman into the database.
        /// </summary>
        /// <param name="newSalesman"></param>
        /// <returns></returns>
        public int InsertSalesman(SalesmanBO newSalesman)
        {
            int rowInserted;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["firstDBConnectionString"].ConnectionString))
            {
                try
                {
                    string query = "Insert into Salesman (salesman_id, name, city, comission) values (@Id, @Name, @City, @Commission) ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(newSalesman.Id));
                    cmd.Parameters.AddWithValue("@Name", (newSalesman.Name));
                    cmd.Parameters.AddWithValue("@City", (newSalesman.City));
                    cmd.Parameters.AddWithValue("@Commission", Convert.ToDecimal(newSalesman.Commission));
                    con.Open();
                    rowInserted = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    rowInserted = 0;
                    Console.WriteLine($"Error: {ex.Message}");
                }
                return rowInserted;
            }
        }
       
    }
}
