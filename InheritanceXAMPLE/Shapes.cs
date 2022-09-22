using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Shapes
    {
        protected string name;

        public Shapes(string name)
        {
            this.name = name;
        }

        public void SetName(string name)
        {
                this.name=name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
