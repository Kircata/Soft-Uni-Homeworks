using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RemoveNames
    {
        static void Main()
        {
            Console.Write("Enter the names in the first list(separated by space): ");
            string firstListCount = Console.ReadLine().Trim();
            List <string> firstListOfNames = firstListCount.Split(' ').ToList();

            Console.Write("Enter the names in the second list(separated by space): ");
            string secondListCount = Console.ReadLine().Trim();
            List<string> secondListOfNames = secondListCount.Split(' ').ToList();

            List<string> outputList = new List<string> {};
            outputList.AddRange(firstListOfNames);

            for (int i = 0; i < firstListOfNames.Count; i++)
            {

                for (int j = 0; j < secondListOfNames.Count; j++)
                {

                    if (firstListOfNames[i] == secondListOfNames[j])
                    {

                        outputList.Remove(firstListOfNames[i]);
                        break;
                    }
                  
                }
           
            }
            foreach (var name in outputList)
            {
                Console.Write("{0} ", name);
            }
            Console.WriteLine();
        }
    }

