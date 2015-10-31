using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfPalindromes
{
    static void Main()
    {
        int firstChar = 97;
        int secondChar = 97;
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (col == 0)
                {
                    Console.Write("{0}{1}{0} ", (char)(firstChar), (char)(secondChar));
                    continue;
                }
                Console.Write("{0}{1}{0} ", (char)(firstChar), (char)(secondChar + 1));
                secondChar++;
            }
            Console.WriteLine();
            firstChar++;
            secondChar= firstChar;
        }

    }
}

