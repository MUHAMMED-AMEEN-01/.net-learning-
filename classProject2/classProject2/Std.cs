using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classProject2
{
    class Std
    {
        private string nm;
        private int m1, m2;
        public void func(string name, int n1, int n2)
        {
            nm = name;
            m1 = n1;
            m2 = n2;
        }
        public string[] ret()
        {
            string[] ret={nm,m1.ToString(),m2.ToString()};
            return ret;
        }
    }
}
