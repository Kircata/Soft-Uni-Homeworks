namespace _1.Human_Student_Worker.Person
{
    using System;
    class Worker : Human
    {
        //Field
        private decimal weekSalary;
        private int workHoursPerDay;
        private const decimal weeklyWorkDays = 5;

        //Constructor
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //Properties
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The weekly salary shouldn't be a negative number");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day shouldn't be a negative number.");
                }
                this.workHoursPerDay = value;
            }
        }

        //Method
        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / weeklyWorkDays) / (decimal)this.WorkHoursPerDay;
        }
    }
}
