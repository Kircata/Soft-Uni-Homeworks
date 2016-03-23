namespace MultiplyingMatrices
{
    using System;

    public class MultiplyingMatrices
    {
        public static void Main(string[] args)
        {
            var firstMatrix = new double[,]
            {
                { 1, 3 },
                { 5, 7 }            
            };
            var secondMatrix = new double[,]
            {
                { 4, 2 }, 
                { 1, 5 }             
            };
            var resultMatrix = MultiplyMatrices(firstMatrix, secondMatrix);

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static double[,] MultiplyMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("The number of cols in the first matrix should be the same as the number of rows in the second matrix!");
            }

            var resultMatrixLength = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int firstMatrixCurrentRow = 0; firstMatrixCurrentRow < resultMatrix.GetLength(0); firstMatrixCurrentRow++)
            {
                for (int secondMatrixCurrentCol = 0; secondMatrixCurrentCol < resultMatrix.GetLength(1); secondMatrixCurrentCol++)
                {
                    for (int resultMatrixIndex = 0; resultMatrixIndex < resultMatrixLength; resultMatrixIndex++)
                    {
                        resultMatrix[firstMatrixCurrentRow, secondMatrixCurrentCol] 
                            += firstMatrix[firstMatrixCurrentRow, resultMatrixIndex] * secondMatrix[resultMatrixIndex, secondMatrixCurrentCol];
                    }
                }
            }
            return resultMatrix;
        }
    }
}