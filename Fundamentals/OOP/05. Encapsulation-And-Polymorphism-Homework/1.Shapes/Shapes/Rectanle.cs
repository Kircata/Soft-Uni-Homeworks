namespace _1.Shapes.Shapes
{
    using System;
    public class Rectangle : BasicShape
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The side cannot be a negative number.");
                }
                this.sideA = value;
            }
        }
        public double SideB
        {
            get { return this.sideB; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The side cannot be a negative number.");
                }
                this.sideB = value;
            }
        }


        public override double CalculateArea()
        {
            return this.SideA * this.SideB;
        }
        public override double CalculatePerimeter()
        {
            return (this.SideA * 2) + (this.SideB * 2);
        }
    }
}
