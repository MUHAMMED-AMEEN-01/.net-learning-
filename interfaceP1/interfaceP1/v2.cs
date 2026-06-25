using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interfaceP1
{
    class v2 : Calculator
    {
        public void calc(int a, int b)
        {
            MessageBox.Show("Addition : "+(a+b)+"\nDifference : "+(a-b)+"\nMultiplication : "+(a*b)+"\nDivition : "+(a/b)+"\nMudulas : "+(a%b));
        }
    }
}
