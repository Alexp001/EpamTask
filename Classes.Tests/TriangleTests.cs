using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(0, 0);
            Point b = new Point(1, 1);
            Point c = new Point(2, 1);
            Triangle Elem = new Triangle(a, b, c);
            double expected = 0.5;

            // act
            double actual = Elem.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point a = new Point(1, -1);
            Point b = new Point(3, 0);
            Point c = new Point(2, 1);
            Triangle Elem = new Triangle(a, b, c);
            double expected = 2 * Math.Sqrt(5) + Math.Sqrt(2);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
