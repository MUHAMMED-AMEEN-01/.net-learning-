using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace addArrayListAndFindSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        ArrayList arr = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (i < 5)
                {
                    arr.Add(numericUpDown1.Value);
                    label4.Text = "Element Added";
                    i++;
                }
                else
                {
                    label4.Text = "reach limit!! ";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum=0;
            foreach (decimal a in arr)
            {
                sum += Convert.ToInt16(a);
            }
            textBox1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                listBox1.Items.Add(arr[j]);
                
            }

        }
    }
}
