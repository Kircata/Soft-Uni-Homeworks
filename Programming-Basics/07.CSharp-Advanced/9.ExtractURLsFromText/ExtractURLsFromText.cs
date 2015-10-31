using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ExtractURLsFromText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] wordsInText = text.Split(' ', ',');

            for (int i = 0; i < wordsInText.Length; i++)
            {
                if (wordsInText[i].StartsWith("http://") || wordsInText[i].StartsWith("www."))
                {
                    Console.WriteLine(wordsInText[i]);
                }
            }
        }
    }

