namespace _3.Paths
{
    using _1.Point3D;
    using Models;
    using System;

    class TestProgram
    {
        private const string File = @"../../path.xml";
        static void Main()
        {
            var path = new Path3D(
                new Point3D(1, 2, 3),
                new Point3D(4, 5, 6),
                new Point3D(7, 8, 9),
                new Point3D(0.3, 0.77, 12.44));

            Storage.SavePath(File, path);
            Path3D secondPath = Storage.LoadPath(File);
            Console.WriteLine(string.Join(Environment.NewLine,secondPath.Path));
        }
    }
}
