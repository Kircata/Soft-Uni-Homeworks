using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14.ModifyABit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter a value (0 or 1): ");
            int v = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

            if (v == 1)
            
            {
                int withBitOne = (1 << p) | n;
                Console.WriteLine(Convert.ToString(withBitOne, 2).PadLeft(16, '0'));
                Console.WriteLine(withBitOne);
            }
            else
            {
                int withBitZero = ~(1 << p) & n;
                Console.WriteLine(Convert.ToString(withBitZero, 2).PadLeft(16, '0'));
                Console.WriteLine(withBitZero);
            }
            // 00000000 00000101
            //                 &
            // 11111111 11111011
            // 00000000 00000001

            
            
        }
    }
}
