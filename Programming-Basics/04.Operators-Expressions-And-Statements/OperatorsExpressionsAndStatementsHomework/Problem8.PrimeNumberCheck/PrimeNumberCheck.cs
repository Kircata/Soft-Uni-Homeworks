using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int numberToCheck = 0;

            while (numberToCheck < 1 || numberToCheck > 100)
            {
                Console.Write("Enter a number to check if prime: ");
                if (!int.TryParse(Console.ReadLine(), out numberToCheck))
                {
                    Console.WriteLine("Not a valid number!");
                    return;
                }
            }
            if (numberToCheck == 0 || numberToCheck == 1)
            {
                isPrime = false;
            }
            double maxDivider = Math.Sqrt(numberToCheck);
            for (int divider = 2; divider < maxDivider; divider++)
            {
                if ((numberToCheck % divider) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(numberToCheck + " is prime!");
            }
            else
            {
                Console.WriteLine(numberToCheck + " is not prime");
            }
        }
    }
}
