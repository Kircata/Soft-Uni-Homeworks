namespace _2.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        ICustomer Customer { get; }
        decimal Balance { get; }
        double InterestRate { get; }
        decimal CalculateInterest(int months);
    }
}
