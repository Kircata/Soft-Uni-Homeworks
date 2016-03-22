namespace _1.GalacticGPS
{
    using System;
    using Models;

    class TestProgram
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
