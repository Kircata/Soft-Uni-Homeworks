using System;
    class BankAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Marshall";
            string middleName = "Bruce";
            string lastName = "Mathers";
            decimal availableMoney = 2129790m;
            string balance = String.Format("The Balance is: {0:C}", availableMoney);
            string bankName = "DSK";
            string IBAN = "BG" + 32 + 5000 + 4294967295;
            string creditcardNum = "Card Num1:2425135663858924\nCard Num2:4532345523145674\nCard Num3:2314098706549323";
            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Middle name: {0}",middleName);
            Console.WriteLine("Last name: {0}",lastName);
            Console.WriteLine(balance);
            Console.WriteLine("Bank: {0}",bankName);
            Console.WriteLine("IBAN: {0}",IBAN);
            Console.WriteLine("Credit card numbers:\n{0}",creditcardNum);
        }
    }

