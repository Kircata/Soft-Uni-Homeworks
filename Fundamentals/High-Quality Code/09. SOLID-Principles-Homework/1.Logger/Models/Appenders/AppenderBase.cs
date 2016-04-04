namespace _1.Logger.Models.Appenders
{
    using System;
    using _1.Logger.Enums;
    using _1.Logger.Interfaces;

    public abstract class AppenderBase : IAppender
    {
        private ILayout layout;

        protected AppenderBase(ILayout layout)
        {
            this.layout = layout;
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The layout cannot be null.");
                }

                this.layout = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(IMessage message);
    }
}
