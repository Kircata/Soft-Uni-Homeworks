using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string stringnum1 = Console.ReadLine();
            int num1 = int.Parse(stringnum1);
            Console.Write("Enter your second number: ");
            string stringnum2 = Console.ReadLine();
            int num2 = int.Parse(stringnum2);
            Console.Write("Enter your third number: ");
            string stringnum3 = Console.ReadLine();
            int num3 = int.Parse(stringnum3);
            Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, num1 + num2 + num3);
        }
    }
}
