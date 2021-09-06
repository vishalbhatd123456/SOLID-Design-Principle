using System;

namespace Factories
{
    public enum CoordinateSystem
    {
        Cartesian, Polar
    }
    public class Point
    {
        private double x, y;

        public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                /// <summary>
                /// <param name="a"></param>
                /// <param name="b"></param>
                /// <param name="system"></param>
                /// </summary> 
                case CoordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentNullException("Null Exception");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
