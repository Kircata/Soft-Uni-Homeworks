namespace _1.Shapes.Shapes
{
    using System;
    public class Rhombus : BasicShape
    {
        private double side;
        private double height;

        public Rhombus(double side, double height)
        {
            this.Side = side;
            this.Height = height;
        }

        public double Side
        {
            get { return this.side; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The side cannot be a negative number.");
                }
                this.side = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be a negative number.");
                }
                this.height = value;
            }
        }



        public override double CalculateArea()
        {
            return this.Side * this.Height;
        }
        public override double CalculatePerimeter()
        {
            return this.Side * 4;
        }
    }
}
