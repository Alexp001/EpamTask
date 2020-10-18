using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(3, 3);
            Point b = new Point(3, 5);
            Сircle сircle = new Сircle(a, b);
            double expected = Math.PI * 4;

            // act
            double actual = сircle.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point a = new Point(0, 3);
            Point b = new Point(3, 5);
            Сircle сircle = new Сircle(a, b);
            double expected = 2 * Math.Sqrt(13) * Math.PI;

            // act
            double actual = сircle.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
