using System;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
    public static class ManagingFigures
    {
        private static List<Сircle> Сircles = new List<Сircle>();
        private static List<Triangle> Triangles = new List<Triangle>();
        private static List<Trapezoid> Trapezoides = new List<Trapezoid>();
        private static List<Square> Squares = new List<Square>();
        private static List<Rectangle> Rectangles = new List<Rectangle>();
        private static List<Rhombus> Rhombuses = new List<Rhombus>();
        private static List<Parallelogram> Parallelograms = new List<Parallelogram>();
        private static List<ArbitraryQuadrangle> ArbitraryQuadrangles = new List<ArbitraryQuadrangle>();
        private static List<Polygon> Polygons = new List<Polygon>();

        private static double AverageAreaCircles = 0;
        private static double AverageAreaTriangles = 0;
        private static double AverageAreaTrapezoides = 0;
        private static double AverageAreaSquares = 0;
        private static double AverageAreaRectangles = 0;
        private static double AverageAreaRhombuses = 0;
        private static double AverageAreaParallelograms = 0;
        private static double AverageAreaArbitraryQuadrangles = 0;
        private static double AverageAreaPolygons = 0;

        private static double AveragePerimeterCircles = 0;
        private static double AveragePerimeterTriangles = 0;
        private static double AveragePerimeterTrapezoides = 0;
        private static double AveragePerimeterSquares = 0;
        private static double AveragePerimeterRectangles = 0;
        private static double AveragePerimeterRhombuses = 0;
        private static double AveragePerimeterParallelograms = 0;
        private static double AveragePerimeterArbitraryQuadrangles = 0;
        private static double AveragePerimeterPolygons = 0;

        private static double MaxArea = 0;
        private static double MaxPerimeter = 0;

        public static String TypeFigure(params Point[] points)
        {
            if (points.Length == 3)
                return "Triangle";
            else if (points.Length == 2)
                return "Сircle";
            else if (points.Length == 4)
            {
                ////add
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
                        Сircles.Add(new Сircle(points[0], points[1]));
                        break;
                    case "Triangle":
                        Triangles.Add(new Triangle(points[0], points[1], points[2]));
                        break;
                    case "Trapezoid":
                        Trapezoides.Add(new Trapezoid(points[0], points[1], points[2], points[3]));
                        break;
                    case "Square":
                        Squares.Add(new Square(points[0], points[1], points[2], points[3]));
                        break;
                    case "Rectangle":
                        Rectangles.Add(new Rectangle(points[0], points[1], points[2], points[3]));
                        break;
                    case "Rhombus":
                        Rhombuses.Add(new Rhombus(points[0], points[1], points[2], points[3]));
                        break;
                    case "Parallelogram":
                        Parallelograms.Add(new Parallelogram(points[0], points[1], points[2], points[3]));
                        break;
                    case "Arbitrary Quadrangle":
                        ArbitraryQuadrangles.Add(new ArbitraryQuadrangle(points[0], points[1], points[2], points[3]));
                        break;
                    case "Polygon":
                        Polygons.Add(new Polygon(points1.Length / 2, points));
                        break;
                }
            } 
        }

        public static void CalculationArea()
        {
            int count = 0;
            foreach (Сircle item in Сircles)
            {
                AverageAreaCircles += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaCircles /= count;
            Console.WriteLine($"Средняя площадь окружностей: {AverageAreaCircles}");
            count = 0;

            foreach (Triangle item in Triangles)
            {
                AverageAreaTriangles += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaTriangles /= count;
            Console.WriteLine($"Средняя площадь треугольников: {AverageAreaTriangles}");
            count = 0;

            foreach (Trapezoid item in Trapezoides)
            {
                AverageAreaTrapezoides += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaTrapezoides /= count;
            Console.WriteLine($"Средняя площадь трапеций: {AverageAreaTrapezoides}");

            count = 0;

            foreach (Square item in Squares)
            {
                AverageAreaSquares += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaSquares /= count;
            Console.WriteLine($"Средняя площадь квадратов: {AverageAreaSquares}");

            count = 0;

            foreach (Rectangle item in Rectangles)
            {
                AverageAreaRectangles += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaRectangles /= count;
            Console.WriteLine($"Средняя площадь прямоугольников: {AverageAreaRectangles}");

            count = 0;

            foreach (Rhombus item in Rhombuses)
            {
                AverageAreaRhombuses += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaRhombuses /= count;
            Console.WriteLine($"Средняя площадь ромбов: {AverageAreaRhombuses}");

            count = 0;

            foreach (Parallelogram item in Parallelograms)
            {
                AverageAreaParallelograms += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaParallelograms /= count;
            Console.WriteLine($"Средняя площадь параллелограммов: {AverageAreaParallelograms}");

            count = 0;

            foreach (ArbitraryQuadrangle item in ArbitraryQuadrangles)
            {
                AverageAreaArbitraryQuadrangles += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaArbitraryQuadrangles /= count;
            Console.WriteLine($"Средняя площадь произвольных четырехугольников: {AverageAreaArbitraryQuadrangles}");

            count = 0;

            foreach (Polygon item in Polygons)
            {
                AverageAreaPolygons += item.Area();
                if (MaxArea < item.Area())
                    MaxArea = item.Area();
                count++;
            }
            if (count != 0)
                AverageAreaPolygons /= count;
            Console.WriteLine($"Средняя площадь многоугольников (>4): {AverageAreaPolygons}");

        }

        public static void CalculationPerimeter()
        {
            int count = 0;
            foreach (Сircle item in Сircles)
            {
                AveragePerimeterCircles += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterCircles /= count;
            if (MaxPerimeter < AveragePerimeterCircles)
                MaxPerimeter = AveragePerimeterCircles;
            Console.WriteLine($"Средний периметр окружностей: {AveragePerimeterCircles}");

            count = 0;

            foreach (Triangle item in Triangles)
            {
                AveragePerimeterTriangles += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterTriangles /= count;
            if (MaxPerimeter < AveragePerimeterTriangles)
                MaxPerimeter = AveragePerimeterTriangles;
            Console.WriteLine($"Средний периметр треугольников: {AveragePerimeterTriangles}");

            count = 0;

            foreach (Trapezoid item in Trapezoides)
            {
                AveragePerimeterTrapezoides += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterTrapezoides /= count;
            if (MaxPerimeter < AveragePerimeterTrapezoides)
                MaxPerimeter = AveragePerimeterTrapezoides;
            Console.WriteLine($"Средний периметр трапеций: {AveragePerimeterTrapezoides}");

            count = 0;

            foreach (Square item in Squares)
            {
                AveragePerimeterSquares += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterSquares /= count;
            if (MaxPerimeter < AveragePerimeterSquares)
                MaxPerimeter = AveragePerimeterSquares;

            Console.WriteLine($"Средний периметр квадратов: {AveragePerimeterSquares}");

            count = 0;

            foreach (Rectangle item in Rectangles)
            {
                AveragePerimeterRectangles += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterRectangles /= count;
            if (MaxPerimeter < AveragePerimeterRectangles)
                MaxPerimeter = AveragePerimeterRectangles;
            Console.WriteLine($"Средний периметр прямоугольников: {AveragePerimeterRectangles}");

            count = 0;

            foreach (Rhombus item in Rhombuses)
            {
                AveragePerimeterRhombuses += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterRhombuses /= count;
            if (MaxPerimeter < AveragePerimeterRhombuses)
                MaxPerimeter = AveragePerimeterRhombuses;
            Console.WriteLine($"Средний периметр ромбов: {AveragePerimeterRhombuses}");

            count = 0;

            foreach (Parallelogram item in Parallelograms)
            {
                AveragePerimeterParallelograms += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterParallelograms /= count;
            if (MaxPerimeter < AveragePerimeterParallelograms)
                MaxPerimeter = AveragePerimeterParallelograms;
            Console.WriteLine($"Средний периметр параллелограммов: {AveragePerimeterParallelograms}");

            count = 0;

            foreach (ArbitraryQuadrangle item in ArbitraryQuadrangles)
            {
                AveragePerimeterArbitraryQuadrangles += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterArbitraryQuadrangles /= count;
            if (MaxPerimeter < AveragePerimeterArbitraryQuadrangles)
                MaxPerimeter = AveragePerimeterArbitraryQuadrangles;
            Console.WriteLine($"Средний периметр произвольных четырехугольников: {AveragePerimeterArbitraryQuadrangles}");

            count = 0;

            foreach (Polygon item in Polygons)
            {
                AveragePerimeterPolygons += item.Perimeter();
                count++;
            }
            if (count != 0)
                AveragePerimeterPolygons /= count;
            if (MaxPerimeter < AveragePerimeterPolygons)
                MaxPerimeter = AveragePerimeterPolygons;
            Console.WriteLine($"Средний периметр многоугольников (>4): {AveragePerimeterPolygons}");

        }

        public static void SearchMaxArea()
        {
            foreach (Сircle item in Сircles)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет окружность с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }

            foreach (Triangle item in Triangles)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет треугольник с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }
            foreach (Trapezoid item in Trapezoides)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет трапеция с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }

            foreach (Square item in Squares)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет квадрат с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }

            foreach (Rectangle item in Rectangles)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет прямоугольник с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }

            foreach (Rhombus item in Rhombuses)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет ромб с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }
            foreach (Parallelogram item in Parallelograms)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет параллелограмм с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }

            foreach (ArbitraryQuadrangle item in ArbitraryQuadrangles)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет произвольный четырехугольник с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }
            foreach (Polygon item in Polygons)
            {
                if (MaxArea == item.Area())
                {
                    Console.Write($"Максимальную площадь ({MaxArea}) имеет многоугольник с координатами: ");
                    item.DisplayFigure();
                    Console.WriteLine("");
                }
            }
        }

        public static void SearchMaxPerimeter()
        {
            if (MaxPerimeter == AveragePerimeterCircles)
                Console.WriteLine("Максимальный средний периметр имеет окружность");

            if (MaxPerimeter == AveragePerimeterTriangles)
                Console.WriteLine("Максимальный средний периметр имеет треугольник");

            if (MaxPerimeter == AveragePerimeterTrapezoides)
                Console.WriteLine("Максимальный средний периметр имеет трапеция");

            if (MaxPerimeter == AveragePerimeterSquares)
                Console.WriteLine("Максимальный средний периметр имеет квадрат");

            if (MaxPerimeter == AveragePerimeterRectangles)
                Console.WriteLine("Максимальный средний периметр имеет прямоугольник");

            if (MaxPerimeter == AveragePerimeterRhombuses)
                Console.WriteLine("Максимальный средний периметр имеет ромб");

            if (MaxPerimeter == AveragePerimeterParallelograms)
                Console.WriteLine("Максимальная средний периметр имеет параллелограмм");

            if (MaxPerimeter == AveragePerimeterArbitraryQuadrangles)
                Console.WriteLine("Максимальная средний периметр имеет произвольный четырехугольник");

            if (MaxPerimeter == AveragePerimeterPolygons)
                Console.WriteLine("Максимальная средний периметр имеет многоугольник");

        }
    }
}
