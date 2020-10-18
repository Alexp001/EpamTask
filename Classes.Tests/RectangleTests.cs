using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(0, 0);
            Point b = new Point(0, 1);
            Point c = new Point(2, 1);
            Point d = new Point(2, 0);

            Rectangle Elem = new Rectangle(a, b, c, d);
            double expected = 2;

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
            Point b = new Point(0, 1);
            Point c = new Point(2, 1);
            Point d = new Point(2, 0);
            Rectangle Elem = new Rectangle(a, b, c, d);
            double expected = 6;

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
