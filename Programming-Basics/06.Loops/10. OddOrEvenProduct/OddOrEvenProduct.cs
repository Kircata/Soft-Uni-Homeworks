using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class OddOrEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter how many numbers you want (separated by space): ");
            string numberCount = Console.ReadLine().Trim();
            int [] numberCountArray = numberCount.Split(' ').Select(int.Parse).ToArray();
            int OddProduct = 1;
            int EvenProduct = 1;
            for (int i = 0; i < numberCountArray.Length; i++)
            {

                if (i % 2 ==0)
                {
                    OddProduct *= numberCountArray[i];
                  
                }
                else
                {
                    EvenProduct *= numberCountArray[i];
                    
                }
            }
            if (EvenProduct == OddProduct)
            {
                Console.WriteLine("yes\nproduct = {0}", EvenProduct);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", OddProduct, EvenProduct);
            }

        }
    }

