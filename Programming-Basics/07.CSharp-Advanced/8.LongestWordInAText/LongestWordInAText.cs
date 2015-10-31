using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LongestWordInAText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ', ',', '.');
            string longestWord = null;
            int wordLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToCharArray().Length > wordLength)
                {
                    wordLength = words[i].ToCharArray().Length;
                    longestWord = words[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }

