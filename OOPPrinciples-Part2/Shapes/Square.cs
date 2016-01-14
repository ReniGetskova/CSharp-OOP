namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double side) : base(side)
        {

        }

        public override void CalculateSurface()
        {
            double result = 0;
            result = this.height * this.width;
            Console.Write("Square surface: {0}", result);
        }
    }
}
