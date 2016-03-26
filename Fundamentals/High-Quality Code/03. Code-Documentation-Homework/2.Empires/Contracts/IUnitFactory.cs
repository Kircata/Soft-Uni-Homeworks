namespace _1.Empires.Contracts
{
    /// <summary>
    /// A factory that can create units based on a given type
    /// </summary>
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
