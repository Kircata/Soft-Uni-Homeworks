namespace _1.Shapes.Shapes
{
    using Interfaces;
    using System;
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius cannot be a negative number.");
                }
                this.radius = value;
            }
        }


        public double CalculateArea()
        {
            return Math.Pow(this.Radius, 2) * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
