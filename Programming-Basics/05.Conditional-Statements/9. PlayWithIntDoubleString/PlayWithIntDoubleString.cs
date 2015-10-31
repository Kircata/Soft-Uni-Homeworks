using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PlayWithIntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int inputNum = int.Parse(Console.ReadLine());
            switch (inputNum)
            {
                case 1: Console.Write("Please enter an integer: ");
                    int integer = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", integer + 1);
                    break;
                case 2: Console.Write("Please enter a double: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", d + 1);
                    break;
                case 3: Console.Write("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("{0}*", str);
                    break;
                default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

