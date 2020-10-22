using System;

namespace Figures
{
    public class Square : Figure
    {
        public Square(Point a, Point b, Point c, Point d, int Size = 4) : base(Size)
        {
            points[0] = new Point();
            points[0] = a;
            points[1] = new Point();
            points[1] = b;
            points[2] = new Point();
            points[2] = c;
            points[3] = new Point();
            points[3] = d;
        }

        public override String FigureType()
        {
            return "Square";
        }
        public override double Area()
        {
            return Math.Pow(Point.LengthStraight(points[0], points[1]), 2);
        }
    }
}
