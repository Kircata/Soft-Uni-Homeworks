using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int integer = int.Parse(Console.ReadLine());
            int thirdDigit = (integer / 100) % 10;
            bool result = thirdDigit == 7 ? true : false;
            Console.WriteLine("Is the third digit from right-to-left of the given number equal to 7 ?: {0}", result);
        }
    }
}
