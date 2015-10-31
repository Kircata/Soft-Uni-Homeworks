using System;

    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            if ((score == 1) || (score == 2) || (score == 3))
            {
                int multiplyScore = score * 10;
                Console.WriteLine(multiplyScore);
            }
            else if ((score == 4)||(score == 5)||(score ==6))
            {
                int multiplyScore = score * 100;
                Console.WriteLine(multiplyScore);
            }
            else if ((score == 7)|| (score == 8)|| (score == 9))
            {
                int multiplyScore = score * 1000;
                Console.WriteLine(multiplyScore);
            }
            else if ((score < 1) || (score > 9))
            {
                Console.WriteLine("invalid score");
            }
        }
    }

