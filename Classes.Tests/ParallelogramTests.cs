using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes.Tests
{
    [TestClass]
    public class ParallelogramTests
    {
        [TestMethod]
        public void AreaTests1()
        {
            // arrange
            Point a = new Point(-2, -2);
            Point b = new Point(-2, 0);
            Point c = new Point(3, 2);
            Point d = new Point(3, 0);

            Parallelogram Elem = new Parallelogram(a, b, c, d);
            double expected = 10;

            // act
            double actual = Elem.Area();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PerimetrTest1()
        {
            // arrange
            Point a = new Point(-2, -2);
            Point b = new Point(-2, 0);
            Point c = new Point(3, 2);
            Point d = new Point(3, 0);

            Parallelogram Elem = new Parallelogram(a, b, c, d);
            double expected = 4 + Math.Sqrt(29) + Math.Sqrt(29);

            // act
            double actual = Elem.Perimeter();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
