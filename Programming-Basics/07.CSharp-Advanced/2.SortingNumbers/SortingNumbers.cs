using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingNumbers
{
    static void Main()
    {
        Console.Write("Enter the number count you want: ");
        int numCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numCount];
        int previousValue = 0;
        bool hasSwitched = false;
        Console.WriteLine("Enter the numbers you want to sort(separated by space):  ");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                previousValue = numbers[i];
                if (numbers[i] > numbers[i + 1])
                {
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = previousValue;
                    hasSwitched = true;
                }
            }
            if (hasSwitched == true)
            {
                hasSwitched = false;
                continue;
            }
            else
            {
                break;
            }

        }
        Console.WriteLine("The numbers sorted from the lowest to the highest: ");
        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine(numbers[j]);
        }

    }
}

