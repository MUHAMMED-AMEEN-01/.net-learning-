using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace arrayListInReverseOrder
{
    public partial class Form1 : Form
    {
        ArrayList arr = new ArrayList() { 12, 45, 23, 65, 11 };
        public Form1()
        {
            InitializeComponent();
            foreach (int a in arr)
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 4; i >= 0; i--)
            {
                listBox2.Items.Add(arr[i]);
            }
        }
    }
}
