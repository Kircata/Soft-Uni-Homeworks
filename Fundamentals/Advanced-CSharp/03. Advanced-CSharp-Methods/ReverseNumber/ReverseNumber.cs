using System;
using System.Threading;
using System.Globalization;
class ReverseNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        float number = float.Parse(Console.ReadLine());
        Console.WriteLine(GetReversedNumber(number));
    }
    static float GetReversedNumber(float number)
    {
        string numberAsString = number.ToString();
        char[] stringAsCharArray = numberAsString.ToCharArray();
        Array.Reverse(stringAsCharArray);
        numberAsString = new string(stringAsCharArray);
        number = float.Parse(numberAsString);
        return number;
    }
}

