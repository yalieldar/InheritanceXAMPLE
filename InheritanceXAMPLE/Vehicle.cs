using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal abstract class Vehicle
    {
        protected int wheels;

        public Vehicle (int wheels)
        {
            this.wheels = wheels;
        }

        public int GetWheels()
        {
            return this.wheels;
        }
        
        public void SetWheels(int wheels)
        {
            this.wheels=wheels;
        }
    }
}
