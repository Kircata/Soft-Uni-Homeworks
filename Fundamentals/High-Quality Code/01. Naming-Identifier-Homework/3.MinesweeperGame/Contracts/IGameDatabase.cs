namespace _3.MinesweeperGame.Contracts
{
    using System.Collections.Generic;
    using Models;

    public interface IGameDatabase
    {
        char[,] PublicGameBoard { get; }

        char[,] PrivateGameBoard { get; }

        IList<Player> TopPlayers { get; }

        char CountNeighboringMines(int rowIndex, int colIndex);

        string RenderScoreBoard();

        void ResetBoards();
    }
}
