using System;
namespace _1.Point3D
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Point3D newPoint = new Point3D(34, 23, 1);
            Console.WriteLine("{0}  {1}  {2}", newPoint.PointX, newPoint.PointY, newPoint.PointZ);
            Console.WriteLine(Point3D.StartingPoint);
            Console.WriteLine(newPoint);
        }
    }
}
