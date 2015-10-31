using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class JoinLists
    {
        static void Main()
        {
            Console.Write("Enter the first list of integers(separated by space): ");
            string numbersInFirstList = Console.ReadLine().Trim();
            List<int> firstListOfNumbers = numbersInFirstList.Split(' ').Select(int.Parse).ToList();

            Console.Write("Enter the second list of integers(separated by space): ");
            string numbersInSecondList = Console.ReadLine().Trim();
            List<int> secondListOfNumbers = numbersInSecondList.Split(' ').Select(int.Parse).ToList();
            
            List<int> mergedList = new List<int> { };
            mergedList.AddRange(firstListOfNumbers);
            mergedList.AddRange(secondListOfNumbers);

            mergedList.Sort();

            for (int index = 0; index < mergedList.Count - 1; index++)
            {
                
                    if (mergedList[index] == mergedList[index + 1])
                    {
                        mergedList.Remove(mergedList[index + 1]);
                        index--;
                    }
             
            }


            foreach (var item in mergedList)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }

