using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine().Trim();
            long dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '1')
                {
                    dec += (long)Math.Pow(2, i);
                }
            }
            Console.WriteLine(dec);
        }
    }

