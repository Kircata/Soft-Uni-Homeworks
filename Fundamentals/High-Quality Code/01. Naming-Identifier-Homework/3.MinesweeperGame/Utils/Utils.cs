using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MinesweeperGame.Utils
{
    public static class Utils
    {
        public static string RenderGameBoard(char[,] board)
        {
            var result = new StringBuilder();

            int numberOfRows = board.GetLength(0);
            int numberOfCols = board.GetLength(1);

            result.AppendLine();
            result.AppendLine(" + ---------------------+");
            result.AppendLine("  | 0 1 2 3 4 5 6 7 8 9 |");
            result.AppendLine("+-+---------------------+");

            for (int row = 0; row < numberOfRows; row++)
            {
                result.Append($"|{row}| ");
                for (int col = 0; col < numberOfCols; col++)
                {
                    result.Append($"{board[row, col]} ");
                }

                result.AppendLine("|");
            }

            result.AppendLine("+-+---------------------+");

            return result.ToString();
        }
    }
}
