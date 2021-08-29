using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19012011094_Practical16
{
    public partial class Example2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DataClassesDataContext ds = new DataClassesDataContext();
        protected void Button1_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            string fname = TextBox3.Text;
            string mname = TextBox4.Text;
            var st = new MyData
            {
                RollNumber = no,
                StudentName = name,
                FatherName = fname,
                MotherName = mname
            };

            ds.MyDatas.InsertOnSubmit(st);
            ds.SubmitChanges();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Inserted Successfully.!!!!')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int no = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            string fname = TextBox3.Text;
            string mname = TextBox4.Text;
            var st1 = (from s in ds.MyDatas where s.RollNumber == no select s).First();
            st1.StudentName = name;
            st1.FatherName = fname;
            st1.MotherName = mname;
            ds.SubmitChanges();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Update Successfully.!!!!')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(TextBox1.Text);
            var st2 = (from s in ds.MyDatas where s.RollNumber == no1 select s).First();
            ds.MyDatas.DeleteOnSubmit(st2);
            ds.SubmitChanges();
            Response.Write("<script LANGUAGE='JavaScript'>alert('Deleted Successfully.!!!!')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var selectquery = from a in ds.MyDatas select a;
            GridView1.DataSource = selectquery;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            TextBox1.Text = GridView1.Rows[rowind].Cells[1].Text;
            TextBox2.Text = GridView1.Rows[rowind].Cells[2].Text;
            TextBox3.Text = GridView1.Rows[rowind].Cells[3].Text;
            TextBox4.Text = GridView1.Rows[rowind].Cells[4].Text;
        }
    }
}