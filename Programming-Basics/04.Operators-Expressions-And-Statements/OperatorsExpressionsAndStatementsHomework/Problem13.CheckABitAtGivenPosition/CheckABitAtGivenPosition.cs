using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13.CheckABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            int p = int.Parse(Console.ReadLine());
            int extractBit = (n >> p) & 1;
            bool checkBit = extractBit == 1 ? true : false;
            Console.WriteLine("The bit at position {0} of integer {1} is equal to 1: {2}", p, n, checkBit);
        }
    }
}
