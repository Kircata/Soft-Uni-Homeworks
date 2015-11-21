using System;
class CountSubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string wordToMatch = Console.ReadLine();
        int occurrences = 0;
        for (int i = 0; i <= text.Length - wordToMatch.Length; i++)
        {
            string currentWord = text.Substring(i, wordToMatch.Length);
            if (string.Compare(currentWord, wordToMatch, true) == 0)
            {
                occurrences++;
            }
        }
        Console.WriteLine(occurrences);
    }
}
