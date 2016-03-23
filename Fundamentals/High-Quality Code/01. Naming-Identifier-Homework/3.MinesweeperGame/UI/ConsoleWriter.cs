namespace _3.MinesweeperGame.UI
{
    using System;
    using Contracts;

    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message, params object[] args)
        {
            Console.Write(message, args);
        }

        public void PrintLine(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
