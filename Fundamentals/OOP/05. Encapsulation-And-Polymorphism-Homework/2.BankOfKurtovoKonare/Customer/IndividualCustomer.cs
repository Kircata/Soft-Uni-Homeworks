namespace _2.BankOfKurtovoKonare.Customer
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name) 
            : base(name)
        {
            this.DepositRateMinDuritation = 3;
            this.MortgageRateMinDuritation = 6;
        }
    }
}
