using System;

namespace _1.Empires.Core.Factories
{

    using Contracts;
    using Models.Buildings;


    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                case "barracks":
                    return new Barracks(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Unknown building type.");
            }
        }
    }
}
