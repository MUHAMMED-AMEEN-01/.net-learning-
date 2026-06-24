using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inheritanceP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car obj = new Car();
            obj.model = "Siwft";
            MessageBox.Show(obj.start());
            MessageBox.Show(obj.st());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bus obj = new Bus();
            obj.model = "Volvo";
            MessageBox.Show(obj.start());
        }
    }
}
