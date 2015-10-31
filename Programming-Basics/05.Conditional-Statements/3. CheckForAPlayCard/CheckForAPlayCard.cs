using System;

    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Write("Enter a play card sign: ");
            string sign = Console.ReadLine();
            if ((sign == "2")
                || (sign == "3") 
                || (sign == "4") 
                || (sign == "5") 
                || (sign == "6") 
                || (sign == "7")
                || (sign == "8")
                || (sign == "9")
                || (sign == "10")
                || (sign == "J")
                || (sign == "Q")
                || (sign == "K"))
            {
                Console.WriteLine("Is it a valid card sign ?: Yes");
            }
            else
            {
                Console.WriteLine("Is it a valid card sign ?: No");
            }
        }
    }

