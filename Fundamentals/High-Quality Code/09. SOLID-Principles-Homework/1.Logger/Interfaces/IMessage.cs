namespace _1.Logger.Interfaces
{
    using System;
    using _1.Logger.Enums;

    public interface IMessage
    {
        DateTime Date { get; }

        ReportLevel ReportLevel { get; }

        string MessageText { get; }
    }
}
