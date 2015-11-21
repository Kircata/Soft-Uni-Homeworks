using System;
using System.Linq;
using System.Collections.Generic;
class ReverseString
{
    public static void Main()
    {
        string text = Console.ReadLine();
        IEnumerable<char> reversedString = text.Reverse();
        foreach (var ch in reversedString)
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }
}
