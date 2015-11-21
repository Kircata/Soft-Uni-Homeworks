using System;
using System.Text.RegularExpressions;
class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine();
        Regex emailRegex = new Regex(@"\b[\w_.-]+@[._\-\w]+\.\w+\b");
        MatchCollection emailMatches = emailRegex.Matches(text);
        foreach (var email in emailMatches)
        {
            Console.WriteLine(email);
        }
    }
}
