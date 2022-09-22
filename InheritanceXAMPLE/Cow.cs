using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    internal class Cow:Mammels
    {
        private string color;
        public Cow(string color, int milk, string type, double weight, string name):base(milk, type, weight, name)
        {
            this.color = color;
        }

        public void SetColor(string color)
        {
            this.color=color;
        }

        public string GetColor()
        {
            return this.color;
        }

    }
}
