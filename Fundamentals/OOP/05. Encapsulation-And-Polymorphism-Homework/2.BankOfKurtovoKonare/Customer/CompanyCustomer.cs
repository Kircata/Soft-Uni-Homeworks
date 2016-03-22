namespace _2.BankOfKurtovoKonare.Customer
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name) 
            : base(name)
        {
            this.DepositRateMinDuritation = 2;
            this.MortgageRateMinDuritation = 12;
        }


    }
}
