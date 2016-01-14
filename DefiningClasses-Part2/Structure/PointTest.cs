using System;
using System.Collections.Generic;

class PointTest
{
    public static void Main()
    {
        Point3D pointA = new Point3D(1, 2, 3);
        Point3D pointB = new Point3D(4, 5, 6);
        Distance.DistancePoints(pointA, pointB);
        Console.WriteLine("Start of coordinate sistem:");
        Point3D.PrintStartCoordinateSystem();
        List<Point3D> pointList = new List<Point3D>{ new Point3D(11, 12, 13),
                                                     new Point3D(14, 15, 16),
                                                     new Point3D(17, 18, 19)
                                                    };

        string pathForSaveFile = @"..\..\WriteToFile.txt";
        PathStorage.SavePath(pointList, pathForSaveFile);
        Console.WriteLine("Points that are write to file:");
        foreach (var point in pointList)
        {
            Console.WriteLine(point.ToString());
        }

        string pathToLoadPoints = @"..\..\PathFromPointsFile.txt";
        Path pathFromFile = PathStorage.LoadPath(pathToLoadPoints);
        Console.WriteLine("Points that are load from file:");
        foreach (var p in pathFromFile)
        {
            Console.WriteLine(p);
        }
    }
}
