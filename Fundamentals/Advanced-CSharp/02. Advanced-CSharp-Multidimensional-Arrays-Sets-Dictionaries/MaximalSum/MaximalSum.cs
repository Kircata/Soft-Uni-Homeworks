using System;
using System.Linq;
class MaximalSum
{
    static void Main()
    {
        // filling the matrix
        int[] rowAndCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];
        for (int row = 0; row < rowAndCol[0]; row++)
        {
            int[] rowOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int col = 0;
            foreach (var number in rowOfNumbers)
            {
                matrix[row, col] = number;
                col++;
            }
        }

        // finding the biggest sum
        int sum = 0;
        int biggestSum = int.MinValue;
        int[,] biggestSumMatrix = new int[3, 3];
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    biggestSumMatrix[0, 0] = matrix[row, col];
                    biggestSumMatrix[0, 1] = matrix[row, col+1];
                    biggestSumMatrix[0, 2] = matrix[row, col+2];
                    biggestSumMatrix[1, 0] = matrix[row+1, col];
                    biggestSumMatrix[1, 1] = matrix[row+1, col+1];
                    biggestSumMatrix[1, 2] = matrix[row+1, col+2];
                    biggestSumMatrix[2, 0] = matrix[row+2, col];
                    biggestSumMatrix[2, 1] = matrix[row+2, col+1];
                    biggestSumMatrix[2, 2] = matrix[row+2, col+2];
                }
            }
        }
        //printing on the console
        Console.WriteLine();
        Console.WriteLine("Sum = {0}", biggestSum);
        PrintMatrix(biggestSumMatrix);

    }
    static void PrintMatrix(int[,] matrix)
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

