using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbersArr = Console.ReadLine().
            Split().
            Select(int.Parse).
            Distinct().
            ToArray();

        List<int> subset = new List<int> { };
        double combinations = Math.Pow(2, numbersArr.Length);

        bool thereAreSubsets = false;

        for (int i = 1; i < combinations; i++)
        {
            for (int j = 0; j < numbersArr.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    subset.Add(numbersArr[0 + j]);
                }
            }

            if (subset.Sum() == numberN)
            {
                Console.WriteLine("{0} = {1}", 
                    string.Join(" + ", subset),
                    numberN);
                thereAreSubsets = true;
            }
            subset.Clear();
        }
        if (!thereAreSubsets)
        {
            Console.WriteLine("No matching subsets");
        }
    }
}

