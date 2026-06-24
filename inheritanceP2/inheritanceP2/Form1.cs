using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inheritanceP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perm obj = new Perm();
            Temp ob = new Temp();
            if (obj.accomadation > 0)
            {
                obj.name = textBox1.Text;
                obj.basePay = int.Parse(textBox2.Text);
                obj.food = int.Parse(textBox3.Text);
                obj.accomadation = int.Parse(textBox4.Text);
                MessageBox.Show(obj.calc(obj.food, obj.accomadation));
            }
            else
            {
                ob.name = textBox1.Text;
                ob.basePay = int.Parse(textBox2.Text);
                ob.travel = int.Parse(textBox3.Text);
                ob.shift = int.Parse(textBox4.Text);
                MessageBox.Show(obj.calc(ob.shift, ob.travel));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Food :";
            label4.Text = "Accomadation :";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Travel :";
            label4.Text = "Shift :";
        }
    }
}
