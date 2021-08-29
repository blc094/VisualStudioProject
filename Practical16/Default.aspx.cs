using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _19012011094_Practical16
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClassesDataContext sd = new DataClassesDataContext();
            MyData st = (from student in sd.MyDatas where student.RollNumber.ToString() == TextBox1.Text select student).FirstOrDefault();
            if (st == null)
            {
                Label2.Text = "No record found!";
            }
            else
            {
                Label2.Text = "Record found successfully!";
                TextBox2.Text = st.StudentName;
                TextBox3.Text = st.FatherName;
                TextBox4.Text = st.MotherName;
            }
        }
    }
}