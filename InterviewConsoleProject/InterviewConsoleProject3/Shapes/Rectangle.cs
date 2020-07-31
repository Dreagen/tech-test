namespace InterviewConsoleProject3.Shapes
{
    public class Rectangle
    {
        private readonly double _height;
        private readonly double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double CalculateArea() => _height * _width;
    }
}