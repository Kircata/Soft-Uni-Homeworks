namespace _2.FractionCalculator
{
    using Exceptions;

    public struct Fraction
    {
        private long numerator;
        private long denominator;
        

        public Fraction(long numerator, long denominator)
            :this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get { return this.numerator; }
            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new DenominatorCannotBeZeroException();
                }
                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            long num = (fr1.Numerator * fr2.Denominator) 
                + (fr2.Numerator * fr1.Denominator);
            long denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            long num = (fr1.Numerator * fr2.Denominator)
                - (fr2.Numerator * fr1.Denominator);
            long denom = fr1.Denominator * fr2.Denominator;
            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }

    }
}
