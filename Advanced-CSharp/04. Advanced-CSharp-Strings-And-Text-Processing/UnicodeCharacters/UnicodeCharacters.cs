using System;
class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int index = 0; index < text.Length; index++)
        {
            int asciiNumberToDec = text[index] + 0;
            string asciiNumberToHex = asciiNumberToDec.ToString("X4");
            Console.Write(string.Concat("\\u", asciiNumberToHex));
        }
        Console.WriteLine();
    }

}

