using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddItemToArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[5];
        int i=-1;

        private void button1_Click(object sender, EventArgs e)
        {
            //int temp=int.Parse(textBox1.Text);
            i++;
            if (i < 5)
            {
                a[i] = int.Parse(textBox1.Text);
            }
            else
            {
                label2.Text = "Array is full!!";
                label2.ForeColor = System.Drawing.Color.Red;
            }
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int j = 0; j <= i; j++)
            {
                listBox1.Items.Add(a[j]);
            }
        }
    }
}
