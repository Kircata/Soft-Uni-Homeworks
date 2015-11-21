using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Palindromes
{
    static void Main()
    {
        char[] separators = new char[5] {' ',',', '.', '?', '!'};
        string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
        SortedSet<string> palindromes = new SortedSet<string> { };
        for (int index = 0; index < words.Length; index++)
        {
            if (string.Compare(words[index], 
                ReverseString(words[index]), true) == 0)
            {
                palindromes.Add(words[index]);
            }
        }
        Console.WriteLine("{0}",string.Join(", ", palindromes));
    }
    public static string ReverseString(string text)
    {
        StringBuilder reversedString = new StringBuilder();
        for (int index = text.Length-1; index >=0; index--)
        {
            reversedString.Append(text[index]);
        }
        return reversedString.ToString();
    }

}

