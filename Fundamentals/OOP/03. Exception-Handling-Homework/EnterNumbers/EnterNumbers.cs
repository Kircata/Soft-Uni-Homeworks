using System;
namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            //Enter start
            int start = int.Parse(Console.ReadLine());
            //Enter end
            int end = int.Parse(Console.ReadLine());
            int count = 10;
            while (count > 0)
            {
                try
                {
                    ReadNumber(start, end);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The number you have entered is invalid\nTry again!");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine(string.Format("The number should be in range [{0}...{1}]", start, end));
                    Console.WriteLine("Try again!");
                    continue;
                }
                count--;
            }
        }
        public static void ReadNumber(int start, int end)
        {
            int num;
            try
            {
                  num = int.Parse(Console.ReadLine());
                  if (num <= start || num >= end)
                  {
                     throw new ArgumentOutOfRangeException();
                  }
            }
            catch (FormatException)
            {
                throw new FormatException();
            }

        }
    }
}
