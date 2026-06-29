using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace staticP1
{
    class StacticC1
    {
        //static methode or variable have't need create objects . It access truogh class name

        public static int mark=0;
        public static void marklist()
        {
            MessageBox.Show("Name:Ameen\nMark:" + mark);
        }

    }
}
