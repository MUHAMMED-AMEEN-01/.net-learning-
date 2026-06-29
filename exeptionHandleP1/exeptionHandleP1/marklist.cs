
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exeptionHandleP1
{
    class marklist
    {
        public static string name;
        public static int mark;

        public static void markShow() {
            MessageBox.Show("Name: " + name + "\nMark: " + mark);
        }
    }
}
