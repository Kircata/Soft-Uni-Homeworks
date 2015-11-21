using System;
using System.Linq;
class LargerThanNeightbours
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by space: ");
        int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int index = 0; index < numbersArr.Length; index++)
        {
            Console.WriteLine(IsLargerThanNeightbours(numbersArr, index));
        }
    }
    static bool IsLargerThanNeightbours(int[] numbersArr, int index)
    {
        bool isLarger = false;
        if (index == 0)
        {
            isLarger = numbersArr[index] > numbersArr[index + 1] ? true : false;
        }
        else if (index == numbersArr.Length -1)
        {
            isLarger = numbersArr[index] > numbersArr[index-1] ? true : false;

        }
        else
        {
            isLarger = (numbersArr[index] > numbersArr[index - 1])
                && (numbersArr[index] > numbersArr[index + 1]) ? true : false;
        }
        return isLarger;
    }
}

