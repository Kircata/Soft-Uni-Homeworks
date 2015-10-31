using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            if ((a == 0)||(b == 0)||(c == 0))
            {
                Console.WriteLine("0");
            }
            else if ((a > 0) ^ ((b > 0) ^ (c > 0)))
            {
                Console.WriteLine("+");
            }
            else if ((a < 0) ^ ((b < 0) ^ (c < 0)))
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
