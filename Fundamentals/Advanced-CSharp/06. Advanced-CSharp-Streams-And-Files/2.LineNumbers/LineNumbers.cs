using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        
        StreamReader reader = new StreamReader("../../Poem.txt");
        StreamWriter writer = new StreamWriter("../../NewPoem.txt");
        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber == 5
                        || lineNumber == 10)
                    {
                        writer.WriteLine();
                        lineNumber++;
                        line = reader.ReadLine();
                        continue;
                    }
                    writer.WriteLine("{0}. {1}", lineNumber, line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
        // Guess the poem.

    }
}

