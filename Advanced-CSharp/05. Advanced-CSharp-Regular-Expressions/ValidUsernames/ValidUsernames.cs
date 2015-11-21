using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex usernameMatch = new Regex(@"^[A-Za-z]\w{2,25}|(?<=[\\\/\)\( ])(?<username>[A-Za-z]\w{2,25})");
        MatchCollection allValidUsernames = usernameMatch.Matches(text);
        int biggestSum = int.MinValue;
        var usernamesToPrint = new List<Match> { };
        for (int i = 0; i < allValidUsernames.Count-1; i++)
        {
            int currentSum = allValidUsernames[i].Length + allValidUsernames[i + 1].Length;
            if (currentSum > biggestSum)
            {
                biggestSum = currentSum;
                usernamesToPrint.Clear();
                usernamesToPrint.Add(allValidUsernames[i]);
                usernamesToPrint.Add(allValidUsernames[i+1]);
            }
        }
        usernamesToPrint.ForEach(x => Console.WriteLine(x));
    }
}

