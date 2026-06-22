using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classPropertiesProgram1
{
    class std
    {
        //members

        private string nm;
        private int m1;

        // properites

        public string name
        {
            set{nm=value;}
            get { return nm; }
        }
        public int mark
        {
            set { m1 = value; }
            get { return m1; }
        }
    }
}
