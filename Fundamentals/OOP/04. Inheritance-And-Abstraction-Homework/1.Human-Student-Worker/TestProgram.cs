namespace _1.Human_Student_Worker
{
    using Person;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TestProgram
    {
        static void Main()
        {
            //Initializing a list of students and printing them on the console.
            List<Student> students = new List<Student>()
            {
                { new Student("Petar", "Petrov", "55545gf") },
                { new Student("Kiril", "Kirilov","fdsf1") },
                { new Student("Ivan","Ivanov","43225dfg14") },
                { new Student("Georgi","Georgiev","477dffz4") },
                { new Student("Lepa","Brena","4322g1") },
                { new Student("Svetlin","Nakov","25dfg14") },
                { new Student("Ivo","Cenov","3225dfg1") },
                { new Student("Veselin","Minev","6573246") },
                { new Student("Rosi","Karaliiska","1546455") },
                { new Student("Emilia","Cvetanova","sgfg3425") },

            };
            Console.WriteLine("Ordered students by faculty number in ascending order.");
            foreach (Student student in students.OrderBy(s => s.FacultyNumber.Length))
            {
                Console.WriteLine("First name: {0}\nLast name: {1}\nFaculty number: {2}{3}"
                    ,student.FirstName
                    ,student.LastName
                    ,student.FacultyNumber
                    ,Environment.NewLine);
            }
            Console.WriteLine("------------------------------------------------------------------");
            //Initializing a list of workers and printing them on the console.
            List<Worker> workers = new List<Worker>()
            {
                { new Worker("Valentin","Vitkov",34.252m,2) },
                { new Worker("Vladi","Kirilova",432.12m,7) },
                { new Worker("Iliqn","Dimitrov",77.345m,8) },
                { new Worker("Manol","Cvetanov",123.22m,11) },
                { new Worker("Bobi","Efremov",44.324m,4) },
                { new Worker("Nikolay","Tenev",325m,8) },
                { new Worker("Mariya","Andonova",555.435m,13) },
                { new Worker("Neno","Yurukov",277,9) },
                { new Worker("Martina","Totina",333.66m,14) },
                { new Worker("Svetoslav","Mitsev",117.543m,7) },
            };
            Console.WriteLine("Ordered workers by money made per hour in descending order.");
            foreach (Worker worker in workers.OrderByDescending(w1 => w1.MoneyPerHour()))
            {
                Console.WriteLine("First name: {0}\nLast name: {1}\nMoney made per hour: {2:F2}{3}"
                    , worker.FirstName
                    , worker.LastName
                    , worker.MoneyPerHour()
                    , Environment.NewLine); 

            }
            //Merging list of students and workers and printing it on the console.
            Console.WriteLine("------------------------------------------------------------------");
            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            Console.WriteLine("Ordered humans by first and last name.");
            foreach (Human human in mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName))
            {
                Console.WriteLine("First name: {0}||Last name: {1}{2}"
                    ,human.FirstName
                    ,human.LastName
                    ,Environment.NewLine);
            }
        }
    }
}
