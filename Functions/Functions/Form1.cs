using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables

        int a,b,sum;

        // functions 

        void add1()
        {

            sum = int.Parse(textBox1.Text) +Convert.ToInt32(textBox2.Text);
            textBox3.Text = sum.ToString();
        }

        void add2(int num1, int num2)
        {
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        string add3()
        {
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            return sum.ToString();
        }

        string add4(int num1, int num2)
        {
            sum = num1 + num2;
            return sum.ToString();
        }

        //Click functions 

        private void button1_Click(object sender, EventArgs e)
        {

            add1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            add2(a, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = add3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox3.Text = add4(a, b);
        }
    }
}
