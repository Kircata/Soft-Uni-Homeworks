namespace CohesionAndCoupling.Models
{
    using Contracts;

    public class Figure : IFigure
    {
        public Figure(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
    }
}
