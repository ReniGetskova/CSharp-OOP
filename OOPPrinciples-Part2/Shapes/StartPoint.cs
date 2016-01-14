namespace Shapes
{
    using System;

    public class StartPoint
    {
        static void Main()
        {
            IShape[] shapes = {new Rectangle(3, 4),
                              new Triangle(5, 6),
                              new Square(7)};
            foreach (var item in shapes)
            {
                item.CalculateSurface();
            }

            Console.WriteLine();
        }
    }
}
