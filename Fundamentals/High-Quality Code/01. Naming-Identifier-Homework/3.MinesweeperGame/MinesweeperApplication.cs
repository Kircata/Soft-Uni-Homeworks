namespace _3.MinesweeperGame
{
    using Contracts;
    using Core;
    using UI;

    public class MinesweeperApplication
    {
        public static void Main()
        {
            IGameDatabase gameDatabase = new GameDatabase();
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();

            var engine = new GameEngine(
                gameDatabase,
                reader,
                writer);

            engine.Start();
        }
    }
}
