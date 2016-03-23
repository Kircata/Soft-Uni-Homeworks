namespace _3.MinesweeperGame.Contracts
{
    public interface IOutputWriter
    {
        void Print(string message, params object[] args);

        void PrintLine(string message, params object[] args);
    }
}
