using System;
using System.Collections;
using System.Collections.Generic;

class Path : IEnumerable<Point3D>
{
    private List<Point3D> points;

    public Path()
    {
        this.points = new List<Point3D>();
    }
 
    public void PrintPoints()
    {
        foreach (var point in this.points)
        {
            Console.WriteLine(point.ToString());
        }
    }

    public void AddPoint(Point3D point)
    {
        this.points.Add(new Point3D(point.X, point.Y, point.Z));
    }

    public IEnumerator<Point3D> GetEnumerator()
    {
        return this.points.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
 
    public void DeletePoint(Point3D point)
    {
        if (this.points != null)
        {
            this.points.Remove(point);
        }
    }

    public void ClearPoints()
    {
        if (this.points != null)
        {
            this.points.Clear();
        }
    }
}
