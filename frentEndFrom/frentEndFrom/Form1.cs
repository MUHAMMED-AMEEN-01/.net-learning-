using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frentEndFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo();
        }
        void combo()
        {
            string[] cmb = { "SSLC", "+2", "UG", "PG", "Other" };
            foreach (string c in cmb)
            {
                comboBox1.Items.Add(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gndr, lang ="";
            if (radioButton1.Checked)
            {
                gndr = "Male";
            }
            else if (radioButton2.Checked)
            {
                gndr = "Female";
            }
            else
            {
                gndr = "Other";
            }

            // languages
            if (checkBox1.Checked) {
                lang += "English";
            }
            if (checkBox2.Checked) {
                lang += "Malayalam";
            }
            if (checkBox3.Checked)
            {
                lang += "Tamil";
            }
            if (checkBox4.Checked)
            {
                lang += "Hindi";
            }
            if (checkBox5.Checked)
            {
                lang += "Kanada";
            }
            if (checkBox6.Checked)
            {
                lang += "Urudu";
            }
            MessageBox.Show("Your details\n\nFull name:- "+textBox1.Text+"\nDate of birth:- "+dateTimePicker1.Value+"\nGender:- "+gndr+"\nQualifiaction:- "+comboBox1.SelectedItem+"\nLanguages:- "+lang);
        }
    }
}
