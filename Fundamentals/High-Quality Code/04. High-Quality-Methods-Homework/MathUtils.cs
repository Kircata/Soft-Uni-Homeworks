namespace Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class MathUtils
    {
        /// <summary>
        /// Calculates the distance between two points
        /// in the coordinate system
        /// </summary>
        /// <param name="x1"> Point one X </param>
        /// <param name="y1"> Point one Y </param>
        /// <param name="x2"> Point two X </param>
        /// <param name="y2"> Point two Y </param>
        /// <returns> The calculated distance </returns>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new InvalidOperationException("All sides should be positive numbers");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        /// <summary>
        /// Calculates the distance between two points
        /// in the coordinate system
        /// </summary>
        /// <param name="x1"> Point one X </param>
        /// <param name="y1"> Point one Y </param>
        /// <param name="x2"> Point two X </param>
        /// <param name="y2"> Point two Y </param>
        /// <returns> The calculated distance </returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return distance;
        }

        public static bool CheckIfHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;

            return isHorizontal;
        }

        public static bool CheckIfVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;

            return isVertical;
        }
    }
}
