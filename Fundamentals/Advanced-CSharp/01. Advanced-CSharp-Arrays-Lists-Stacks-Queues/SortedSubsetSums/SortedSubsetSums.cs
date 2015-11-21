using System;
using System.Collections.Generic;
using System.Linq;


class SortedSubsetSums
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[] numbersArr = Console.ReadLine().
            Split().
            Select(int.Parse).
            Distinct().
            ToArray();

        var subset = new List<string> { };
        var correctSubset = new List<string> { };
        double combinations = Math.Pow(2, numbersArr.Length);

        bool thereAreSubsets = false;
        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            for (int j = 0; j < numbersArr.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    subset.Add(Convert.ToString(numbersArr[0 + j]));
                    sum += numbersArr[0 + j];
                }
            }

            if (sum == numberN)
            {
                string combinedElements = string.Join(" + ", subset);
                correctSubset.Add(combinedElements);
                thereAreSubsets = true;
            }
            subset.Clear();
        }


        if (!thereAreSubsets)
        {
            Console.WriteLine("No matching subsets");
        }
        else
        {
            var sortedList = correctSubset.OrderBy(str => str.Length).
                ThenBy(str => str).ToList();
            sortedList.ForEach(item => Console.WriteLine(item));
        }
    }


}

