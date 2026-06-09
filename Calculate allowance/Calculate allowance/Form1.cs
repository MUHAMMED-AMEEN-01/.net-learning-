using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate_allowance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float b, p, a;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = float.Parse(textBox1.Text);
            if (b < 30000)
            {
                p = 10;
            }
            else if (b > 30000 && b < 50000)
            {
                p = 15;
            }
            else
            {
                p = 20;
            }
            textBox2.Text = p.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = (p / 100) * b;
            textBox3.Text = a.ToString();
        }

    }
}
