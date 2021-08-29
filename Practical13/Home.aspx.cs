using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
///using System.Data;
///using System.Text.RegularExpressions;

namespace Practical13
{
    public partial class Home : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhanwar\Documents\register.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string fname, lname, uname, pwd, email, country, state, city, address;
            fname = txt_fn.Text;
            lname = txt_ln.Text;
            uname = txt_un.Text;
            pwd = txt_p.Text;
            email = txt_e.Text;
            country = txt_c.Text;
            state = txt_s.Text;
            city = txt_ct.Text;
            address = txt_a.Text;

            long contactno = long.Parse(txt_cn.Text);

            string query = "insert into registerinfo values('" + fname + "','" + lname + "','" + uname + "','" + pwd + "'," + contactno + ",'" + email + "','" + country + "','" + state + "','" + city + "','" + address + "','" + txt_dob.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            Response.Write(query);
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                Response.Write("<script>alert('Registration done successfully')</script>");
            }
            else
            {
                Response.Write("Registration not done");
            }
            con.Close();
            txt_fn.Text = "";
            txt_ln.Text = "";
            txt_un.Text = "";
            txt_p.Text = "";
            txt_cn.Text = "";
            txt_e.Text = "";
            txt_c.Text = "";
            txt_s.Text = "";
            txt_ct.Text = "";
            txt_a.Text = "";
            txt_dob.Text = "";
        }
    }
}