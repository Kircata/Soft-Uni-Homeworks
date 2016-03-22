namespace _1.Shapes
{
    using Shapes;
    using System;

    class TestProgram
    {
        private static readonly string line = "--------------------------------";
        static void Main()
        {
            BasicShape[] basicShapes =
            {
                new Rectangle(5,4.33),
                new Rhombus(9,33.76),
                new Rectangle(55,43.123),
                new Rhombus(154.44, 3215.44),
                new Rectangle(1,1),
                new Rhombus(55,55.5555)
            };

            Circle[] circles =
            {
                new Circle(7),
                new Circle(12),
                new Circle(315.779)
            };

            foreach (BasicShape shape in basicShapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(line);
            }
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle.CalculateArea());
                Console.WriteLine(circle.CalculatePerimeter());
                Console.WriteLine(line);
            }
        }
    }
}
