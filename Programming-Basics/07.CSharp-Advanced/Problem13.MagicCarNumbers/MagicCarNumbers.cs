using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MagicCarNumbers
    {
        static void Main()
        {
            char[] validLetters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            if ((a == b && a == c && a == d) ||
                                (a == b && a == c) ||
                                (b == c && b == d) ||
                                (a == b && c == d) ||
                                (a == c && b == d) ||
                                (a == d && b == c))
                            {
                                for (int x = 0; x < validLetters.Length; x++)
                                {
                                    for (int y = 0; y < validLetters.Length; y++)
                                    {
                                        int firstLetterToNumber = (validLetters[x] - 'A' + 1) * 10;
                                        int secondLetterToNumber = (validLetters[y] - 'A' + 1) * 10;

                                        int magicWeightNumber = firstLetterToNumber + secondLetterToNumber + a + b + c + d + 40;

                                        if (magicWeightNumber == input)
                                        {
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }

