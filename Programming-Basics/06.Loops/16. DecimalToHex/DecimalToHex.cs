using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DecimalToHex
    {
      
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());
            string hex = "";

            do
            {
                switch (dec % 16)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = dec % 16 + hex; break;
                }
                dec = dec / 16;
            } while (dec > 0);

            Console.WriteLine(hex);
        }
    }

