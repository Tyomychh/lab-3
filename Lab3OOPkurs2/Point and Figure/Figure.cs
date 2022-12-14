using System;
using System.Collections.Generic;
using System.Text;

namespace Point_and_Figure
{
    internal class Figure
    {
        private double _perimeter;
        public double Perimeter { get { return _perimeter; } set { this._perimeter = value; } }
        private readonly string shape;

        enum Shape
        {
            triangle,
            rectangle,
            pentagon
        }

        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            shape = Shape.triangle.ToString();
            Console.WriteLine(shape);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            shape = Shape.rectangle.ToString();
            Console.WriteLine(shape);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            shape = Shape.pentagon.ToString();
            Console.WriteLine(shape);
        }

        public static double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = Perimeter;
            if (shape == Shape.triangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, C) + LengthSide(B, C);
                return perimeter;
            }
            else if (shape == Shape.rectangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
                return perimeter;
            }
            else if (shape == Shape.pentagon.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, E) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E);
                return perimeter;
            }
            return perimeter;
        }
    }
}
