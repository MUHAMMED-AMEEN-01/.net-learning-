using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiplicationTableUsingforloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + "X" + a + "=" + a * i);
            }
        }
    }
}
