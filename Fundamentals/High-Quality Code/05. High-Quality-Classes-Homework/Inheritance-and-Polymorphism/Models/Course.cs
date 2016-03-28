namespace InheritanceAndPolymorphism.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Contracts;

    public abstract class Course : ICourse
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        protected Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                throw new ArgumentException("The list of students is empty.");
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            result.Append(" }");

            return result.ToString();
        }
    }
}
