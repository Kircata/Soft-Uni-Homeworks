namespace _1.ReformatCode
{
    using System;
    using System.Text;

    public class Event
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);

            int  byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                return byTitle;
            }

            return byDate;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            output.Append(" | " + title);

            if (!string.IsNullOrEmpty(location))
            {
                output.Append(" | " + location);
            }

            return output.ToString();
        }
    }
}
