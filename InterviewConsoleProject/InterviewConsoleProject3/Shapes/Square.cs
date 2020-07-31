using System;

namespace InterviewConsoleProject3.Shapes
{
    public class Square
    {
        private readonly double _size;

        public Square(double size)
        {
            _size = size;
        }

        public double CalculateArea() => Math.Pow(_size, 2);
    }
}