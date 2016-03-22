namespace _1.Custom_LINQ_Extension_Methods
{
    using System;
    using System.Collections.Generic;

    class CustomLinqMain
    {
        static void Main()
        {
            List<int> nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //filters out even numbers returns the odd numbers
            var filteredCollection = nums.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));

            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
