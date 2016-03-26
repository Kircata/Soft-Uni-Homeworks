namespace _1.Empires.Contracts
{
    using Enums;

    /// <summary>
    /// An object that has a type and a quantity
    /// </summary>
    /// <see cref="ResourceType"/>
    public interface IResource
    {
        ResourceType ResourceType { get; }
        int Quantity { get; }
    }
}
