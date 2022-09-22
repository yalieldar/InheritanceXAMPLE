using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class rectangle:Polygon
    {
        protected double length;
        protected double width;

        public rectangle(string name, int side,double length, double width): base(name,side)
        {
            this.length = length;
            this.width = width;
        }

        public double GetExtent(double length, double width)
        {
            return length*2+ width*2;
        }

        public double GetArea(double length, double width)
        {
            return length*width;
        }

        public bool IfSquare(double length, double width)
        {
            if(length==width)
                return true;
            return false;
        }

    }
}
