namespace _2.DistanceCalculator
{
    using _1.Point3D;
    using System;
    class TestProgram
    {
        static void Main(string[] args)
        {
            Point3D pointA = new Point3D(4, 4, 5);
            Point3D pointB = new Point3D(6, 7, 8);
            double testDistance = DistanceCalculator.CalculateDistance(pointA,pointB);
            Console.WriteLine("{0:F13}",testDistance);
        }
    }
}
