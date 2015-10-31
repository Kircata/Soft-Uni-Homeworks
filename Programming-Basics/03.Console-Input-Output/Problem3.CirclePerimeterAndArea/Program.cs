using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            string strRadius = Console.ReadLine();
            float radius = float.Parse(strRadius);
            Console.WriteLine("The perimeter is: {0}", radius *  3.14 * 2);
            Console.WriteLine("The area is: {0}", radius * radius * 3.14);
        }
    }
}
