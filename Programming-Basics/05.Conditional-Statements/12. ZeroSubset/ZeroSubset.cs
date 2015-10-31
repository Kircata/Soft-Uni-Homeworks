using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ZeroSubset
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int countSubset = 0;
            // for num1 and onwards
            if (num1 + num2 == 0)
            {
                Console.WriteLine("{0} + {1} = 0",num1,num2 );
                countSubset++;
            }
            if (num1 + num2 + num3 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0",num1,num2,num3);
                countSubset++;
 
            }
            if (num1 + num2 + num3 + num4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2,num3,num4);
                countSubset++;

            }
            if (num1 + num2 + num3 +num4 +num5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4}", num1,num2,num3,num4,num5);
                countSubset++;

            }
            if (num1 + num3 == 0)
            {
                Console.WriteLine("{0} + {1} = 0",num1,num3 );
                countSubset++;
            }
            if (num1 + num3 + num4 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", num1, num3, num4);
                countSubset++;
            }
            if (num1 + num3 + num4 + num5 == 0)
            {
                 Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num3,num4,num5);
                countSubset++;
            }
            if (num1 + num4 == 0)
            {
                  Console.WriteLine("{0} + {1} = 0",num1,num4 );
                countSubset++;
            }
            if (num1 + num4 + num5 == 0)
            {
                  Console.WriteLine("{0} + {1} + {2} = 0", num1, num4, num5);
                countSubset++;
            }
            if (num1 + num5 == 0)
            {
                 Console.WriteLine("{0} + {1} = 0",num1,num5 );
                countSubset++;
            }
            // for num2 and onwards
            if (num2 + num3 == 0)
            {
                 Console.WriteLine("{0} + {1} = 0",num2,num3 );
                countSubset++;
            }
            if (num2 + num3 + num4 == 0)
            {
                 Console.WriteLine("{0} + {1} + {2} = 0", num2, num3, num4);
                countSubset++;
            }
            if (num2 + num3 + num4 + num5 == 0)
            {
                 Console.WriteLine("{0} + {1} + {2} + {3} = 0", num2, num3,num4,num5);
                countSubset++;
            }
            if (num2 + num4 == 0)
            {
                Console.WriteLine("{0} + {1} = 0",num2,num4 );
                countSubset++;
            }
            if (num2 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", num2, num4, num5);
                countSubset++;
            }
            if (num2 + num5 == 0)
            {
                Console.WriteLine("{0} + {1} = 0",num2,num5 );
                countSubset++;
            }
            // for num3 and onwards
            if (num3 + num4 == 0)
            {
                Console.WriteLine("{0} + {1} = 0", num3, num4);
                countSubset++;
            }
            if (num3 + num4 + num5 == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", num3, num4, num5);
                countSubset++;
            }
            if (num3 + num5 == 0)
            {
               Console.WriteLine("{0} + {1} = 0", num3, num5);
                countSubset++; 
            }
            // for num4 + num5
            if (num4 + num5 == 0)
            {
                Console.WriteLine("{0} + {1} = 0", num4, num5);
                countSubset++; 
            }
            if (countSubset == 0)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }

