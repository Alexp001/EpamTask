using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Trapezoid : Figure
    {
        public Trapezoid (Point a, Point b, Point c, Point d, int Size = 4) : base(Size)
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

        public override double Area()
        {
            double MinX = points[0].x, MinY = points[0].y;
            for (int i = 0;  i < points.Length; i++)
            {
                if (MinX > points[i].x)
                    MinX = points[i].x;
                if (MinY > points[i].y)
                    MinY = points[i].y;
            }
            if (MinX < 0 || MinY < 0)
            {
                Point[] points1 = new Point[points.Length];
                for (int i = 0; i < points.Length; i++)
                {
                    points1[i] = new Point();
                    points1[i].x = points[i].x;
                    points1[i].y = points[i].y;
                }
                for (int i = 0; i < points.Length; i++)
                {
                    points1[i].x += Math.Abs(MinX);
                    points1[i].y += Math.Abs(MinY);
                }
                double area1 = 0;
                for (int i = 0; i < 3; i++)
                {
                    area1 += points1[i].x * points1[i + 1].y - points1[i + 1].x * points1[i].y;
                }
                area1 += points1[3].x * points1[0].y - points1[1].x * points1[3].y;
                return Math.Abs(area1) / 2;
            }
            double area = 0;
            for (int i = 0; i < 3; i++)
            {
                area += points[i].x * points[i + 1].y - points[i + 1].x * points[i].y;
            }
            area += points[3].x * points[0].y - points[1].x * points[3].y;
            return Math.Abs(area) / 2;
        }


    }
}
