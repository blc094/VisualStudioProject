using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        string username = "UVPCE", password = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            string username1 = textBox1_username.Text;
            string password1 = textBox2_password.Text;
            if(username1.Equals(username) && password1.Equals(password))
            {
                Home h2 = new Home();
                h2.Show();
                this.Hide();
            }
        }
    }
}
