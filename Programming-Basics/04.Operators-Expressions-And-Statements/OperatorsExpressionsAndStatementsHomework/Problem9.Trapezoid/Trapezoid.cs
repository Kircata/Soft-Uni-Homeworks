using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is: {0}", ((a+b)*height)/ 2);
        }
    }
}
