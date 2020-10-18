using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class TrapezoidTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(-2, 0);
            Point b = new Point(-1, 1);
            Point c = new Point(1, 1);
            Point d = new Point(2, 0);

            Trapezoid Elem = new Trapezoid(a, b, c, d);
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
            Point a = new Point(-2, 0);
            Point b = new Point(-1, 1);
            Point c = new Point(1, 1);
            Point d = new Point(2, 0);
            Trapezoid Elem = new Trapezoid(a, b, c, d);
            double expected = 6 + 2 * Math.Sqrt(2);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
