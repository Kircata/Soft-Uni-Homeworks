namespace _2.BankOfKurtovoKonare.Customer
{
    using Interfaces;

    public abstract class Customer : ICustomer
    {
        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
        public int DepositRateMinDuritation { get; protected set; }
        public int MortgageRateMinDuritation { get; protected set; }
        public override string ToString() => this.Name;
    }
}
