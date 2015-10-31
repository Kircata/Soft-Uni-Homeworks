using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number n: ");
            int n = int.Parse(Console.ReadLine());
            bool result = n%2 == 1 ? true: false;
            Console.WriteLine("Is the number you have entered odd ?: {0}", result);
        }
    }
}
