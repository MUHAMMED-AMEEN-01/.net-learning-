using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interfaceP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            v1 obj1 = new v1();
            obj1.calc(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            v2 obj2 =new v2();
            obj2.calc(a, b);
        }
    }
}
