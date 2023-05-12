using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace RESTRO
{
   

    public partial class HOME : System.Web.UI.Page
    {
        string Sql;
        connection obj = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           try
           { 
                Sql = "insert into login values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+DropDownList1.SelectedItem.ToString()+"')";
                obj.insupdel(Sql);

                Label1.Text = "data inserted successfully";

                //Response.Write("<script >alert('Login Successful')</script>");
                  
               
             
                //MessageBox.Show("Data inserted Succ"essfully", "message");
                
           }
            catch (Exception ex) 
           {
                Response.Write("ex.message");
                   
           }

        }
    }
}