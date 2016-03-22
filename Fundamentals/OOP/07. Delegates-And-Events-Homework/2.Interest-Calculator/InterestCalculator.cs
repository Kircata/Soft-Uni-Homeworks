namespace _2.Interest_Calculator
{
    using System.Text;

    public class InterestCalculator
    {
        private readonly CalculateInterest interestCalculationDelegate;
        public InterestCalculator(double money, double interest, int years, CalculateInterest interestCalculationDelegate, string type)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.interestCalculationDelegate = interestCalculationDelegate;
            this.Type = type;
        }

        public double Money { get; set; }
        public double Interest { get; set; }
        public int Years { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(this.Type.ToUpper() + ":");
            output.AppendFormat("Money: {0}\nInterest: {1}\nYears: {2}\nResult: {3:F4}\n", this.Money, this.Interest,
                this.Years, this.interestCalculationDelegate(this.Money,this.Interest,this.Years));
            return output.ToString();
        }
    }
}
