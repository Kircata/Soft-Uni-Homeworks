using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.ExtractBitPosition3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an unsigned integer: ");
            uint number = uint.Parse(Console.ReadLine());
            uint bitAtPosition3 = (number >> 3) & 1;
            Console.WriteLine("The bit at position 3 of this integer is: {0}", bitAtPosition3);
        }
    }
}
