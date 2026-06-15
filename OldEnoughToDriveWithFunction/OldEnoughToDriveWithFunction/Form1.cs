using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OldEnoughToDriveWithFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void isdrive()
        {
            int a = Convert.ToInt16(textBox1.Text);
            if (a >= 18)
            {
                label2.Text = "Eligible to drive";
            }
            else
            {
                label2.Text = "not Eligible to drive";
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
           isdrive();
        }
    }
}
