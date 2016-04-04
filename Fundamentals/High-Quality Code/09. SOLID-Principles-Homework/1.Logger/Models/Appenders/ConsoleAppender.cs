namespace _1.Logger.Models.Appenders
{
    using System;
    using _1.Logger.Interfaces;

    public class ConsoleAppender : AppenderBase
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(IMessage message)
        {
            if (message.ReportLevel >= this.ReportLevel)
            {
                var formattedMsg = this.Layout.Format(message);

                Console.WriteLine(formattedMsg);
            }
        }
    }
}
