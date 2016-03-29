namespace Exceptions_Homework.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exams;

    public class Student
    {
        private string firstName;
        private string lastName;

        public Student(string firstName, string lastName, List<Exam> exams)
        {
            if (lastName == null)
            {
                Console.WriteLine("Invalid first name!");
                Environment.Exit(0);
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public IList<Exam> Exams { get; }

        public IList<ExamResult> GetExamResults()
        {
            var examResults = this.Exams.Select(exam => exam.CreateExamResult()).ToList();

            return examResults;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("The number of exams should be more than zero!");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = GetExamResults();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] = 
                    ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}
