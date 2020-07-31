using System;

namespace InterviewConsoleProject3.Shapes
{
    public class Circle
    {
        private readonly double _diameter;

        public Circle(double diameter)
        {
            _diameter = diameter;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_diameter / 2, 2);
        }
    }
}