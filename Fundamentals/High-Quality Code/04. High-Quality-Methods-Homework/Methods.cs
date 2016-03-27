namespace Methods
{
    using System;

    public static class Methods
    {
        /// <summary>
        /// Takes and integer between 0 and 9
        /// and returns it's english pronunciation 
        /// as a string
        /// </summary>
        /// <param name="number"> The number to convert </param>
        /// <returns> The converted string </returns>
        /// <exception cref="InvalidCastException">]
        /// In case <paramref name="number"/>
        /// is not between 0-9 or
        /// is not a number at all
        /// </exception>
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new InvalidCastException("The number should be between [0-9]");
            }
        }

        /// <summary>
        /// Finds and returns the biggest number 
        /// from a given array of integers
        /// </summary>
        /// <param name="elements"> The array of integers </param>
        /// <returns> The biggest number </returns>
        /// <exception cref="ArgumentNullException">
        /// In case of and entered uninitialized array
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// In case of an entered empty array
        /// </exception>
        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The array should be initialized!");
            }

            if (elements.Length == 0)
            {
               throw new InvalidOperationException("Cannot find the max number of an empty array!"); 
            }

            int biggestNum = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > biggestNum)
                {
                    biggestNum = elements[i];
                }
            }

            return biggestNum;
        }


        /// <summary>
        /// Takes a number and prints 
        /// it with a given typeOfFormat
        /// </summary>
        /// <param name="number"> The number to format </param>
        /// <param name="typeOfFormat"> The type of format </param>
        public static void FormatNumber(double number, string typeOfFormat)
        {
            if (typeOfFormat == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (typeOfFormat == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (typeOfFormat == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
    }
}
