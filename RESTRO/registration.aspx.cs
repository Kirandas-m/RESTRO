using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace RESTRO
{
    public partial class REG : System.Web.UI.Page
    {
        string Sql;
        connection obj = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Sql = "insert into registration values('" + TextBox2.Text + "'," + TextBox3.Text + ",'"+TextBox4.Text+"','"+TextBox5.Text+"')";

                obj.insupdel(Sql);

                Label6.Text = "data inserted successfully";

                //Response.Write("<script >alert('Login Successful')</script>");



                //MessageBox.Show("Data inserted Succ"essfully", "message");

            }
            catch (Exception ex)
            {
                Response.Write("ex.message");

            }
           Response.Redirect("login.aspx");
        }
    }
}