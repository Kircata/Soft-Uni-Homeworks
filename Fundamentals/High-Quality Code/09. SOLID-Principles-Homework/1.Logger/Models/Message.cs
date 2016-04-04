namespace _1.Logger.Models
{
    using System;
    using _1.Logger.Enums;
    using _1.Logger.Interfaces;

    public class Message : IMessage
    {
        private string messageText;

        public Message(DateTime date, ReportLevel reportLevel, string messageText)
        {
            this.Date = date;
            this.ReportLevel = reportLevel;
            this.MessageText = messageText;
        }

        public DateTime Date { get; }

        public ReportLevel ReportLevel { get; }

        public string MessageText
        {
            get
            {
                return this.messageText;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("The message text shouldn't be null or empty.");
                }

                this.messageText = value;
            }
        }
    }
}
