using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace genderRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gndr;
            if (radioButton1.Checked)
            {
                gndr = "Male";
            }
            else
            {
                gndr = "Female";
            }
            MessageBox.Show("Seleceted gender is " + gndr);
        }
    }
}
