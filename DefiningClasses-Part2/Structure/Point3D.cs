using System;
using System.Linq;

struct Point3D
{
    private static readonly Point3D O = new Point3D(0, 0, 0);

    public Point3D(double x, double y, double z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    public static void PrintStartCoordinateSystem()
    {
        Console.WriteLine(Point3D.O.ToString());
    }

    public static Point3D Parse(string path)
    {
        int openBracket = path.IndexOf('(');
        double[] coordinates = path
                                 .Substring(openBracket + 1, path.Length - openBracket - 2)
                                 .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(x => double.Parse(x)).ToArray();
        return new Point3D(coordinates[0], coordinates[1], coordinates[2]);
    }

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
    }
}
