using System;
using System.Collections.Generic;

namespace Point_and_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(10, 5, "A"));
            points.Add(new Point(3, 9, "B"));
            points.Add(new Point(8, 15, "C"));
            points.Add(new Point(2, 3, "D"));
            points.Add(new Point(5, 12, "E"));

            Figure triangle = new Figure(points[0], points[1], points[2]);
            Console.WriteLine(triangle.PerimeterCalculator());

            Figure rectangle = new Figure(points[0], points[1], points[2], points[3]);
            Console.WriteLine(rectangle.PerimeterCalculator());

            Figure pentagon = new Figure(points[0], points[1], points[2], points[3], points[4]);
            Console.WriteLine(pentagon.PerimeterCalculator());
        }
    }
}
