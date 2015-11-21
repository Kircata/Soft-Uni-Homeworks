using System;
using System.Collections.Generic;
using System.Linq;
class LongestIncreasingSequence
{
    static void Main()
    {
        int[] arrOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> sequence = new List<int> { };
        List<int> longestSequence = new List<int> { };
        int index = 1;
        for (int i = 0; i < arrOfIntegers.Length;)
        {
            sequence.Add(arrOfIntegers[i]);
            if (index != arrOfIntegers.Length)
            {
                while (arrOfIntegers[i] < arrOfIntegers[index] &&
                    sequence[sequence.Count - 1] < arrOfIntegers[index])
                {
                    sequence.Add(arrOfIntegers[index]);
                    index++;
                    if (index == arrOfIntegers.Length)
                    {
                        break;
                    }
                }
            }
            foreach (var number in sequence)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            i += sequence.Count;
            index = i + 1;
            if (sequence.Count > longestSequence.Count)
            {
                longestSequence.Clear();
                longestSequence.InsertRange(0, sequence);
            }
            sequence.Clear();
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
    }
}

