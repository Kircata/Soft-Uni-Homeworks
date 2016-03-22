using PCCatalog.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
namespace PCCatalog
{
    class PCCatalogMain
    {
        static void Main(string[] args)
        {
            Component vga = new Component("Nvidia 660X", "Mnogo e gotina brat", 550.43M);
            Component ram = new Component("Ram", "vurvi si kato pushka", 157.33M);
            Component motherboard = new Component("Asus", "super e", 548.7634M);
            Component cpu = new Component("Inteli7", "golqm bokluk", 99999999.999999M);

            List<Computer> computersInStore = new List<Computer>()
            {
                new Computer("Dell", vga, ram),
                new Computer("Jar Computer", vga, motherboard),
                new Computer("Apple", cpu, ram),
                new Computer("Lenovo", motherboard, cpu)
            };

            computersInStore
                .OrderBy(computer => computer.Price)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
