using System;
using System.Linq;
class SortArrayOfNumbers
{
    static void Main()
    {
        int[] arrOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(arrOfNumbers);
        Console.WriteLine("{0}", string.Join(" ", arrOfNumbers));   
    }
}

