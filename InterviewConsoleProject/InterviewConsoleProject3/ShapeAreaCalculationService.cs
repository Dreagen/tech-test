using System.Collections.Generic;
using System.Linq;
using InterviewConsoleProject3.Shapes;

namespace InterviewConsoleProject3
{
    public class ShapeAreaCalculationService
    {
        private readonly List<Circle> _circles = new List<Circle>();
        private readonly List<Square> _squares = new List<Square>();
        private readonly List<Rectangle> _rectangles = new List<Rectangle>();

        public void AddCircle(Circle circle)
        {
            _circles.Add(circle);
        }
        
        public void AddSquare(Square square)
        {
            _squares.Add(square);
        }
        
        public void AddRectangle(Rectangle rectangle)
        {
            _rectangles.Add(rectangle);
        }
        
        public double CalculateTotalArea()
        {
            double area = 0;

            foreach (Circle circle in _circles)
            {
                area += circle.CalculateArea();
            }

            foreach (Square square in _squares)
            {
                area += square.CalculateArea();
            }

            foreach (Rectangle rectangle in _rectangles)
            {
                area += rectangle.CalculateArea();
            }

            return area;
        }
    }
}