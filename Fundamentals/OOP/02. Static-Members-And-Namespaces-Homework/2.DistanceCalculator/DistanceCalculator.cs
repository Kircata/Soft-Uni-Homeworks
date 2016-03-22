namespace _2.DistanceCalculator
{
    using System;
    using _1.Point3D;
    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D pointA, Point3D pointB)
        {
            double distance = 
                  Math.Pow(pointB.PointX - pointA.PointX, 2)
                + Math.Pow(pointB.PointY - pointA.PointY, 2)
                + Math.Pow(pointB.PointZ - pointA.PointZ, 2);
            return Math.Sqrt(distance);
        }
    }
}
