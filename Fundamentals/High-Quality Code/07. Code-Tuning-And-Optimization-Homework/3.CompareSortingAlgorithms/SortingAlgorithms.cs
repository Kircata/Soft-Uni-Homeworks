namespace _3.CompareSortingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SortingAlgorithms
    {
        public static void InsertionSort(int[] arr)
        {
            for (int index = 1; index < arr.Length; index++)
            {
                int currentElement = arr[index];
                int currentIndex = index - 1;
                do
                {
                    if (currentElement < arr[currentIndex])
                    {
                        int oldValue = arr[currentIndex];
                        arr[currentIndex] = currentElement;
                        arr[currentIndex + 1] = oldValue;
                    }
                    else
                    {
                        break;
                    }
                    currentIndex--;
                } while (currentIndex >= 0);
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int indexToPutIn = 0; indexToPutIn < arr.Length - 1; indexToPutIn++)
            {
                int smallestElement = int.MaxValue;
                int index = 0;
                for (int i = 0 + indexToPutIn; i < arr.Length; i++)
                {
                    int currentElement = arr[i];
                    if (currentElement < smallestElement)
                    {
                        smallestElement = currentElement;
                        index = i;
                    }
                }

                int oldValue = arr[indexToPutIn];
                arr[indexToPutIn] = smallestElement;
                arr[index] = oldValue;
            }
        }

    }
}
