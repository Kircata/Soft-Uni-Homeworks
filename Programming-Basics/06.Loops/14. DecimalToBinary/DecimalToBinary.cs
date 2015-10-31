using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DecimalToBinary
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            string binary = "";
            do
            {
                binary = dec % 2 + binary;
                dec = dec / 2;
            } while (dec > 0);

            Console.WriteLine(binary);
        }
    }

