using System.Data;
using System.Runtime.CompilerServices;
using _3.MinesweeperGame.Models;

namespace _3.MinesweeperGame.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Utils;

    public class GameEngine : IEngine
    {
        private const int MaxPossiblePoints = 35;

        private readonly IGameDatabase gameDatabase;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        private bool pendingRestart;
        private int points;
        private int currentRow;
        private int currentCol;

        public GameEngine(
            IGameDatabase gameDatabase,
            IInputReader reader,
            IOutputWriter writer)
        {
            this.gameDatabase = gameDatabase;
            this.reader = reader;
            this.writer = writer;

            this.points = 0;
            this.currentRow = 0;
            this.currentCol = 0;

            this.PrintWelcomeMessage();
        }

        public bool IsRunning { get; set; }

        public void Start()
        {
            this.IsRunning = true;

            this.PrintPublicGameBoard();

            while (this.IsRunning)
            {
                this.writer.Print("Command = ");
                var commandTokens = this.reader.
                    Read().
                    Trim().
                    Split(' ');
                try
                {
                    this.DispatchCommand(commandTokens);
                }
                catch (Exception ex)
                {
                    this.writer.PrintLine(ex.Message);
                }
            }


            if (this.pendingRestart)
            {
                this.pendingRestart = false;
                this.Start();
            }
        }

        public void Stop()
        {
            this.IsRunning = false;
        }

        protected virtual void DispatchCommand(string[] commandArgs)
        {
            string command = commandArgs[0];

            if (commandArgs.Length == 2)
            {
                command = "turn";
            }

            switch (command)
            {
                case "turn":
                    this.ExecuteTurnCommand(commandArgs);
                    break;
                case "top":
                    this.ExecuteTopCommand();
                    break;
                case "restart":
                    this.ExecuteRestartCommand();
                    break;
                case "exit":
                    this.ExecuteExitCommand(commandArgs);
                    break;
                default:
                    throw new RowNotInTableException("Command not implemented.");
            }
        }

        private void PrintWelcomeMessage()
        {
            this.writer.PrintLine("+------Minesweeper------+");
            this.writer.PrintLine("|                       |");
            this.writer.PrintLine("+-------Commands--------+");
            this.writer.PrintLine("|top =>      Score board|");
            this.writer.PrintLine("|restart => Restart game|");
            this.writer.PrintLine("|exit =>       Exit game|");
            this.writer.PrintLine("|n n =>      Select cell|");
            this.writer.PrintLine("+-----------------------+");
        }

        private void PrintPublicGameBoard()
        {
            this.writer.PrintLine(Utils.RenderGameBoard(this.gameDatabase.PublicGameBoard));
        }

        private void PrintPrivateGameBoard()
        {
            this.writer.PrintLine(Utils.RenderGameBoard(this.gameDatabase.PrivateGameBoard));
        }

        private void PrintScoreBoard()
        {
            this.writer.PrintLine(this.gameDatabase.RenderScoreBoard());
        }

        private void ExecuteExitCommand(string[] commandArgs)
        {
            this.writer.PrintLine("Good bye!");
            this.Stop();
        }

        private void ExecuteRestartCommand()
        {
            this.ResetGame();
        }

        private void ExecuteTopCommand()
        {
            this.writer.Print(this.gameDatabase.RenderScoreBoard());
        }

        private void ExecuteTurnCommand(string[] commandArgs)
        {
            if (int.TryParse(commandArgs[0], out this.currentRow) &&
                int.TryParse(commandArgs[1], out this.currentCol) &&
                this.ValidateCellPosition(this.gameDatabase.PrivateGameBoard,this.currentRow,this.currentCol))
            {
                if (this.gameDatabase.PrivateGameBoard[this.currentRow, this.currentCol] != '*')
                {
                    if (this.gameDatabase.PrivateGameBoard[this.currentRow,this.currentCol] == '-')
                    {
                        this.MakeTurn();
                    }

                    if (MaxPossiblePoints == this.points)
                    {
                        this.GameOver();
                    }
                    else
                    {
                        this.PrintPublicGameBoard();
                    }
                }
                else
                {
                    this.GameOver(false);
                }
            }
            else
            {
                throw new ArgumentException("Invalid cell selected.");
            }
        }

        private void MakeTurn()
        {
            char numOfNeighboringMines =
                this.gameDatabase.CountNeighboringMines(this.currentRow, this.currentCol);
            this.gameDatabase.PrivateGameBoard[this.currentRow, this.currentCol] = numOfNeighboringMines;
            this.gameDatabase.PublicGameBoard[this.currentRow, this.currentCol] = numOfNeighboringMines;

            this.points ++;
        }

        private void GameOver(bool success = true)
        {
            if (success)
            {
                this.writer.PrintLine("Great! You've succesfully disarmed all 35 cells on the board!");
            }
            else
            {
                this.writer.PrintLine("Sorry, you've lost.");
                this.writer.PrintLine($"Your points: {this.points}");
            }

            this.PrintPrivateGameBoard();
            this.writer.Print("Your name = ");
            string name = this.reader.Read();
            Player player = new Player(name, this.points);

            if (this.gameDatabase.TopPlayers.Count < 5)
            {
                this.gameDatabase.TopPlayers.Add(player);
            }
            else
            {
                for (int index = 0; index < this.gameDatabase.TopPlayers.Count; index++)
                {
                    if (this.gameDatabase.TopPlayers[index].Points < player.Points)
                    {
                        this.gameDatabase.TopPlayers.Insert(index, player);
                        this.gameDatabase.TopPlayers.RemoveAt(this.gameDatabase.TopPlayers.Count-1);
                        break;
                    }
                }
            }
            
            this.ResetGame();  
        }

        private void ResetGame()
        {
            this.Stop();
            this.points = 0;
            this.gameDatabase.ResetBoards();
            this.PrintScoreBoard();
            this.pendingRestart = true;
        }

        private bool ValidateCellPosition(char[,] gameBoard, int row, int col)
        {
            int rows = gameBoard.GetLength(0);
            int cols = gameBoard.GetLength(1);

            bool result = row >= 0 &&
                row < rows &&
                col >= 0 &&
                col < cols;

            return result;
        }


    }
}
