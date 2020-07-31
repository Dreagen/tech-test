using System;
using InterviewConsoleProject3.Shapes;

namespace InterviewConsoleProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Square square = new Square(10);
            Rectangle rectangle = new Rectangle(5, 10);

            ShapeAreaCalculationService shapeAreaCalculationService = new ShapeAreaCalculationService();
            
            shapeAreaCalculationService.AddCircle(circle);
            shapeAreaCalculationService.AddSquare(square);
            shapeAreaCalculationService.AddRectangle(rectangle);

            double totalArea = shapeAreaCalculationService.CalculateTotalArea();
            
            Console.WriteLine($"Total Area: {totalArea}");

            Console.ReadLine();
        }
    }
}