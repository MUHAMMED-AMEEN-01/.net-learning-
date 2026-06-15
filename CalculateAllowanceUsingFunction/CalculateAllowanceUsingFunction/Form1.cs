using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculateAllowanceUsingFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double getAllowance()
        {
            double a, s;
            s = double.Parse(textBox1.Text);
            if (s < 30000)
            {
                a = s * 0.10;
            }
            else if (s >= 30000 && s < 50000)
            {
                a = s * 0.15;
            }
            else
            {
                a = s * 0.20;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text= getAllowance().ToString();
        }
    }
}
