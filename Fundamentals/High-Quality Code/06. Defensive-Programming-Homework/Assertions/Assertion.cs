using System;
using System.Diagnostics;

namespace Assertions_Homework
{
    public static class Assertion
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            int indexToCheck = 0;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Debug.Assert(arr[i].CompareTo(arr[i + 1]) <= 0, "Sorting is not correct!");
            }
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            int searchedIndex = -1;
            int startIndex = 0;
            int endIndex = arr.Length - 1;
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    searchedIndex = midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            Debug.Assert(searchedIndex != -1, "Searched index not found");

            return searchedIndex;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) where T : IComparable<T>
        {
            int minElementIndex = startIndex;
            for (int index = startIndex + 1; index <= endIndex; index++)
            {
                if (arr[index].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = index;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
