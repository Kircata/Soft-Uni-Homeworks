using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MatrixOfNumbers
    {
        static void Main()
        {
           
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Matrix:");
            int[,] matrix = new int[input, input];
            int num = 1;
            int numCombinaor = 1;
            for (int row = 0; row < input; row++)
            {
                for (int column = 0; column < input; column++)
                {

                    matrix[row, column] = num;
                    if (input < 5)
                    {
                        Console.Write("{0, -2}", matrix[row, column]);
                    }
                    else
                    {
                        Console.Write("{0, -3}", matrix[row, column]);
                    }
                    num++;
                }
                num = numCombinaor + 1 ;
                numCombinaor++;
                Console.WriteLine();
            }
        }
    }

