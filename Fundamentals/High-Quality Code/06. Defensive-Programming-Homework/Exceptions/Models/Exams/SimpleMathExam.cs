﻿using System;

namespace Exceptions_Homework.Models.Exams
{
    public class SimpleMathExam : Exam
    {
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get { return this.problemsSolved; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("problemsSolved", "The number of problems solved should be in the range of [0-10]!");
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult CreateExamResult()
        {
            switch (this.ProblemsSolved)
            {
                case 0: return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 1: return new ExamResult(4, 2, 6, "Average result: nothing done.");
                case 2: return new ExamResult(6, 2, 6, "Average result: nothing done.");
                default: 
                    throw new InvalidOperationException("Invalid number of problems solved!");
            }
        }
    }
}
