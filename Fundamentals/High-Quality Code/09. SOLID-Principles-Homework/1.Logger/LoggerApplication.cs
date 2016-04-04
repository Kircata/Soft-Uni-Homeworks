namespace _1.Logger
{
    using _1.Logger.Models.Appenders;
    using _1.Logger.Models.Layouts;
    using Core;

    public class LoggerApplication
    {
        public static void Main()
        {
            var simpleLayout = new SimpleLayout();

            var consoleAppender = new ConsoleAppender(simpleLayout);
            var fileAppender = new FileAppender(simpleLayout);
            // File location -> 1.Logger/bin/Debug
            fileAppender.File = "log.txt";

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");
        }
    }
}
