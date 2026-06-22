using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace classPropertiesProgram1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            obj = new std();
        }

        std obj;
        

        private void button1_Click(object sender, EventArgs e)
        {
            obj.name = textBox1.Text;
            obj.mark = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = obj.name;
            textBox2.Text = obj.mark.ToString();
        }
    }
}
