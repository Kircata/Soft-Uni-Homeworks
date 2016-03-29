namespace Assertions_Homework
{
    using System;

    public class AssertionsExample
    {
        public static void Main()
        {
            int[] arrayOfNumbers = { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arrayOfNumbers));
            Assertion.SelectionSort(arrayOfNumbers);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arrayOfNumbers));

            Assertion.SelectionSort(new int[0]); // Test sorting empty array
            Assertion.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Assertion.BinarySearch(arrayOfNumbers, 0));
            Console.WriteLine(Assertion.BinarySearch(arrayOfNumbers, 17));
        }
    }
}
