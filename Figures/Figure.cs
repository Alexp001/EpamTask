﻿using System;

namespace Figures
{
    public abstract class Figure
    {
        public Point[] points;

        public Figure(int Size)
        {
            points = new Point[Size];
        }
        public abstract double Area();
        abstract public String FigureType();
        public virtual double Perimeter()
        {
            double Perimetr = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length - 1)
                    Perimetr += Point.LengthStraight(points[i], points[0]);
                else
                    Perimetr += Point.LengthStraight(points[i], points[i + 1]);
            }
            return Perimetr;
        }

        public void DisplayFigure()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Point.DisplayPoint(points[i]);
            }
        }
    }
}
