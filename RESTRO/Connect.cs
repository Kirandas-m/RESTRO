using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace RESTRO
{
    internal class connection
    {
        SqlDataAdapter adp;
        SqlCommand cmd;
        public SqlConnection connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hp\\source\\repos\\RESTRO\\RESTRO\\App_Data\\login.mdf;Integrated Security=True");
            conn .Open();
            return conn;    

        }
        public void insupdel(string str)
        {
            cmd = new SqlCommand(str,connect());
            cmd.ExecuteNonQuery();
        }
        public DataSet DisplayAll(string str)
        {
            adp = new SqlDataAdapter(str,connect());
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;  
        }

    }
    public class Connect
    {
    }

}