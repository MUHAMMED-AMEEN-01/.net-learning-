using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace addListItemUsingforLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                listView1.Items.Add(i.ToString());
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i <= 15)
            {
                listBox1.Items.Add(i);
                listView1.Items.Add(i.ToString());
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
        }
    }
}
