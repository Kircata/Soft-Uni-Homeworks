namespace Abstraction.Models
{
    using System;

    public class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;            
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height of the rectangle cannot be below or equal to zero", "height");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width of the rectangle cannot be below or equal to zero", "width");
                }

                this.width = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
