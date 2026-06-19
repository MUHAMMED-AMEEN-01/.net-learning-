using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace languageCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lang="";
            if (checkBox1.Checked)
            {
                lang += "Malayalam ";
            }
            if (checkBox2.Checked)
            {
                lang += "English ";
            }
            if (checkBox3.Checked)
            {
                lang += "Hindi ";
            }
            if (checkBox4.Checked)
            {
                lang += "Tamil ";
            }
            MessageBox.Show("You are submited you know these languages :" + lang);
        }
    }
}
