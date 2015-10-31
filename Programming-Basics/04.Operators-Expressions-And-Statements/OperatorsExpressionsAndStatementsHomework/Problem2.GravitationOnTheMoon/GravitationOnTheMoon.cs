using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = weight * 0.17;
            Console.WriteLine("Your weight on the moon is: {0}", weightOnMoon);
        }
    }
}
