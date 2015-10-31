using System;
using System.Numerics;


    class CatalanNumbers
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
       
            BigInteger factorial2N = 1;
            BigInteger factorialNPlus1 = 1;
            BigInteger factorialN = 1;
            for (int i = 1; i <=2 * n; i++)
            {
                if (i <= n)
                {
                    factorialN *= i;
                }
                if (i <= n + 1)
                {
                    factorialNPlus1 *= i;
                }
                factorial2N *= i;
            }
            BigInteger catalan = factorial2N / (factorialNPlus1 * factorialN);
            Console.WriteLine(catalan);
        }
    }

