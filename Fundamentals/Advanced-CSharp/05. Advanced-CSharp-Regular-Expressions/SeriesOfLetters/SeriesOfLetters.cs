using System;
using System.Text.RegularExpressions;
class SeriesOfLetters
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern;
        string replacement;
        Regex regexReplace;
        for (int i = 0; i < text.Length; i++)
        {
            pattern = string.Format(@"{0}+", text[i]);
            replacement = string.Format(@"{0}", text[i]);
            regexReplace = new Regex(pattern);
            text = regexReplace.Replace(text, replacement);
        }
        Console.WriteLine(text);
    }
}

