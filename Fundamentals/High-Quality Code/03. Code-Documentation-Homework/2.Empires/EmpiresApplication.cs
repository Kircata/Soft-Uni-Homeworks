namespace _1.Empires
{
    using Core;
    using IO;
    using Core.Factories;

    class EmpiresApplication
    {
        static void Main()
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new EmpiresData();

            var engine = new Engine(buildingFactory,resourceFactory,unitFactory,data,reader,writer);
            engine.Run();
        }
    }
}
