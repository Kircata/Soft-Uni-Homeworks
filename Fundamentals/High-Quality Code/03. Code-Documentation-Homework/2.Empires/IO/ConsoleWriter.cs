namespace _1.Empires.IO
{
    using System;
    using Contracts;

    public class ConsoleWriter : IOutputWriter
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
