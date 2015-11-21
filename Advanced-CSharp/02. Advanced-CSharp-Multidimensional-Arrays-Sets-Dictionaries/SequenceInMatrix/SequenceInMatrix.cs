using System;
using System.Linq;
using System.Collections.Generic;
class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter the dimensions separated by space: ");
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[,] stringMatrix = new string[dimensions[0], dimensions[1]];
        Console.WriteLine("Enter the elements in each row of the matrix separated by space: ");
        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            string[] rowOfStrings = Console.ReadLine().Split().ToArray();
            for (int col = 0; col < stringMatrix.GetLength(1); col++)
            {
                stringMatrix[row, col] = rowOfStrings[col];
            }
        }

        List<string> sequence = new List<string> {};
        List<string> longestSequence = new List<string> { };
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                //row check
                sequence.Add(stringMatrix[row, col]);
                for (int currentRow = row +1; currentRow < 3; currentRow++)
                {
                    if (stringMatrix[currentRow,col] == sequence[0])
                    {
                        sequence.Add(stringMatrix[currentRow, col]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(sequence);
                }
                sequence.Clear();
                //column check
                sequence.Add(stringMatrix[row, col]);
                for (int currentColumn = col+1; currentColumn < 3; currentColumn++)
                {
                    if (stringMatrix[row, currentColumn] == sequence[0])
                    {
                        sequence.Add(stringMatrix[row, currentColumn]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(sequence);
                }
                sequence.Clear();
                //diagonal check
                sequence.Add(stringMatrix[row, col]);
                for (int addend = row+1;  row + addend < 3 && col + addend < 3; addend++)
                {
                    if (sequence[0] == stringMatrix[row + addend, col + addend])
                    {
                        sequence.Add(stringMatrix[row + addend, col + addend]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(sequence);
                }
                sequence.Clear();
            }
        }
        Console.WriteLine("The longest sequence is: ");
        Console.WriteLine("{0}", string.Join(", ", longestSequence));
    }
}

