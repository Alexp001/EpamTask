using System;

namespace Figures
{
    public class Polygon : Figure
    {
        public Polygon(int Size, params Point[] Points) : base(Size)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                points[i] = new Point();
                points[i] = Points[i];
            }
        }

        public override double Area()
        {
            double MinX = points[0].x, MinY = points[0].y;
            for (int i = 0; i < points.Length; i++)
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
                for (int i = 0; i < points1.Length - 1; i++)
                {
                    area1 += points1[i].x * points1[i + 1].y - points1[i + 1].x * points1[i].y;
                }
                area1 += points1[points1.Length - 1].x * points1[0].y - points1[1].x * points1[points1.Length - 1].y;
                return Math.Abs(area1) / 2;
            }
            double area = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                area += points[i].x * points[i + 1].y - points[i + 1].x * points[i].y;
            }
            area += points[points.Length - 1].x * points[0].y - points[1].x * points[points.Length - 1].y;
            return Math.Abs(area) / 2;
        }
    }
}
