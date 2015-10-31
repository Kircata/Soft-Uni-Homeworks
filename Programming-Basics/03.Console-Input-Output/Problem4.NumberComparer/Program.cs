using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            string strNum1 = Console.ReadLine();
            double num1 = double.Parse(strNum1);
            Console.Write("b = ");
            string strNum2 = Console.ReadLine();
            double num2 = double.Parse(strNum2);
            double result = Math.Max(num1, num2);
            Console.WriteLine("The greater is: {0}", result);
        }
    }
}
