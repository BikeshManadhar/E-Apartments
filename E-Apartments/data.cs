using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Apartments
{
    internal class data
    {
        public static string cs = ConfigurationManager.ConnectionStrings["dbcon"].ToString();
        //Configuration String
        public static void ExecuteQuery(string sql)
        //Method for executing query
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();//used for executing quries
                                      //that do not return any data
            }
        }
        public static DataSet getdata(string sql)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
    }
}
