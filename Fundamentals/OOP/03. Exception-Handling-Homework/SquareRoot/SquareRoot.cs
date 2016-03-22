using System;
namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine(squareRoot);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");            
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
