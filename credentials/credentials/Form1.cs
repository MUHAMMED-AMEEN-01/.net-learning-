using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace credentials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user, pass;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pass = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == "admin" && pass == "password")
            {
                label3.Text = "Login successfully";
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label3.Text = " invalid username and password";
                label3.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
