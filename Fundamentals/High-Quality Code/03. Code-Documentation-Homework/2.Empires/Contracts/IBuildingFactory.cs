namespace _1.Empires.Contracts
{
    /// <summary>
    /// A factory that can create a building based on 
    /// a given type, unit factory and resource factory
    /// </summary>
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}
