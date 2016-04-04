namespace _1.Logger.Models.Layouts
{
    using _1.Logger.Interfaces;

    public abstract class LayoutBase : ILayout
    {
        public abstract string Format(IMessage msgToFormat);
    }
}
