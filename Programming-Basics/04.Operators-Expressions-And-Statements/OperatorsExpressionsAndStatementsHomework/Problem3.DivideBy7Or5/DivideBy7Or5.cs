using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.DivideBy7Or5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool result = (n % 5 == 0) && (n % 7 == 0) ? true: false;
            Console.WriteLine("The number you have entered is divided by both 7 and 5 (without remainder): {0}", result);
        }
    }
}
