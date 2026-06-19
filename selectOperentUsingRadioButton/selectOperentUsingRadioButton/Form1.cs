using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace selectOperentUsingRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(numericUpDown1.Value);
            int b = Convert.ToInt16(numericUpDown2.Value);
            int r=0;
            if (radioButton1.Checked)
            {
                r = a + b;
            }
            else if (radioButton2.Checked)
            {
                r = a - b;
            }
            else if (radioButton3.Checked)
            {
                r = a * b;
            }
            else if(radioButton4.Checked)
            {
               if (b != 0)
               {
                    r = a / b;
               }
                else
                {
                    MessageBox.Show("Can't divide by zero!!");
                }
            }
            textBox3.Text = r.ToString();
        }
    }
}
