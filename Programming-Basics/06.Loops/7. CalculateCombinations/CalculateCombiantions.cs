using System;
using System.Numerics;


class CalculateCombiantions
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
      
        BigInteger factorialNK = 1;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = n; i > 0; i--)
        {
            if (i <= k)
            {
                factorialK *= i;
            }
            if (i <= n - k)
            {
                factorialNK *= i;
            }
            factorialN *= i;
        }
        BigInteger combination = factorialN / (factorialK * factorialNK);
        Console.WriteLine(combination);
    }
}

