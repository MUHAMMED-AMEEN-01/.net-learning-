using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReverseOderDropdownloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                comboBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 16)
            {
                comboBox1.Items.Add(i);
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
        }
    }
}
