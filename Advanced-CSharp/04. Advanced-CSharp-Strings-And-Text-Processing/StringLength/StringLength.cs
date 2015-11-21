using System;
class StringLength
{
    public static void Main()
    {
        string text = Console.ReadLine();
        if (text.Length < 20)
        {
            Console.WriteLine("{0}{1}", text, new string('*', 20 - text.Length));
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}
