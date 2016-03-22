namespace _3.Company_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee
    {
        private List<Employee> employees; 
        public Manager(uint id, string firstName, string lastName, decimal salary, DepartamentType departament)
            : base(id,firstName,lastName,salary,departament)
        {
            this.employees = new List<Employee>();
        }

        public IEnumerable<Employee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null.");
            }
            if (employee.Departament != this.Departament)
            {
                throw new ArgumentException("Departament of employee and manager must be the same.");
            }
            employees.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"ID: {this.Id}\nFirst name: {this.FirstName}||Last name:{this.LastName}\nDepartament type: {this.Departament}");
            output.AppendLine("Employees:");
            foreach (Employee employee in this.Employees)
            {
                output.AppendLine($"ID: {employee.Id} First name: {employee.FirstName} Last name: {employee.LastName}");
            }
            return output.ToString();
        }
    }
}
