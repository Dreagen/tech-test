using System;
using InterviewConsoleProject3.Shapes;
using NUnit.Framework;

namespace InterviewConsoleProject3Tests.Shapes
{
    public class SquareTests
    {
        [Test]
        public void GivenSquareWithKnownSize_CalculateAreaReturnsCorrectly()
        {
            Square square = new Square(10);

            double area = square.CalculateArea();

            Assert.AreEqual(100, area);
        }
    }
}