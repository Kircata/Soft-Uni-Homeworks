namespace _3.GenericList
{
    using System;

    class TestProgram
    {
        static void Main()
        {
            CustomList<int> myList = new CustomList<int>();
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                myList.Add(rnd.Next());
            }
            Console.WriteLine("Pre-removal {0}",myList.Access(3));
            myList.Remove(3);
            Console.WriteLine("After removal: {0}",myList.Access(3));
            Console.WriteLine("Before inserting: {0}", myList.Access(7));
            myList.Insert(7,463645654);
            Console.WriteLine("After inserting : {0}", myList.Access(7));
            int fifthElement = myList.Access(5);
            Console.WriteLine("The index of the element is: {0}", myList.IndexOf(fifthElement));
            Console.WriteLine("The list contains 33: {0}", myList.Contains(33));
            Console.WriteLine("The smallest element in the list is: {0}", myList.Min());
            Console.WriteLine("The biggest element in the list is: {0}", myList.Max());
            Console.WriteLine(myList);
            myList.Clear();
        }
    }
}
