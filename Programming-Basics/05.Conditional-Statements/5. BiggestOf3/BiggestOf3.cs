using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BiggestOf3
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Biggest: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Biggest: {0}", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("Biggest: {0}", num3);
            }
        }
    }

