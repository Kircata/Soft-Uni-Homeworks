namespace Abstraction.Contracts
{
    /// <summary>
    /// An object that is a figure
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Calculates the perimeter of a figure
        /// </summary>
        /// <returns> The perimeter </returns>
        double CalcPerimeter();

        /// <summary>
        /// Calculates the surface/area of a figure
        /// </summary>
        /// <returns> The perimeter </returns>
        double CalcSurface();
    }
}
