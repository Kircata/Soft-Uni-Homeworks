using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6.FourDigitNumber_second_solution_
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
            Console.WriteLine("The sum of these digits is: {0}", firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
        }
    }
}
