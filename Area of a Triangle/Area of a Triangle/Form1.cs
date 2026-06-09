using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Area_of_a_Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, l, w;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            l = float.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            w = float.Parse(textBox2.Text); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = l * w;
            textBox3.Text = a.ToString();
        }

    }
}
