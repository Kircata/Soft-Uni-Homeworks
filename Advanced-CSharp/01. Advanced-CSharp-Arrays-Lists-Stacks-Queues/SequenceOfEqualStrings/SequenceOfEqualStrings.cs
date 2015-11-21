using System;
using System.Linq;
class SequenceOfEqualStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ').ToArray();
        int index = 0;
        for (int i = 0; i < arr.Length; i = index)
        {
            do
            {
                Console.Write("{0} ", arr[index]);
                index++;
                if (index == arr.Length)
                {
                    break;
                }
            } while (arr[i] == arr[index]);
            Console.WriteLine();
        }
    }
}

