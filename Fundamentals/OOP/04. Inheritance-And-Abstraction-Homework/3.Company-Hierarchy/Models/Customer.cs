namespace _3.Company_Hierarchy
{
    using System;
    using Interfaces;
    public class Customer : Person, ICustomer
    {
        private decimal balance;
        public Customer(uint id, string firstName, string lastName, decimal balance)
            : base(id,firstName,lastName)
        {
            this.Balance = balance;
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance shouldn't be a negative number.");
                }
                this.balance = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\nFirst name: {this.FirstName}||Last name:{this.LastName}\nBalance: {this.Balance}";
        }
    }
}
