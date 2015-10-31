using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements you want: ");
        int numOfElements = int.Parse(Console.ReadLine());
        string[] allElements = new string[numOfElements];
        Console.WriteLine("Enter the n amount of elements: ");
        for (int i = 0; i < allElements.Length; i++)
        {
            allElements[i] = Console.ReadLine();
        }

        int leftmostSequenceCount = 0;
        string longestArea = null;

        for (int i = 0; i < allElements.Length; i++)
        {
            int sequenceCount = 0;

            for (int j = i; j < allElements.Length; j++)
            {
                if (allElements[i] == allElements[j])
                {
                    sequenceCount++;
                }
                else
                {
                    break;
                }
            }
            if (leftmostSequenceCount < sequenceCount)
            {
                leftmostSequenceCount = sequenceCount;
                longestArea = allElements[i];
            }
        }
        Console.WriteLine("Sequence count: {0}",leftmostSequenceCount);
        Console.WriteLine("Elements: ");
        for (int i = 0; i < leftmostSequenceCount; i++)
        {
            Console.WriteLine(longestArea);
        }
    }
}

