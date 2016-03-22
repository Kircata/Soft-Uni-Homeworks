namespace _2.FractionCalculator.Exceptions
{
    using System;

    public class DenominatorCannotBeZeroException : Exception
    {
        private const string DeniminatorCannotBeZero = "The denominator cannot be zero.";

        public DenominatorCannotBeZeroException(string message = DeniminatorCannotBeZero)
           :base(message)
        {            
        }
    }
}
