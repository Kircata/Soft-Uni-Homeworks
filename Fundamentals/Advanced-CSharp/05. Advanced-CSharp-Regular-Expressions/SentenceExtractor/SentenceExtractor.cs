using System;
using System.Text.RegularExpressions;
class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string sentences = Console.ReadLine();
        string pattern = string.Format(@"[\w\s]+\b{0}\b[\w\s]+[!|.|?]", keyword);
        Regex keywordRegex = new Regex(pattern);
        MatchCollection matches = keywordRegex.Matches(sentences);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

