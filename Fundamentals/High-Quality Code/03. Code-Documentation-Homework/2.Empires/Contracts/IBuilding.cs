namespace _1.Empires.Contracts
{
    /// <summary>
    /// An object that can produce resources, units and update itself
    /// </summary>
    public interface IBuilding : IScheduledResourceProducer, IScheduledUnitProducer, IUpdateable
    {

    }
}
