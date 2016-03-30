namespace _3.CompareSortingAlgorithms
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    public class Application
    {
        public static void Main()
        {
            int[] numbers = GenerateRandomNums(10);
            int[] oldNumbers = new int[numbers.Length];
            Array.Copy(numbers, oldNumbers, numbers.Length);

            Console.WriteLine("Insertion sort:");
            SortingAlgorithms.InsertionSort(numbers);
            Array.Copy(oldNumbers, numbers, oldNumbers.Length);

            Console.WriteLine("Selection sort:");
            SortingAlgorithms.SelectionSort(numbers);
            Array.Copy(oldNumbers, numbers, oldNumbers.Length);
        }

        private static int[] GenerateRandomNums(int length)
        {
            int[] nums = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                nums[i] = rnd.Next(-1000, 1000);
            }

            return nums;
        }
    }
}
