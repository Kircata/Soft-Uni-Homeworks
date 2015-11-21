using System;
using System.Linq;
using System.Text.RegularExpressions;
class LettersChangeNumbers
{
    static void Main()
    {
        string strSequenceOfStrings = Console.ReadLine();
        string[] sequenceOfStrings = Regex.Split(strSequenceOfStrings, @"\s+");
        double totalSum = 0;
        for (int i = 0; i < sequenceOfStrings.Length; i++)
        {
            string numberAsString = sequenceOfStrings[i].Substring(1, (sequenceOfStrings[i].Length-2));
            double number = int.Parse(numberAsString);
            number = ExecuteFirstChar(sequenceOfStrings[i][0], number);
            number = ExecuteSecondChar(sequenceOfStrings[i][sequenceOfStrings[i].Length - 1], number);
            totalSum += number;
        }
        Console.WriteLine("{0:f2}", totalSum);
    }
    static double ExecuteFirstChar(char c, double number)
    {
        if (c>= 65 && c <=90)
        {
            return number / (c - 64);
        }
        else
        {
            return number * (c - 96);
        }
    }
    static double ExecuteSecondChar(char c, double number)
    {
        if (c>=65 && c <=90)
        {
            return number - (c - 64);
        }
        else
        {
            return number + (c - 96);
        }
    }
}

