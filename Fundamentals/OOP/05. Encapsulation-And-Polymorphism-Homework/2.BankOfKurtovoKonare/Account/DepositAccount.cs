namespace _2.BankOfKurtovoKonare.Account
{
    using Interfaces;
    using System;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer,balance,interestRate)
        {
        }

        public void Withdraw(decimal sum)
        {
            if (sum > this.Balance)
            {
                throw new ArgumentException("The withdrawn money cannot be a higher number than the balance.");
            }
            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return this.Balance;
            }

            return base.CalculateInterest(months);
        }
    }
}
