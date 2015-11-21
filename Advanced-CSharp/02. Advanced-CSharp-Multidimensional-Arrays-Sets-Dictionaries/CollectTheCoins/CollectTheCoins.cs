using System;
class CollectTheCoins
{
    static void Main()
    {
        char[][] board = new char[4][];
        for (int row = 0; row < board.GetLength(0); row++)
        {
            string rowLayout = Console.ReadLine();
            board[row] = new char[rowLayout.Length];
            for (int col = 0; col < rowLayout.Length; col++)
            {
                board[row][col] = rowLayout[col];
            }
        }
        string commands = Console.ReadLine();
        int coinCounter = 0;
        int hitCounter = 0;
        int currentRow = 0;
        int currentCol = 0;
        for (int index = 0; index < commands.Length; index++)
        {
            char currentCommand = commands[index];
            if (currentCommand == 'V')
            {
                if (currentRow + 1 < board.GetLength(0)
                    && currentCol < board[currentRow+1].Length)

                {
                    currentRow++;
                    if (board[currentRow][currentCol] == '$')
                    {
                        coinCounter++;
                    }
                }
                else
                {
                    hitCounter++;
                }
            }
            else if (currentCommand == '^')
            {
                if (currentRow - 1 >= 0
                    && currentCol < board[currentRow-1].Length)
                {
                    currentRow--;
                    if (board[currentRow][currentCol] == '$')
                    {
                        coinCounter++;
                    }
                }
                else
                {
                    hitCounter++;
                }
            }
            else if (currentCommand == '>')
            {
                if (currentCol + 1 < board[currentRow].Length)
                {
                    currentCol++;
                    if (board[currentRow][currentCol] == '$')
                    {
                        coinCounter++;
                    }
                }
                else
                {
                    hitCounter++;
                }
            }
            else
            {
                if (currentCol -1 >= 0)
                {
                    currentCol--;
                    if (board[currentRow][currentCol] == '$')
                    {
                        coinCounter++;
                    }
                }
                else
                {
                    hitCounter++;
                }
            }
        }

        Console.WriteLine("Coins collected: {0}", coinCounter);
        Console.WriteLine("Walls hit: {0}", hitCounter);

    }

}

