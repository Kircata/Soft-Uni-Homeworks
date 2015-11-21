using System;
using System.Linq;
class MatrixShuffling
{
    static void Main()
    {
        //initializing
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        //filling
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                string data = Console.ReadLine();
                matrix[row, col] = data;
            }
        }

        //swaping
        string[] command = Console.ReadLine().Split().ToArray();
        do
        {
            if (!command.Contains("swap") && command.Length != 5)
            {
                Console.WriteLine("Invalid input!");
                command = Console.ReadLine().Split().ToArray();
                continue;
            }
            int x1 = int.Parse(command[1]);
            int y1 = int.Parse(command[2]);
            int x2 = int.Parse(command[3]);
            int y2 = int.Parse(command[4]);
            if (   x1 >= rows || x1 < 0
                || x2 >= rows || x2 < 0
                || y1 >= cols || y1 < 0
                || y2 >= cols || y2 < 0)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                string matrixOldValue = matrix[x1, y1];
                matrix[x1, y1] = matrix[x2, y2];
                matrix[x2, y2] = matrixOldValue;
            }
            command = Console.ReadLine().Split().ToArray();
        } while (!command.Contains("END"));
        //printing
        PrintMatrix(matrix);
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }

}

