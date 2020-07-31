using System;
using InterviewConsoleProject3.Shapes;
using NUnit.Framework;

namespace InterviewConsoleProject3Tests.Shapes
{
    public class CircleTests
    {
        [Test]
        public void GivenCircleWithKnownDiameter_CalculateAreaReturnsCorrectly()
        {
            Circle circle = new Circle(10);

            double area = circle.CalculateArea();

            Assert.AreEqual(78.54, Math.Round(area, 2));
        }
    }
}