using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = width * 2 + height * 2;
            double area = width * height;
            Console.WriteLine("The perimeter of the rectangle is: {0}\nThe area of the rectangle is: {1}",perimeter, area);
        }
    }
}
