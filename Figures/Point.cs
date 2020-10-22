using System;

namespace Figures
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double a, double b)
        {
            x = a;
            y = b;
        }

        public static double LengthStraight(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }

        public static bool Parallelism(Point a, Point b, Point c, Point d)
        {
            if (a.x == b.x && c.x == d.x)
                return true;

            if (a.y == b.y && c.y == d.y)
                return true;

            if ((a.x - b.x) / (a.y - b.y) == (c.x - d.x) / (c.y - d.y))
                return true;

            return false;
        }

        public static void DisplayPoint(Point a)
        {
            Console.Write($"( {a.x}, {a.y} ) ");
        }

    }
}

