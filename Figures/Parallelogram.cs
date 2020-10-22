using System;

namespace Figures
{
    public class Parallelogram : Figure
    {
        public Parallelogram(Point a, Point b, Point c, Point d, int Size = 4) : base(Size)
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
            return "Parallelogram";
        }

        public override double Area()
        {
            return Math.Abs(Math.Abs(points[0].x - points[1].x) * Math.Abs(points[0].y - points[3].y) - Math.Abs(points[0].y - points[1].y) * Math.Abs(points[0].x - points[3].x));
        }
    }
}
