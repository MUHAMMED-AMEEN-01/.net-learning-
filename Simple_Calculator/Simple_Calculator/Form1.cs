using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a , b, c;
        string op;
        //string color="System.Drawing.Color.Tan";

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           // color = "System.Drawing.Color.White";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = 0;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "+";

            //button9.BackColor=color;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = 0;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = 0;

            //Normal methode
            //a = Convert.ToDouble(textBox1.Text);

            //parse methode
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            op = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 0;
            //a = Convert.ToDouble(textBox1.Text);

            //parse int methode.....
            a=double.Parse(textBox1.Text);
            textBox1.Text = "";
            op = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b =Convert.ToDouble( textBox1.Text);
            //switch (op)
            //{
            //    case "+": c = a + b;
            //        break;
            //    case "-": c = a - b;
            //        break;
            //    case "*": c = a * b;
            //        break;
            //    case "/": c = a / b;
            //        break;

            //}
            if (op == "+")
            {
                c = a + b;
            }
            else if (op == "-")
            {
                c = a - b;
            }
            else if (op == "*")
            {
                c = a * b;
            }
            else
            {
                c = a / b;
            }
            textBox1.Text = c.ToString();
        }
    }
}
