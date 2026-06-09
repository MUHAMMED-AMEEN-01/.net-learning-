using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Intrest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int p, r, t, i;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            r = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            t = int.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = (p * r * t) / 100;
            textBox4.Text = Convert.ToString(i);
        }
    }
}
