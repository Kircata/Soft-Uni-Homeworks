namespace _1.Logger.Models.Layouts
{
    using _1.Logger.Interfaces;

    public class SimpleLayout : LayoutBase
    {
        public override string Format(IMessage msgToFormat)
        {
            var formattedMessage = $"{msgToFormat.Date} - {msgToFormat.ReportLevel} - {msgToFormat.MessageText}";

            return formattedMessage;
        }
    }
}
