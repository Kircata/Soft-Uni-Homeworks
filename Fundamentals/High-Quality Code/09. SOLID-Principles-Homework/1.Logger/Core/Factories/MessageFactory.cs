namespace _1.Logger.Core.Factories
{
    using System;
    using _1.Logger.Enums;
    using _1.Logger.Interfaces;
    using _1.Logger.Models;

    public static class MessageFactory
    {
        public static IMessage CreateMessage(DateTime date, ReportLevel reportLevel, string messageText)
        {
            var message = new Message(date, reportLevel, messageText);

            return message;
        }
    }
}
