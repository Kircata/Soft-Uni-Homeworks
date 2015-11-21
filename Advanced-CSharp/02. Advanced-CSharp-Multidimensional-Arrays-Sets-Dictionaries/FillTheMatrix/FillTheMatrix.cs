using System;
class FillTheMatrix
{
    static void Main()
    {
        // initializing matrix
        int size = int.Parse(Console.ReadLine());
        int[,] myMatrix = new int[size, size];
        int numberToFill = 1;
        // filling it with patternA
        for (int cols = 0; cols < size; cols++)
        {
            for (int rows = 0; rows < size; rows++, numberToFill++)
            {
                myMatrix[rows, cols] = numberToFill;
            }
        }
        // printing it with patternA
        Console.Write("Matrix with patternA: ");
        Console.WriteLine();
        PrintMatrix(myMatrix);

        // filling it with patternB
        Console.WriteLine();
        myMatrix = new int[size, size];
        numberToFill = 1;
        for (int col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < size; row++, numberToFill++)
                {
                    myMatrix[row, col] = numberToFill;
                }
            }
            else
            {
                for (int row = size - 1; row >= 0; row--, numberToFill++)
                {
                    myMatrix[row, col] = numberToFill;
                }
            }
        }
        // printing it with patternB
        Console.Write("Matrix with patternB: ");
        Console.WriteLine();
        PrintMatrix(myMatrix);
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

