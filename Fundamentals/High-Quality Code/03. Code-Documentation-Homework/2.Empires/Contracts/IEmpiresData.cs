namespace _1.Empires.Contracts
{
    using System.Collections.Generic;
    using Enums;

    /// <summary>
    /// The database of an empire that contains a collection of buildings, units
    /// and the ability to add more to the collection
    /// </summary>
    public interface IEmpiresData
    {
        IEnumerable<IBuilding> Buildings { get; }
        void AddBuilding(IBuilding building);
        IDictionary<string, int> Units { get; }
        void AddUnit(IUnit unit);
        IDictionary<ResourceType, int> Resources { get; }  
    }
}
