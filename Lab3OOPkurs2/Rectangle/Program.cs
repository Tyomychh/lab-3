using System;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            Rectangle rectangle = new Rectangle(9.5, 3.7);
            Console.WriteLine("Периметр  " + rectangle.PerimeterCalculator());
            Console.WriteLine("Площа  " + rectangle.PloschaCalculator());
        }
    }
}
