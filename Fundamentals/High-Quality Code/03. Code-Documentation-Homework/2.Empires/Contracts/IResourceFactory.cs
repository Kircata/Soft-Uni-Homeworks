namespace _1.Empires.Contracts
{
    using Enums;

    /// <summary>
    /// A factory that can create a resource based on 
    /// a given type and quantity
    /// </summary>
    /// <see cref="ResourceType"/>
    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
