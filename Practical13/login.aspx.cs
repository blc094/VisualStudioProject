using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practical13
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhanwar\Documents\register.mdf;Integrated Security=True;Connect Timeout=30");
            con1.Open();
            SqlCommand com = new SqlCommand("checkuser", con1);
            com.CommandType =CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("uname", TextBox1.Text);
            SqlParameter p2 = new SqlParameter("pwd", TextBox2.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);

            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                Session["uname"] = TextBox1.Text;
                Response.Redirect("welcomepage.aspx");
            }
            else
            {
                Response.Write("Invalid username or password.");
            }
        }
    }
}