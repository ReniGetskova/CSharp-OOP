namespace Shapes
{
    public abstract class Shape : IShape
    {
        protected double height;
        protected double width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public Shape(double side)
        {
            this.height = side;
            this.width = side;
        }

        public abstract void CalculateSurface();
    }
}
