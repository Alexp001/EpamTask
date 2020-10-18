using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class ManagingFigureTests
    {
        [TestMethod]
        public void TypeFigureTest1()
        {
            // arrange
            Point[] points = new Point[2];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            String expected = "Сircle";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TypeFigureTest2()
        {
            // arrange
            Point[] points = new Point[3];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(2, 2);
            String expected = "Triangle";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TypeFigureTest3()
        {
            // arrange
            Point[] points = new Point[4];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(2, 2);
            points[3] = new Point(2, 1);
            String expected = "Rectangle";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TypeFigureTest4()
        {
            // arrange
            Point[] points = new Point[4];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(1, 2);
            points[3] = new Point(1, 1);
            String expected = "Square";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeFigureTest5()
        {
            // arrange
            Point[] points = new Point[4];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(1, 3);
            points[3] = new Point(1, 2);
            String expected = "Parallelogram";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TypeFigureTest6()
        {
            // arrange
            Point[] points = new Point[4];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(1, 3);
            points[3] = new Point(1, 1);
            String expected = "Trapezoid";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void TypeFigureTest7()
        {
            // arrange
            Point[] points = new Point[5];
            points[0] = new Point(0, 1);
            points[1] = new Point(0, 2);
            points[2] = new Point(1, 3);
            points[3] = new Point(1, 2);
            points[0] = new Point(0.5, -1);
            String expected = "Polygon";

            // act
            String actual = ManagingFigures.TypeFigure(points);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
