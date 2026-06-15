using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace credentialsUsingFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void check(string a, string b)
        {
            if (a == "admin" && b == "password")
            {
                label3.Text = "Login succusfully";
            }
            else
            {
                label3.Text = "credentials not maching !! try again!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            check(user, pass);
        }
    }
}
