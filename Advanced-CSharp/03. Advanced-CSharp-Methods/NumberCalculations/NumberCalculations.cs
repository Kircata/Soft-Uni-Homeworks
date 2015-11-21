using System;
using System.Linq;
class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter 3 sets of numbers: ");
        int[] setOfIntegerNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        double[] setOfDoubleNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
        decimal[] setOfDecimalNumbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        Console.WriteLine("Minimum of the 3 sets: ");
        Console.WriteLine(CalculateMinimum(setOfIntegerNumbers));
        Console.WriteLine(CalculateMinimum(setOfDoubleNumbers));
        Console.WriteLine(CalculateMinimum(setOfDecimalNumbers));
        Console.WriteLine("Maximim of the 3 sets: ");
        Console.WriteLine(CalculateMaximum(setOfIntegerNumbers));
        Console.WriteLine(CalculateMaximum(setOfDoubleNumbers));
        Console.WriteLine(CalculateMaximum(setOfDecimalNumbers));
        Console.WriteLine("Average of the 3 sets: ");
        Console.WriteLine(CalculateMean(setOfIntegerNumbers));
        Console.WriteLine(CalculateMean(setOfDoubleNumbers));
        Console.WriteLine(CalculateMean(setOfDecimalNumbers));
        Console.WriteLine("Sum of the 3 sets: ");
        Console.WriteLine(CalculateSum(setOfIntegerNumbers));
        Console.WriteLine(CalculateSum(setOfDoubleNumbers));
        Console.WriteLine(CalculateSum(setOfDecimalNumbers));
        Console.WriteLine("Product of 3 sets: ");
        Console.WriteLine(CalculateProduct(setOfIntegerNumbers));
        Console.WriteLine(CalculateProduct(setOfDoubleNumbers));
        Console.WriteLine(CalculateProduct(setOfDecimalNumbers));
    }
    static int CalculateMinimum(int[] intArr)
    {
        int min = int.MaxValue;
        for (int index = 0; index < intArr.Length; index++)
        {
            if (intArr[index] < min)
            {
                min = intArr[index];
            }
        }
        return min;
    }
    static double CalculateMinimum(double[] doubleArr)
    {
        double min = double.MaxValue;
        for (int index = 0; index < doubleArr.Length; index++)
        {
            if (doubleArr[index] < min)
            {
                min = doubleArr[index];
            }
        }
        return min;
    }
    static decimal CalculateMinimum(decimal[] decimalArr)
    {
        decimal min = decimal.MaxValue;
        for (int index = 0; index < decimalArr.Length; index++)
        {
            if (decimalArr[index] < min)
            {
                min = decimalArr[index];
            }
        }
        return min;
    }

    static int CalculateMaximum(int[] intArr)
    {
        int max = int.MinValue;
        for (int index = 0; index < intArr.Length; index++)
        {
            if (intArr[index] > max)
            {
                max = intArr[index];
            }
        }
        return max;
    }
    static double CalculateMaximum(double[] doubleArr)
    {
        double max = double.MinValue;
        for (int index = 0; index < doubleArr.Length; index++)
        {
            if (doubleArr[index] > max)
            {
                max = doubleArr[index];
            }
        }
        return max;
    }
    static decimal CalculateMaximum(decimal[] decimalArr)
    {
        decimal max = decimal.MinValue;
        for (int index = 0; index < decimalArr.Length; index++)
        {
            if (decimalArr[index] > max)
            {
                max = decimalArr[index];
            }
        }
        return max;
    }
    static int CalculateMean(int[] intArr)
    {
        int sum = 0;
        foreach (var number in intArr)
        {
            sum += number;
        }
        return sum / intArr.Length;
    }
    static double CalculateMean(double[] doubleArr)
    {
        double sum = 0;
        foreach (var number in doubleArr)
        {
            sum += number;
        }
        return sum / doubleArr.Length;
    }
    static decimal CalculateMean(decimal[] decimalArr)
    {
        decimal sum = 0;
        foreach (var number in decimalArr)
        {
            sum += number;
        }
        return sum / decimalArr.Length;
    }
    static int CalculateSum(int[] intArr)
    {
        int sum = 0;
        foreach (var number in intArr)
        {
            sum += number;
        }
        return sum;
    }
    static double CalculateSum(double[] doubleArr)
    {
        double sum = 0;
        foreach (var number in doubleArr)
        {
            sum += number;
        }
        return sum;
    }
    static decimal CalculateSum(decimal[] decimalArr)
    {
        decimal sum = 0;
        foreach (var number in decimalArr)
        {
            sum += number;
        }
        return sum;
    }
    static int CalculateProduct(int[] intArr)
    {
        int product = 1;
        foreach (var number in intArr)
        {
            product *= number;
        }
        return product;
    }
    static double CalculateProduct(double[] doubleArr)
    {
        double product = 1;
        foreach (var number in doubleArr)
        {
            product *= number;
        }
        return product;
    }
    static decimal CalculateProduct(decimal[] decimalArr)
    {
        decimal product = 1;
        foreach (var number in decimalArr)
        {
            product *= number;
        }
        return product;
    }

}

