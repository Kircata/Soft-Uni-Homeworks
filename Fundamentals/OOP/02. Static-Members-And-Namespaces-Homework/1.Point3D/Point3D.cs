namespace _1.Point3D
{
    public class Point3D
    {
        //Field
        private static readonly Point3D StartingPointCoordinates;

        //Constructors
        static Point3D()
        {
            StartingPointCoordinates = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }

        private Point3D()
        {
        }

        //Properties
        public static Point3D StartingPoint
        {
            get { return Point3D.StartingPoint; }
        }
        public double PointX { get; set; }
        public double PointY { get; set; }
        public double PointZ { get; set; }

        //ToString()
        public override string ToString()
        {
            return string.Format("The point in space is: ({0},{1},{2})", this.PointX, this.PointY, this.PointZ);
        }
    }
}
