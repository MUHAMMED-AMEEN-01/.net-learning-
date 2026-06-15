using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleIntrestWithFunctioin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int getintrest()
        {
            int p, r, t,si;
            p = int.Parse(textBox1.Text);
            r = int.Parse(textBox2.Text);
            t = int.Parse(textBox3.Text);
            si=(p*r*t)/100;
            return si;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text= getintrest().ToString();
        }
    }
}
