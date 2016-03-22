namespace _3.Company_Hierarchy
{
    using System;
    public abstract class Employee : Person
    {
        private decimal salary;
        protected Employee(uint id, string firstName, string lastName, decimal salary, DepartamentType departament)
            : base(id,firstName,lastName)
        {
            this.Salary = salary;
            this.Departament = departament;
        }

        public DepartamentType Departament { get; set; }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary shouldn't be a negative number.");
                }
                this.salary = value;
            }
        }
    }
}
