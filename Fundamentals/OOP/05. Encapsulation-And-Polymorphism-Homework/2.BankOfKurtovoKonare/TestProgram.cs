namespace _2.BankOfKurtovoKonare
{
    using System;
    using Account;
    using Customer;
    using Interfaces;

    class TestProgram
    {
        static void Main()
        {
            ICustomer[] clients =
            {
                new IndividualCustomer("Kiril"),
                new IndividualCustomer("Nakov"),
                new CompanyCustomer("SoftUni"),
            };

            DepositAccount kirilDepositAccount = new DepositAccount(clients[0],888.354m,55);
            MortgageAccount nakovMortgageAccount = new MortgageAccount(clients[1],3415.77m,12);
            LoanAccount softUniLoanAccount = new LoanAccount(clients[2],56756.789m,3);

            kirilDepositAccount.Withdraw(123.77m);
            nakovMortgageAccount.Deposit(124.55m);
            softUniLoanAccount.Deposit(1779.33m);

            // Try false input
            try
            {
                kirilDepositAccount.Withdraw(1000m);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(kirilDepositAccount);
            Console.WriteLine(nakovMortgageAccount);
            Console.WriteLine(softUniLoanAccount + $"\nInterest rate: {softUniLoanAccount.CalculateInterest(3)}");

        }
    }
}
