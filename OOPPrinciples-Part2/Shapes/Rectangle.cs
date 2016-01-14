namespace Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) : base(height, width)
        {

        }

        public override void CalculateSurface()
        {
            double result = 0;
            result = this.height * this.width;
            Console.WriteLine("Rectangle surface: {0}", result);
        }
    }
}
