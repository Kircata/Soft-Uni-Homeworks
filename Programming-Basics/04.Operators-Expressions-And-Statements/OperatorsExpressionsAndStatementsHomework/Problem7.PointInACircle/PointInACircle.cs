using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool isInside = (x*x + y*y) <= 2*2 ? true : false;
            Console.WriteLine("These coordinates are inside the circle: {0}", isInside);
        }
    }
}
