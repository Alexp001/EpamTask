using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(0, 0);
            Point b = new Point(-1, 1);
            Point c = new Point(0, 2);
            Point d = new Point(1, 1);

            Square Elem = new Square(a, b, c, d);
            double expected = Math.Sqrt(2) * Math.Sqrt(2);

            // act
            double actual = Elem.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point a = new Point(0, 0);
            Point b = new Point(-1, 1);
            Point c = new Point(0, 2);
            Point d = new Point(1, 1);
            Square Elem = new Square(a, b, c, d);
            double expected = 4 * Math.Sqrt(2);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
