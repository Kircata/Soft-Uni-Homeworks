using System;
class AmIFemale
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is your gender is female? Enter yes or no!");
        string gender = Console.ReadLine();
        bool isFemale = gender == "no";
        Console.WriteLine(isFemale);
    }
}
