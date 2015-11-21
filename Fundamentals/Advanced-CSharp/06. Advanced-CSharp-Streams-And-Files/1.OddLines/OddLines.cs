using System;
using System.IO;
class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../ShrekIsLove.txt");
        using (reader)
        {
            int numberOfLine = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (numberOfLine % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                numberOfLine++;
                line = reader.ReadLine();
            }
        }
        // Enjoy ;)
    }
}

