using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    internal class Rectangle
    {
        private readonly double side1;
        private readonly double side2;
        private double area;
        private double perimeter;
        public Rectangle(double sside1, double sside2) 
        {
            this.side1 = sside1;
            this.side2 = sside2;
        }

        public double Ploscha
        {
            get
            {
                return area;
            }
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public double PloschaCalculator() => area = side1 * side2;
        public double PerimeterCalculator() => perimeter = 2 * (side1 + side2);
    }
}
