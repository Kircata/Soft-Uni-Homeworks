using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CalculateSum
    {
        static void Main()
        {
            Console.Write("Enter integer number n (1 <= n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter integer number x: ");
            int x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            double power = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += (factorial / (x * power));
                power *= x;
            }

            Console.WriteLine("{0:F5}", sum);
        }

    }

