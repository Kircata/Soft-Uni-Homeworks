using System;
class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstNumber,secondNumber));
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int max = firstNumber;
        if (firstNumber< secondNumber)
        {
            max = secondNumber;
        }
        return max;
    }
}

