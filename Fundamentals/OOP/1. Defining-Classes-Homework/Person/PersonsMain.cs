using System;
namespace Person
{
    class PersonsMain
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 17);
            Person gosho = new Person("Gosho", 17, "goshopi4a@abv.bg");
            Console.WriteLine(pesho.ToString());
            Console.WriteLine(gosho.ToString());
        }
    }
}
