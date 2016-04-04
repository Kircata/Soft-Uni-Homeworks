namespace _1.Logger.Core
{
    using System;
    using System.Collections.Generic;
    using _1.Logger.Core.Factories;
    using _1.Logger.Enums;
    using _1.Logger.Interfaces;

    public class Logger : ILogger
    {
        private IList<IAppender> appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = new List<IAppender>(appenders);
        }

        public void Info(string message)
        {
            this.WriteLog(message, ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.WriteLog(message, ReportLevel.Warning);
        }

        public void Error(string message)
        {
            this.WriteLog(message, ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.WriteLog(message, ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.WriteLog(message, ReportLevel.Fatal);
        }

        private void WriteLog(string messageText, ReportLevel reportLevel)
        {
            var message = MessageFactory.CreateMessage(DateTime.Now, reportLevel, messageText);

            foreach (var appender in this.appenders)
            {
                appender.Append(message);
            }
        }
    }
}
