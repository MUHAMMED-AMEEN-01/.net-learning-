using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace numberExistsInAnArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList() { 12, 25, 35, 57, 34 };

            foreach (int n in arr)
            {
                if (numericUpDown1.Value == Convert.ToInt16(n))
                {
                    label2.Text = "find " + numericUpDown1.Value + " in ArrayList";
                    break;
                }
                else
                {
                    label2.Text = "Can't find " + numericUpDown1.Value + " in ArrayList";
                }
            }
        }
    }
}
