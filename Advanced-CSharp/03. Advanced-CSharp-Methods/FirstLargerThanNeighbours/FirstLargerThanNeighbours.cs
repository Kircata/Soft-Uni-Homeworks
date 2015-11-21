using System;
using System.Linq;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("The index of the first element that is larger than it's neightbours is: {0}", IndexOfElement(numbersArr));
    }
    static int IndexOfElement(int[] numbersArray)
    {
        int indexOfElement = -1;
        for (int index = 0; index < numbersArray.Length; index++)
        {
            bool isLarger = false;
            if (index == 0)
            {
                isLarger = numbersArray[index] > numbersArray[index + 1] ? true : false;
            }
            else if (index == numbersArray.Length - 1)
            {
                isLarger = numbersArray[index] > numbersArray[index - 1] ? true : false;
            }
            else
            {
                isLarger = (numbersArray[index] > numbersArray[index - 1])
                    && (numbersArray[index] > numbersArray[index + 1]) ? true : false;
            }
            if (isLarger)
            {
                indexOfElement = index;
                break;
            }
        }
        return indexOfElement;
    }
}

