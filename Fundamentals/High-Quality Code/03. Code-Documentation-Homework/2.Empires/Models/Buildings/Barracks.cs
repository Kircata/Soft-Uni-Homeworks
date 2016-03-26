namespace _1.Empires.Models.Buildings
{
    using Contracts;
    using Enums;
    using static Enums.ResourceType;

    public class Barracks : Building
    {
        private const string BarracksUnitType = "Swordsman";
        private const int BarracksUnitCycleLength = 4;
        private const ResourceType BarracksResourceType = Steel;
        private const int BarracksResourceCycleLength = 3;
        private const int BarracksResourceCycleQuantity = 10;

        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory) 
            : base(BarracksUnitType,
                  BarracksUnitCycleLength,
                  BarracksResourceType,
                  BarracksResourceCycleLength,
                  BarracksResourceCycleQuantity,
                  unitFactory,
                  resourceFactory)
        {
        }
    }
}
