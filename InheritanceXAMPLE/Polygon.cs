using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Polygon:Shapes
    {
        protected int side;

        public Polygon(string name, int side):base(name)
        {
            this.side = side;
        }
    }
}
