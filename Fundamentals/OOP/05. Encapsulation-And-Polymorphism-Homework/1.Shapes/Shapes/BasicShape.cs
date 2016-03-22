namespace _1.Shapes.Shapes
{
    using Interfaces;
    public abstract class BasicShape : IShape
    {

        public virtual double CalculateArea()
        {
            return 0.00;        
        }
        public virtual double CalculatePerimeter()
        {
            return 0.00;
        }
    }
}
