using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point[] points1 = new Point[5];
            points1[0] = new Point(-1, -1);
            points1[1] = new Point(-1, 1);
            points1[2] = new Point(0, 0);
            points1[3] = new Point(1, 1);
            points1[4] = new Point(1, -1);

            Polygon Elem = new Polygon(5, points1);
            double expected = 3;

            // act
            double actual = Elem.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point[] points1 = new Point[5];
            points1[0] = new Point(-1, -1);
            points1[1] = new Point(-1, 1);
            points1[2] = new Point(0, 0);
            points1[3] = new Point(1, 1);
            points1[4] = new Point(1, -1);

            Polygon Elem = new Polygon(5, points1);
            double expected = 6 + 2 * Math.Sqrt(2);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
