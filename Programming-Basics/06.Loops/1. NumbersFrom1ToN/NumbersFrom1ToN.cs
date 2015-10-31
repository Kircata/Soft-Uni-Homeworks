using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NumbersFrom1ToN
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int counter = 1 ;

            while (counter <=n)
            {
                Console.Write("{0} ", counter );
                counter++;
            }
            Console.ReadKey();
          
        }
    }

