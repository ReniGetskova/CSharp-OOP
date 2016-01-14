using System;

static class Distance
{
    public static void DistancePoints(Point3D firstPoint, Point3D secondPoint)
    {
        double distance = Math.Sqrt((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                                     (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                                     (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
        Console.WriteLine("Distance between point A:{0} and point B:{1} is: {2:0.00}", firstPoint.ToString(), secondPoint.ToString(), distance);
    }
}
