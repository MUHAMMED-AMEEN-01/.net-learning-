using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace constructerP1
{
    class constecter
    {
        // constrecter is a function name is exactily class name
        private string a;
        //defalt constructer

        public constecter()
        {
            a = "this is from a constructer";
        }

        //properties

        public string ab
        {
            get { return a; }
        }
        
        //parametariezed consrtuctor

        public constecter(string b)
        {
            a = b;
        }
    }
}
