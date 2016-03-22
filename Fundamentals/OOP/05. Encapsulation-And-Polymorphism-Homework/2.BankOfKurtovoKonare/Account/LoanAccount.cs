namespace _2.BankOfKurtovoKonare.Account
{
    using Interfaces;

    public class LoanAccount : Account
    {
        public LoanAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer,balance,interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= this.Customer.DepositRateMinDuritation)
            {
                return this.Balance;
            }

            return base.CalculateInterest(months - this.Customer.DepositRateMinDuritation);
        }
    }
}
