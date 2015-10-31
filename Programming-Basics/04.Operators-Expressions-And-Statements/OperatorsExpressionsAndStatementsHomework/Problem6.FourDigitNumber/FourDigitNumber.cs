using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a four-digit number: ");
            int n = int.Parse(Console.ReadLine());
            byte firstDigit = (byte)(n % 10);
            byte secondDigit = (byte)((n / 10) % 10);
            byte thirdDigit = (byte)((n / 100) % 10);
            byte fourthDigit = (byte)((n / 1000) % 10);
            int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
            string reversedDigits = Convert.ToString(firstDigit)
                + Convert.ToString(secondDigit)
                + Convert.ToString(thirdDigit)
                + Convert.ToString(fourthDigit);
            string lastDigitInFront = Convert.ToString(firstDigit)
                + Convert.ToString(fourthDigit)
                + Convert.ToString(thirdDigit)
                + Convert.ToString(secondDigit);
            string exchangedDigits = Convert.ToString(fourthDigit)
                + Convert.ToString(secondDigit)
                + Convert.ToString(thirdDigit)
                + Convert.ToString(firstDigit);
            Console.WriteLine("The sum of these digits is: {0}", sumOfDigits);
            Console.WriteLine("Reversed: {0}", reversedDigits);
            Console.WriteLine("Last digit in front: {0}", lastDigitInFront);
            Console.WriteLine("Second and third digits exchanged: {0}", exchangedDigits);

        }
    }
}
