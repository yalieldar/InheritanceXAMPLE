using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Triangle:Polygon
    {
        private double side1;
        private double side2;
        private double base1;
        private double height;

        public Triangle(double side1,double side2, double base1, double height, string name, int side):base(name,side)
        {
            this.side1=side1;
            this.side2=side2;
            this.base1=base1;
            this.height=height;
        }

        public double GetArea(double base1, double height)
        {
            return (base1*height)/2;
        }
        public double GetExtent(double side1,double side2, double base1)
        {
            return side1 + side2 + base1;
        }
        


    }
}
