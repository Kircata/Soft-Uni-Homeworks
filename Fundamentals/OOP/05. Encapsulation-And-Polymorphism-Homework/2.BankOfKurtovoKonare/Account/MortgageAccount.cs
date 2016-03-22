namespace _2.BankOfKurtovoKonare.Account
{
    using Interfaces;

    public class MortgageAccount : Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer,balance,interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months <= this.Customer.MortgageRateMinDuritation)
            {
                return base.CalculateInterest(months/2);
            }
            return base.CalculateInterest(months);
        }
    }
}
