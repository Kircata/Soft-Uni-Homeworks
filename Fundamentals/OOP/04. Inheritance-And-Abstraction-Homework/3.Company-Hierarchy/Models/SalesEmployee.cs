namespace _3.Company_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales;
        public SalesEmployee(uint id, string firstName, string lastName
            , decimal salary, DepartamentType departament )
            : base(id,firstName,lastName,salary,departament)
        {
            this.sales = new List<Sale>();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"ID: {this.Id} First name: {this.FirstName} Last name: {this.LastName}\nSalary: {this.Salary} Departament: {this.Departament}");
            output.AppendLine("Sales:");
            foreach  (Sale sale in this.sales)
            {
                output.AppendLine($"Product name: {sale.ProductName} Date sold on: {sale.SoldOn} Product price: {sale.Price}");
            }
            return output.ToString();
        }
    }
}
