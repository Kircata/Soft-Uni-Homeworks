namespace _2.BankOfKurtovoKonare.Account
{
    using Interfaces;
    using System;

    public abstract class Account : IAccount, IDeposit
    {
        private decimal balance;

        protected Account(ICustomer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance cannot be a negative number.");
                }
                this.balance = value;
            }
        }
        public double InterestRate { get; }
        public ICustomer Customer { get; }
        public void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentOutOfRangeException("Sum cannot be zero or a negative number.");
            }
            this.Balance += sum;
        }


        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (1 + (decimal)(this.InterestRate * months));
        }

        public override string ToString()
        {
            return $"{this.Customer.Name} Ballance: {this.Balance:C}";
        }
    }
}
