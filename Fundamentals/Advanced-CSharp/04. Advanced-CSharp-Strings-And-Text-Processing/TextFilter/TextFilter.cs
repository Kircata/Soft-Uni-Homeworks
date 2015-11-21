using System;
class TextFilter
{
    static void Main()
    {
        string strBannedWords = Console.ReadLine();
        string text = Console.ReadLine();
        char[] separators = new char[2] { ' ', ',' }; 
        string[] bannedWords = strBannedWords.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var bannedWord in bannedWords)
        {
            text = text.Replace(bannedWord, new string('*', bannedWord.Length));
        }
        Console.WriteLine(text);
    }
}

