using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MinMaxSumAndAvg
    {
        static void Main()
        {
            
            int numberCount = int.Parse(Console.ReadLine());
          

            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < numberCount; i++)
            {
                Console.Write("Enter number[{0}]: ", i + 1);
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine();
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", (double)sum / (double)numberCount);
        }
    }

