using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace old_enough_to_drive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        private void button1_Click(object sender, EventArgs e)
        {
            if (a > 17)
            {
                textBox2.Text = "Eligible";
            }
            else
            {
                textBox2.Text = "Not Eligible";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
        }
    }
}
