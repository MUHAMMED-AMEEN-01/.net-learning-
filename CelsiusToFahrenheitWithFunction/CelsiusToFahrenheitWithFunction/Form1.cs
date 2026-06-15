using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CelsiusToFahrenheitWithFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void change(){
            int c= int.Parse(textBox1.Text);
            int f= (c*9/5)+32;
            textBox2.Text=f.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change();
        }
    }
}
