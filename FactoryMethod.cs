using System;

namespace Factories
{
    public enum CoordinateSystem
    {
        Cartesian, Polar
    }
    public class Point
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), theta * Math.Sin(theta));
        }
        private double x, y;

        public Point(double x, double y, CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            this.x = x;
            this.y = y;
         }
        public override string ToString()
        {
            return $"{nameof(x)}:{x}, {nameof(y)}:{y}";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point);
        }
    }
}
