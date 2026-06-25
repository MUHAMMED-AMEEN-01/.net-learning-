using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interfaceP1
{
    class v1 : Calculator
    {

        public void calc(int a, int b)
        {
            double sum, dif, mul, div, mod;
            sum = a + b;
            dif = a - b;
            mul = a * b;
            div = a / b;
            mod = a % b;
            MessageBox.Show("sum :-" + sum + "\nDiference :-" + dif + "\nMultiplication :-" + mul + "\nDivition :-" + div + "\nmodules :-" + mod);
        }
    }
}
