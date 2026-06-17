using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace findMinimumAndMaximumUsingForeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void finder(int[] a)
        {
            int max = a[0];
            int min = a[0];
            foreach (int i in a)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            textBox1.Text = max.ToString();
            textBox2.Text = min.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 10, 25, 5, 40, 15 };
            finder(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] a = { 8, 3, 12, 6, 20, 1 };
            finder(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] a = { 100, 50, 25, 75, 10 };
            finder(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] a = { 45, 67, 23, 89, 12, 34 };
            finder(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] a = { 34, -5, 78, 0, 12, -20, 56 };
            finder(a);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] a = { 999, 456, 123, 789, 321, 654 };
            finder(a);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] a = { 7, 7, 15, 2, 2, 50, 30 };
            finder(a);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] a = { -10, -50, -3, -100 - 0 };
            finder(a);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[] a = { 15, 42, 8, 63, 29, 4 };
            finder(a);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] a = { 55, 11, 90, 33, 77, 22 };
            finder(a);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int[] a = { 200, 150, 300, 50, 400 };
            finder(a);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            finder(a);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int[] a = { 500, 100, 900, 300, 700 };
            finder(a);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int[] a = { -25, 40, -10, 60, 5 };
            finder(a);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int[] a = { 99, 45, 67, 12, 5, 88 };
            finder(a);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int[] a = { 120, 45, 78, 90, 33, 10 };
            finder(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int[] a = { 1000, 2500, 500, 7500, 1500 };
            finder(a);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int[] a = { 6, 18, 2, 14, 30, 9 };
            finder(a);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int[] a = { -100, 50, -30, 80, 20 };
            finder(a);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int[] a = { 88, 44, 22, 11, 99, 66 };
            finder(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
