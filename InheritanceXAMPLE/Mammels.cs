using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    public class Mammels:Animals
    {
        private double milk;

        public Mammels(double milk, string type, double weight, string name):base(type, weight, name)
        {
            this.milk = milk;
        }
        public Mammels(double milk)
        {
            this.milk = milk;
        }   

        public Mammels()
        {

        }

    }
}
