using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CalculateNK
    {
        static void Main()
        {
           
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
           
            int factorialN = 1;
            int factorialK = 1;
            for (int i = n, j = k; i > 0; i--, j--)
            {
                factorialN *= i;
                if (j <= 0)
                {
                    continue;
                }
                factorialK *= j;
            }

            Console.WriteLine("n! / k!: {0}", factorialN / factorialK);

        }
    }

