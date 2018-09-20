using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for MyUtils
/// </summary>
namespace UtilsCode
{
    public class MyUtils
    {
        public static SqlConnection ConnectDb()
        {
            SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;uid=sa;pwd=123456;database=test");
            return con;
        }
        public static void execute(string input)
        {
            SqlConnection con = ConnectDb();
            con.Open();
            SqlCommand com = new SqlCommand(input,con);
            com.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable createDt(string input)
        {
            SqlConnection con = ConnectDb();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(input, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}