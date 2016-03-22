namespace _2.Animals
{
    using AnimalTypes;
    using System;
    using System.Linq;
    class TestProgram
    {
        static void Main()
        {
            Animal[] animalFarm = {new Dog("pes", 4,"male")
                    , new Frog("bezpolezen bokluk",2,"male")
                    , new Kitten("malcho",7,"female")
                    , new Tomcat("kalpazanin",1,"male")
                    , new Dog("ulichna prevuzhodna", 6, "female")
                    , new Frog("jaba kikirica", 10, "male")
                    , new Kitten("boksova krusha", 2,"male")
                    , new Tomcat("tommy", 4, "male")};
            foreach (Animal animal in animalFarm)
            {
                Console.WriteLine(animal);
            }
            var animalFarmAvg = animalFarm
                .GroupBy(x => x.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                }).ToList();
            animalFarmAvg.ForEach(group => Console.WriteLine($"{group.AnimalName}'s average age is: {group.AverageAge}"));
        }
    }
}
