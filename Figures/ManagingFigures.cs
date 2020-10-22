using System;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
    public static class ManagingFigures
    {
        private const int NumberFigures = 9;
        private static readonly String[] NameFigures = { "Окружность", "Треугольник", "Трапиция", "Квадрат", "Прямоугольник", "Ромб", "Параллелограмм", "Произвольный четырехугольник", "Многоугольник" };


        private static List<Figure> Figures = new List<Figure>();

        private static double[] AverageArea = new double[NumberFigures];
        private static double[] AveragePerimeter = new double[NumberFigures];

        private static double MaxArea;
        private static double MaxPerimeter;

        public static String TypeFigure(params Point[] points)
        {
            if (points.Length == 3)
                return "Triangle";
            else if (points.Length == 2)
                return "Сircle";
            else if (points.Length == 4)
            {
                if (Point.Parallelism(points[0], points[1], points[2], points[3]) && !Point.Parallelism(points[1], points[2], points[3], points[0]))
                    return "Trapezoid";
                if (!Point.Parallelism(points[0], points[1], points[2], points[3]) && Point.Parallelism(points[1], points[2], points[3], points[0]))
                    return "Trapezoid";

                if (Point.Parallelism(points[0], points[1], points[2], points[3]) && Point.Parallelism(points[1], points[2], points[3], points[0]) && Point.LengthStraight(points[0], points[2]) == Point.LengthStraight(points[1], points[3]) && Point.LengthStraight(points[0], points[1]) == Point.LengthStraight(points[1], points[2]))
                    return "Square";

                if (Point.Parallelism(points[0], points[1], points[2], points[3]) && Point.Parallelism(points[1], points[2], points[3], points[0]) && Point.LengthStraight(points[0], points[2]) == Point.LengthStraight(points[1], points[3]))
                    return "Rectangle";

                if (Point.Parallelism(points[0], points[1], points[2], points[3]) && Point.Parallelism(points[1], points[2], points[3], points[0]) && Point.LengthStraight(points[0], points[1]) == Point.LengthStraight(points[1], points[2]))
                    return "Rhombus";

                if (Point.Parallelism(points[0], points[1], points[2], points[3]) && Point.Parallelism(points[1], points[2], points[3], points[0]))
                    return "Parallelogram";

                return "Arbitrary Quadrangle";
            }
            else if (points.Length > 4)
                return "Polygon";
            return "";
        }

        public static void CreateFigures()
        {
            String TypeFigure;
            String[] SetPoint = FileReader.ReadingByFile();
            
            foreach (String line in SetPoint)
            {
                double[] points1;
                points1 = line.Trim().Split(' ').Select(double.Parse).ToArray();
                Point[] points = new Point[points1.Length / 2];
                for (int j = 0; j < points1.Length; j++)
                {
                    points[j / 2] = new Point();
                    (points[j / 2]).x = points1[j];
                    j++;
                    points[j / 2].y = points1[j];

                }
                TypeFigure = ManagingFigures.TypeFigure(points);

                switch (TypeFigure)
                {
                    case "Сircle":
                        Figures.Add(new Сircle(points[0], points[1]));
                        break;
                    case "Triangle":
                        Figures.Add(new Triangle(points[0], points[1], points[2]));
                        break;
                    case "Trapezoid":
                        Figures.Add(new Trapezoid(points[0], points[1], points[2], points[3]));
                        break;
                    case "Square":
                        Figures.Add(new Square(points[0], points[1], points[2], points[3]));
                        break;
                    case "Rectangle":
                        Figures.Add(new Rectangle(points[0], points[1], points[2], points[3]));
                        break;
                    case "Rhombus":
                        Figures.Add(new Rhombus(points[0], points[1], points[2], points[3]));
                        break;
                    case "Parallelogram":
                        Figures.Add(new Parallelogram(points[0], points[1], points[2], points[3]));
                        break;
                    case "Arbitrary Quadrangle":
                        Figures.Add(new ArbitraryQuadrangle(points[0], points[1], points[2], points[3]));
                        break;
                    case "Polygon":
                        Figures.Add(new Polygon(points1.Length / 2, points));
                        break;
                }
            } 
        }

        public static void CalculationArea()
        {
            int[] number = new int[NumberFigures]; 
            foreach (Figure item in Figures)
            {
                switch (item.FigureType())
                {
                    case "Сircle":
                        AverageArea[0] += item.Area();
                        number[0]++;
                        break;
                    case "Triangle":
                        AverageArea[1] += item.Area();
                        number[1]++;
                        break;
                    case "Trapezoid":
                        AverageArea[2] += item.Area();
                        number[2]++;
                        break;
                    case "Square":
                        AverageArea[3] += item.Area();
                        number[3]++;
                        break;
                    case "Rectangle":
                        AverageArea[4] += item.Area();
                        number[4]++;
                        break;
                    case "Rhombus":
                        AverageArea[5] += item.Area();
                        number[5]++;
                        break;
                    case "Parallelogram":
                        AverageArea[6] += item.Area();
                        number[6]++;
                        break;
                    case "Arbitrary Quadrangle":
                        AverageArea[7] += item.Area();
                        number[7]++;
                        break;
                    case "Polygon":
                        AverageArea[8] += item.Area();
                        number[8]++;
                        break;
                }
            }
            for (int i = 0; i < NumberFigures; i++)
            {
                if (number[i] != 0)
                    AverageArea[i] /= number[i];
            }
            Console.WriteLine("\tСредняя площадь:");
            for (int i = 0; i < NumberFigures; i++)
            {
                Console.WriteLine($"{NameFigures[i]}: {AverageArea[i]}");
            }
        }

        public static void CalculationPerimeter()
        {
            int[] number = new int[NumberFigures];
            foreach (Figure item in Figures)
            {
                switch (item.FigureType())
                {
                    case "Сircle":
                        AveragePerimeter[0] += item.Perimeter();
                        number[0]++;
                        break;
                    case "Triangle":
                        AveragePerimeter[1] += item.Perimeter();
                        number[1]++;
                        break;
                    case "Trapezoid":
                        AveragePerimeter[2] += item.Perimeter();
                        number[2]++;
                        break;
                    case "Square":
                        AveragePerimeter[3] += item.Perimeter();
                        number[3]++;
                        break;
                    case "Rectangle":
                        AveragePerimeter[4] += item.Perimeter();
                        number[4]++;
                        break;
                    case "Rhombus":
                        AveragePerimeter[5] += item.Perimeter();
                        number[5]++;
                        break;
                    case "Parallelogram":
                        AveragePerimeter[6] += item.Perimeter();
                        number[6]++;
                        break;
                    case "Arbitrary Quadrangle":
                        AveragePerimeter[7] += item.Perimeter();
                        number[7]++;
                        break;
                    case "Polygon":
                        AveragePerimeter[8] += item.Perimeter();
                        number[8]++;
                        break;
                }
            }
            for (int i = 0; i < NumberFigures; i++)
            {
                if (number[i] != 0)
                    AveragePerimeter[i] /= number[i];
            }
            Console.WriteLine("\tСредний периметр:");
            for (int i = 0; i < NumberFigures; i++)
            {
                Console.WriteLine($"{NameFigures[i]}: {AveragePerimeter[i]}");
            }
        }

        public static void SearchMaxArea()
        {
            foreach(Figure Elem in Figures)
                if (MaxArea < Elem.Area())
                    MaxArea = Elem.Area();

            foreach (Figure Elem in Figures)
            {
                if (MaxArea == Elem.Area())
                {
                    Console.Write($"Максмальную площадь({MaxArea}) имеет {Elem.FigureType()} с координатами: ");
                    Elem.DisplayFigure();
                }
            }
        }

        public static void SearchMaxPerimeter()
        {
            for (int i = 0;  i < NumberFigures; i++)
                if (MaxPerimeter < AveragePerimeter[i])
                    MaxPerimeter = AveragePerimeter[i];

            for (int i = 0; i < NumberFigures; i++)
            {
                if (MaxPerimeter == AveragePerimeter[i])
                    Console.WriteLine($"Максимальный средний периметр имеет {NameFigures[i]}");
            }
        }
    }
}
