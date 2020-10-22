using System;

namespace Figures
{
    public class Triangle : Figure
    {
        public Triangle(Point a, Point b, Point c, int Size = 3) : base(Size)
        {
            points[0] = new Point();
            points[0] = a;
            points[1] = new Point();
            points[1] = b;
            points[2] = new Point();
            points[2] = c;
        }

        public override String FigureType()
        {
            return "Triangle";
        }
        public override double Area()
        {
            return 1.0/ 2 * Math.Abs((points[0].x - points[2].x) * (points[1].y - points[2].y) - (points[1].x - points[2].x) * (points[0].y - points[2].y));
        }
    }
}
