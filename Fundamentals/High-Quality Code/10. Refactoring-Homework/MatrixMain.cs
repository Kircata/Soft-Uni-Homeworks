namespace Matrix
{
    using System;

    public class MatrixMain
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[number, number];
            int step = number;
            int value = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;
            while (true)
            {
                matrix[row, col] = value;

                if (!MatrixLogic.Check(matrix, row, col))
                {
                    break;
                }

                var outOfBoundries = IsOutOfBoundries(row, directionX, number, col, directionY, matrix);

                while (!outOfBoundries)
                {
                    MatrixLogic.Change(ref directionX, ref directionY);
                    outOfBoundries = IsOutOfBoundries(row, directionX, number, col, directionY, matrix);
                }

                row += directionX;
                col += directionY;
                value++;
            }

            PrintMatrix(matrix);

            MatrixLogic.FindCell(matrix, out row, out col);
            if (row != 0 && col != 0)
            { 
                directionX = 1;
                directionY = 1;
                // TODO: Refactor into method
                while (true)
                { 
                    matrix[row, col] = value;
                    if (!MatrixLogic.Check(matrix, row, col))
                    {
                        break;
                    }

                    while ((row + directionX >= number || row + directionX < 0 || col + directionY >= number || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0))
                    {
                        MatrixLogic.Change(ref directionX, ref directionY);
                    }

                    row += directionX;
                    col += directionY;
                    value++;
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsOutOfBoundries(int row, int directionX, int number, int col, int directionY, int[,] matrix)
        {
            bool outOfBoundries =
                row + directionX >= number ||
                row + directionX < 0 ||
                col + directionY >= number ||
                col + directionY < 0 ||
                matrix[row + directionX, col + directionY] != 0;

            return outOfBoundries;
        }
    }
}
