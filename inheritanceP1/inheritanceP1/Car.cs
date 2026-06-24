using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritanceP1
{
    class Car : Vehicle
    {
        public string model;
        public String st()
        {
           return start(model);
        }
    }
}
