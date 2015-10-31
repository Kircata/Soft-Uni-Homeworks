using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class PointInACircleAndInARectangle
    {
        static void Main(string[] args)
        {
         decimal radius = 1.5M; 
         Console.Write("Enter x: "); 
         decimal x = decimal.Parse(Console.ReadLine()); 
         Console.Write("Enter y: "); 
         decimal y = decimal.Parse(Console.ReadLine()); 
         bool inTheCircle = ((x-1)*(x-1) + (y-1)*(y-1)) <= radius * radius; 
         bool notInRectangle = x < -1 || x > 5 || y < -1 || y > 1 ; 
         if (inTheCircle && notInRectangle) 
         { 
            Console.WriteLine("Point({0};{1}) is in the circle and outside of the Rectangle!", x, y); 
         } 
         else 
         { 
             Console.WriteLine("Point({0};{1}) is either outside of the circle or in the rectangle.", x, y); 
         } 

        }
    }
}
