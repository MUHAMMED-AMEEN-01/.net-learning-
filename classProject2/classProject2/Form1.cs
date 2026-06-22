using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Std obj;


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Std();
            int m1=int.Parse(textBox2.Text);
            int m2 = int.Parse(textBox3.Text);
            obj.func(textBox1.Text,m1,m2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] a= obj.ret();
            textBox1.Text = a[0];
            textBox2.Text = a[1];
            textBox3.Text = a[2];
        }
    }
}
