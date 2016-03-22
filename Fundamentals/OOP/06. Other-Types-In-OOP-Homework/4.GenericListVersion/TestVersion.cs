namespace _4.GenericListVersion
{
    using System;
    using _3.GenericList;

    class TestVersion
    {
        static void Main()
        {
            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hello SoftUni!");
            Console.WriteLine(secondList.Verstion());
        }
    }
}
