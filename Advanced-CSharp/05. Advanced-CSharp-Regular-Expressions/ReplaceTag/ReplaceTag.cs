using System;
using System.Text.RegularExpressions;
class ReplaceTag
{
    static void Main()
    {
        //Write the whole htmlCode on a single line please
        //Like this:  "<ul> <li> <a href='http://softuni.bg'>SoftUni</a> </li> </ul>"
        string htmlCode = Console.ReadLine();
        string pattern = @"<a\s+href=(""|')http://softuni.bg\1>SoftUni<\/a>";
        Regex regex = new Regex(pattern);
        string replacement = @"[URL href=http://softuni.bg]SoftUni[/URL]";
        htmlCode = regex.Replace(htmlCode, replacement);
        Console.WriteLine(htmlCode);
    }
}

