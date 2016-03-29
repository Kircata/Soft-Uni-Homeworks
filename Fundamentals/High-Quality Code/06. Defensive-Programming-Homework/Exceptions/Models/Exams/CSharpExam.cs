using System;

namespace Exceptions_Homework.Models.Exams
{
    public class CSharpExam : Exam
    {
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get { return this.score; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("score", "The score cannot be below zero or above onve hundred!");
                }

                this.score = value;
            }
        }

        public override ExamResult CreateExamResult()
        {
            ExamResult examResult = new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");

            return examResult;
        }
    }
}
