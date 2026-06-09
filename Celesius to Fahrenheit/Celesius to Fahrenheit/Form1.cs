using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Celesius_to_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float f, c;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c = float.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = (c * 9 / 5) + 32;
            textBox2.Text = f.ToString();
        }
    }
}
