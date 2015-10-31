namespace AgeAfterTenYears
{
    using System;

    class AgeInTenYearsCalculator
    {
        static void Main()
        {
            DateTime input = DateTime.Parse(Console.ReadLine());
            int birthYear = input.Year;
            int thisYear = DateTime.Now.Year;
            int currentAge = thisYear - birthYear;

            Console.WriteLine("Now: " + currentAge);
            Console.WriteLine("After 10 years: " + (currentAge + 10));
        }
    }
}
