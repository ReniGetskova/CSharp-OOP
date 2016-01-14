namespace Shapes
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double height, double width) : base(height, width)
        {

        }

        public override void CalculateSurface()
        {
            double result = 0;
            result = (this.height * this.width) / 2;
            Console.WriteLine("Triangle surface: {0}", result);
        }
    }
}
