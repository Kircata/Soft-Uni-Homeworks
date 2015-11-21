using System;
using System.Linq;
class SortArrayUsingSelectionSort
{
    static void Main()
    {
        int[] arrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool hasSortedOnce = false;
        bool breakWhileLoop = false;
        while (breakWhileLoop!=true)
        {
            for (int index = 0; index < arrOfNumbers.Length - 1; index++)
            {
                int oldValue = arrOfNumbers[index];
                if (arrOfNumbers[index] > arrOfNumbers[index + 1])
                {
                    arrOfNumbers[index] = arrOfNumbers[index + 1];
                    arrOfNumbers[index + 1] = oldValue;
                    hasSortedOnce = true;
                }
            }
            if (hasSortedOnce)
            {
                hasSortedOnce = false;
            }
            else
            {
                breakWhileLoop = true;
            }
        }
        Console.WriteLine("{0}", string.Join(" ", arrOfNumbers));
    }
}

