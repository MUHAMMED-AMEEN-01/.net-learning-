using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace shortAscendingOrder
{
    public partial class Form1 : Form
    {
        ArrayList arr = new ArrayList() { 12, 34, 56, 11, 8 };
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
            int i = 0;
            int tmp= Convert.ToInt16(arr[0]);
            while (i < 5)
            {
               /* if (tmp < Convert.ToInt16(arr[i]))
                {
                    tmp = Convert.ToInt16(arr[i]);
                }*/
                for (int j = i+1; j < 5; j++)
                {
                    if (Convert.ToInt16(arr[j]) < Convert.ToInt16(arr[i])) {
                        tmp = Convert.ToInt16(arr[j]);
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
                i++;
            }
            foreach (int a in arr)
            {
                listBox2.Items.Add(a);
            }
        }
    }
}
