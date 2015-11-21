using System;
using System.Linq;
using System.Collections.Generic;
class CountSymbols
{
    static void Main()
    {
        string text = Console.ReadLine();
        SortedSet<char> sortedCharSet = new SortedSet<char> { };
        foreach (var ch in text)
        {
            sortedCharSet.Add(ch);
        }
        int counter = 0;
        for (int i = 0; i < sortedCharSet.Count; i++, counter=0)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (sortedCharSet.ElementAt(i) == text[j])
                {
                    counter++;
                }
            }
            Console.WriteLine("{0}: {1} time/s", sortedCharSet.ElementAt(i), counter);
        }
    }
}

