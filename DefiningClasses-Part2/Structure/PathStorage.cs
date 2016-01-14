using System.Collections.Generic;
using System.IO;

static class PathStorage
{
    public static Path LoadPath(string pathFile)
    {
        Path path = new Path();
        StreamReader reader = new StreamReader(pathFile);
        using(reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Point3D point = Point3D.Parse(line);
                path.AddPoint(point);
            }
        }
        return path;
    }

    public static void SavePath(List<Point3D> points, string pathFile)
    {
        string record = string.Empty;
        using (StreamWriter writer = new StreamWriter(pathFile))
        {
            foreach (var point in points)
            {
                record = point.ToString();
                writer.WriteLine(record);
            }
        }
    }
}
