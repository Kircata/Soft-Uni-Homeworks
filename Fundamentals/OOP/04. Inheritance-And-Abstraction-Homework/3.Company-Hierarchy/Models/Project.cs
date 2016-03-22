namespace _3.Company_Hierarchy
{
    using System;
    class Project
    {
        public Project(string name, DateTime? start, string details, bool isOpen)
        {
            this.Name = name;
            this.StartDate = start;
            this.Details = details;
            this.IsOpen = isOpen;
        }
        public string Name { get; set; }
        public bool IsOpen { get; set; }
        public string Details { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
