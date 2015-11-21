using System;
using System.Collections.Generic;
using System.Linq;
namespace FunctionalProgrammingHomework
{
    class FunctionalProgrammingHomework
    {
        static void LineBetweenProblems()
        {
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
        }
        static List<Students> StudentGenerator()
        {
            // PROBLEM 1:
            // Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks. 
            return new List<Students>()
        {
                new Students { firstName = "Kiril", lastName = "Kirilov", age = 17, facultyNumber = "2341234", phoneNumber = "0895964686", email = "kironakumura@abv.bg",groupNumber = 2 , groupName = "Medium",marks = new List<int>{ 4, 5, 6, 5 }},
            new Students { firstName = "Dimitar", lastName = "Petrov", age = 14, facultyNumber = "4235623", phoneNumber = "0885334616", email = "mitko_picha@gmail.com", groupNumber = 4,groupName = "Weak",  marks = new List<int>{ 6, 2, 2, 2 } },
                new Students { firstName = "Veselin", lastName = "Minev", age = 18, facultyNumber = "3315329", phoneNumber = "0873102777", email = "veskoMinev@abv.bg", groupNumber = 8,groupName = "Excellent", marks = new List<int>{ 6, 6, 5, 6 } },
                new Students { firstName = "Maria", lastName = "Ivanova", age = 16, facultyNumber = "5561907", phoneNumber = "0895673356", email = "mimi_iv@nov@abv.bg", groupNumber = 1,groupName = "Medium", marks = new List<int>{ 6, 4, 5, 5 } },
                new Students { firstName = "Svetla", lastName = "Vasileva", age = 17, facultyNumber = "2223179", phoneNumber = "0884453680", email = "svetla_Vasileva123@gamail.com", groupNumber = 2,groupName = "Medium", marks = new List<int>{ 6, 6, 2, 2 } }
            };
        }
        static List<Specialties> Specialties()
        {
            return new List<Specialties>()
        {
               new Specialties{ specialtyName = "Web Developer", facultyNumber = "2341234"},
               new Specialties{ specialtyName = "Web Developer", facultyNumber = "4235623"},
               new Specialties{ specialtyName = "Web Developer", facultyNumber = "3315329"},
               new Specialties{ specialtyName = "QA Engineer", facultyNumber = "3315329"},
               new Specialties{ specialtyName = "QA Engineer", facultyNumber = "5561907"},
               new Specialties{ specialtyName = "PHP Developer", facultyNumber = "2223179"},
               new Specialties{ specialtyName = "PHP Developer", facultyNumber = "5561907"},
        };
        }
        static void PrintingFirstAndLastName(IEnumerable<Students> students, string typeOfQuery)
        {
            Console.WriteLine(typeOfQuery);
            foreach (var student in students)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
            LineBetweenProblems();

        }

        static void Main()
        {
            List<Students> students = StudentGenerator();
            // PROBLEM 2 
            // Print all students from group number 2. Use a LINQ query. Order the students by FirstName.

            var groupTwo =
                students
                .Where(group => group.groupNumber == 2)
                .OrderBy(firstname => firstname.firstName);
            PrintingFirstAndLastName(groupTwo, "Students from group Two: ");


            // Problem 3
            // Print all students whose first name is before their last name alphabetically. Use a LINQ query.

            var firstNameBeforeLastNameAlphabetically =
                from student in students
                where student.firstName.First() < student.lastName.First()
                select student;


            PrintingFirstAndLastName(firstNameBeforeLastNameAlphabetically, "Students whose first name is before their last name alphabetically: ");

            // Problem 4
            // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.

            Console.WriteLine("All students with age between 18 and 24:");
            students
            .Where(age => age.age <= 24 && age.age >= 18)
            .Select(student => new Students() { firstName = student.firstName, lastName = student.lastName, age = student.age })
            .ToList()
            .ForEach(student => Console.WriteLine(student.firstName + " " + student.lastName + " " + student.age));

            LineBetweenProblems();

            // Problem 5
            // Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.

            var descendingOrderLambda =
                students
                .OrderByDescending(student => student.firstName)
                .ThenByDescending(student => student.lastName);
            PrintingFirstAndLastName(descendingOrderLambda, "Names in descending order with lambda expression: ");


            var descendingOrdeLinq =
                from student in students
                orderby student.firstName, student.lastName descending
                select student;
            PrintingFirstAndLastName(descendingOrdeLinq, "Names in descending order with Linq expression: ");

            // Problem 6
            // Print all students that have email @abv.bg. Use LINQ.

            var abvEmailList =
                from student in students
                where student.email.Contains("@abv.bg")
                select student;

            Console.WriteLine("Students with abv email: ");
            foreach (var student in abvEmailList)
            {
                Console.WriteLine("{0} {1} - {2}", student.firstName, student.lastName, student.email);
            }
            LineBetweenProblems();

            // Problem 7
            // Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            var telephoneNumberQuery =
                from student in students
                where student.phoneNumber.StartsWith("02") | student.phoneNumber.StartsWith("+3592") | student.phoneNumber.StartsWith("+359 2")
                select student;

            Console.WriteLine("Students with telephone number starting with 02: ");
            foreach (var student in telephoneNumberQuery)
            {
                Console.WriteLine("{0} {1} - {2}", student.firstName, student.lastName, student.phoneNumber);
            }
            LineBetweenProblems();

            // Problem 8 
            // Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            var excellentStudents =
                from student in students
                where student.marks.Contains(6)
                select (new { FullName = student.firstName + " " + student.lastName, Marks = student.marks });
            Console.WriteLine("Students with excellent grade: ");
            foreach (var student in excellentStudents)
            {

                Console.WriteLine(student.FullName);
            }
            LineBetweenProblems();
            // Problem 9
            // Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.

            students.WeakMarks();
            LineBetweenProblems();

            // Problem 12.
            // Create a class StudentSpecialty that holds specialty name and faculty number. Create a list of student specialties, where each specialty corresponds to a certain student (via the faculty number). Print all student names alphabetically along with their faculty number and specialty name. Use the "join" LINQ operator. Example:

            List<Specialties> specialties = Specialties();

            var specialtiesOfStudents =
                from specialty in specialties
                join student in students on specialty.facultyNumber equals student.facultyNumber
                orderby student.firstName
                select new { Student = student.firstName + " " + student.lastName, FacultyNum = student.facultyNumber, SpecialtyName = specialty.specialtyName };

            Console.WriteLine("{0} {1, 18} {2, 12}", "Name:", "FacNum:", "Specialty:");
            foreach (var student in specialtiesOfStudents)
            {
                Console.WriteLine("{0} - {1, -5} - {2, -15}", student.Student, student.FacultyNum, student.SpecialtyName);
            }
        }
    }
}

