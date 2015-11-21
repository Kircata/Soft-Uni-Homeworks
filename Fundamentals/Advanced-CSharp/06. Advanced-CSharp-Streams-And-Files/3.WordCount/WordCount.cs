using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
class WordCount
{
    static void Main()
    {
        StreamReader wordsReader = new StreamReader("../../words.txt");
        StreamReader textReader = new StreamReader("../../text.txt");
        StreamWriter resultWriter = new StreamWriter("../../result.txt");
        List<string> wordsToMacth = FillWordsInList(wordsReader);
        var resultList = new Dictionary<string, int>();
        using (textReader)
        {
            string text = textReader.ReadToEnd();
            for (int i = 0; i < wordsToMacth.Count; i++)
            {
                string patternToMatch = string.Format(@"\b{0}\b", wordsToMacth[i]);
                Regex findWords = new Regex(patternToMatch);
                MatchCollection matchedWords = findWords.Matches(text);
                resultList.Add(wordsToMacth[i], matchedWords.Count);                           
            }
        }
        using (resultWriter)
        {
            foreach (var result in resultList
                .OrderByDescending(result=> result.Value))
            {
                Console.WriteLine("{0} - {1}", result.Key, result.Value);
            }          
        }    
    }
    static List<string> FillWordsInList(StreamReader wordsReader)
    {
        var wordsList = new List<string> { };
        string line = wordsReader.ReadLine();
        while (line != null)
        {
            wordsList.Add(line);
            line = wordsReader.ReadLine();
        }
        return wordsList;
    }
}

