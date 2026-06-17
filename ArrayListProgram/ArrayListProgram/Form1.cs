using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList a = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            a.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int h = 4;
            listBox1.Items.Clear();
            foreach (string b in a)
            {
                listBox1.Items.Add(b);
                if (h < 100)
                {
                    h += 15;
                }
            }
            listBox1.Size = new System.Drawing.Size(80, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Size = new System.Drawing.Size(80, 24);
            textBox1.Text = "";
            a.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
