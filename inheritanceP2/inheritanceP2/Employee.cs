using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritanceP2
{
    class Employee
    {
        public string name;
        public int basePay;

        public string calc(int a, int b)
        {
            return (basePay + a+b).ToString();
        }
    }
}
