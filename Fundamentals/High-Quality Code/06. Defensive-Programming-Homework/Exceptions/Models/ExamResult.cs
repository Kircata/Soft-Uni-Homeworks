using System;

namespace Exceptions_Homework.Models
{
    public class ExamResult
    {
        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("grade", "A grade cannot fall below zero!");
                }

                this.grade = value;
            }    
        }

        public int MinGrade
        {
            get { return this.minGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("minGrade", "A grade cannot fall below zero!");
                }

                this.minGrade = value;
            }
        }

        public int MaxGrade
        {
            get { return this.maxGrade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("maxGrade", "A grade cannot fall below zero!");
                }

                this.maxGrade = value;
            }
        }

        public string Comments
        {
            get { return this.comments; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The comments section cannot be null or empty");
                }

                this.comments = value;
            }
        }
    }
}
