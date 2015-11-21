using System;
using System.Linq;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
class CategorizeNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float[] allNumbers = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
        List<float> fpNumbers = new List<float> { };
        List<int> integerNumbers = new List<int> { };
        for (int index = 0; index < allNumbers.Length; index++)
        {
            if (allNumbers[index].ToString().Contains('.'))
            {
                fpNumbers.Add(allNumbers[index]);
            }
            else
            {
                integerNumbers.Add((int)allNumbers[index]);
            }
        }
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}"
            , string.Join(", ", fpNumbers)
            , fpNumbers.Min()
            , fpNumbers.Max()
            , fpNumbers.Sum()
            , fpNumbers.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}"
            , string.Join(", ", integerNumbers)
            , integerNumbers.Min()
            , integerNumbers.Max()
            , integerNumbers.Sum()
            , integerNumbers.Average());
    }
}

