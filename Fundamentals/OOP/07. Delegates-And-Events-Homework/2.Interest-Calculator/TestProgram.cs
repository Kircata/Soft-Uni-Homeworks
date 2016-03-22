namespace _2.Interest_Calculator
{
    using System;

    public delegate double CalculateInterest(double sumOfMoney, double interest, int years);
    class TestProgram
    {
        public static void Main()
        {
            CalculateInterest simpleInterestCalculationDelegate = GetSimpleInterest;
            CalculateInterest compoundInterestCalculationDelegate = GetCompoundInterest;
            InterestCalculator simpleCalc = new InterestCalculator(2500, 7.2, 15, simpleInterestCalculationDelegate,"simple");
            InterestCalculator compoundCalc = new InterestCalculator(500, 5.6, 10, compoundInterestCalculationDelegate,"compound");
            Console.WriteLine(simpleCalc);
            Console.WriteLine(compoundCalc);
        }

        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            return sum*(1 + (interest / 100)*years);
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            return sum * Math.Pow((1 + (interest / 100) / 12), 12 * years);
        }
    }
}
