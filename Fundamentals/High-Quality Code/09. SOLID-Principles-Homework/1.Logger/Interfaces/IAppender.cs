namespace _1.Logger.Interfaces
{
    using _1.Logger.Enums;

    public interface IAppender
    {
        ReportLevel ReportLevel { get; }

        void Append(IMessage message);
    }
}
