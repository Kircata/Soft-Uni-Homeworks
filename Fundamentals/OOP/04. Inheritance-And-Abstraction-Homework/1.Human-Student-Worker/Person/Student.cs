namespace _1.Human_Student_Worker.Person
{
    using System;
    class Student : Human
    {
        //Field
        private const int FacultyNumberMinLength= 5;
        private const int FacultyNumberMaxLength = 10;
        private string facultyNumber;

        //Constructor
        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        //Property
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < FacultyNumberMinLength || value.Length > FacultyNumberMaxLength)
                {
                    throw new ArgumentException("The faculty number should have a length between 5 and 10 characters");
                }
                this.facultyNumber = value;
            }
        }
    }
}
