using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class RhombusTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(0, -5);
            Point b = new Point(-3, 0);
            Point c = new Point(0, 5);
            Point d = new Point(3, 0);

            Rhombus Elem = new Rhombus(a, b, c, d);
            double expected = 30;

            // act
            double actual = Elem.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point a = new Point(0, -5);
            Point b = new Point(-3, 0);
            Point c = new Point(0, 5);
            Point d = new Point(3, 0);

            Rhombus Elem = new Rhombus(a, b, c, d);
            double expected = 4 * Math.Sqrt(34);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
