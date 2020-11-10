using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Classes
{
    class Rectangle
    {
        private int v;

        public double length { get; set; }
        public double width { get; set; }

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public Rectangle(int v)
        {
            this.v = v;
        }

        public double CalculateAreaRect()
        {
            return length * width;
        }
        
        public double CalculatePerimeterRect()
        {
            return length + length + width + width;
        }
    }
}
