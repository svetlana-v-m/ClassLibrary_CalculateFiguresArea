using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_CalculateFiguresArea;
using System;

namespace UnitTests
{
    [TestClass]
    public class AreaCalculationTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(new FiguresData() { a = 1 });
            Assert.AreEqual(Math.PI, circle.Area());
        }

        [TestMethod]
        public void TrinagleAreaTest()
        {
            Triangle triangle = new Triangle(new FiguresData() { a = 1, b = 0, c = 1 });
            Assert.AreEqual(0, triangle.Area());
        }
    }
}
