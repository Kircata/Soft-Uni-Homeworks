using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HexToDecimal
    {
        static void Main()
        {
            string hex = Console.ReadLine().ToUpper();
            long dec = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case 'A': dec += 10 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'B': dec += 11 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'C': dec += 12 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'D': dec += 13 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'E': dec += 14 * (long)Math.Pow(16, hex.Length - i - 1); break;
                    case 'F': dec += 15 * (long)Math.Pow(16, hex.Length - i - 1); break;

                    default: dec += (long)char.GetNumericValue(hex[i]) * (long)Math.Pow(16, hex.Length - i - 1);
                        break;
                }
            }
            Console.WriteLine(dec);
        }
    }

