namespace _2.ReformatYourOwnCode
{
    using System;

    public class Fibonacci
    {
        public static void Main()
        {
            Console.WriteLine("Enter a position to chose from the Fibonacci numbers.");
            string command = Console.ReadLine();

            while (command != "exit")
            {
                long firstNumber = 0;
                long secondNumber = 1;
                int limit;
                long wantedNumber = 0;

                if (int.TryParse(command, out limit))
                {
                    for (int count = 0; count < limit; count++, firstNumber = secondNumber, secondNumber = wantedNumber)
                    {
                        wantedNumber = firstNumber + secondNumber;
                    }

                    Console.WriteLine("The number you're interested in is: {0}", wantedNumber);
                }
                else
                {
                    Console.WriteLine("You have entered and invalid number!");
                }

                Console.WriteLine("Enter a position to chose from the Fibonacci numbers.");
                command = Console.ReadLine();
            }
        }
    }
}
