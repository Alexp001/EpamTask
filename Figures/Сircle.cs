using System;

namespace Figures
{
    public class Сircle : Figure
    {
        public Сircle(Point a, Point b, int Size = 2) : base(Size)
        {
            points[0] = new Point();
            points[0] = a;
            points[1] = new Point();
            points[1] = b;
        }


        public override String FigureType()
        {
            return "Сircle";
        }
        public override double Area()
        {
            return Math.Pow(Point.LengthStraight(points[0], points[1]), 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Point.LengthStraight(points[0], points[1]);
        }
    }
}
