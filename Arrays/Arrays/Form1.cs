using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int[] i = { 10, 12, 13, 23 };
            for (int j = 0; j < 4; j++){
                listBox1.Items.Add( i[j]);
            }
        }
    }
}
