namespace Methods
{
    using System;

    class Application
    {

        public static void Main()
        {
            Console.WriteLine(MathUtils.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.FormatNumber(1.3, "f");
            Methods.FormatNumber(0.75, "%");
            Methods.FormatNumber(2.30, "r");

            Console.WriteLine(MathUtils.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + MathUtils.CheckIfHorizontal(-1, 2.5));
            Console.WriteLine("Vertical? " + MathUtils.CheckIfVertical(3, 3));

            Student peter = new Student
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            Student stella = new Student
            {
                FirstName = "Stella",
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
