namespace _1.Empires.Models
{
    using Contracts;
    using Enums;

    public class Resource : IResource
    {
        public Resource(ResourceType resourceType, int quantity)
        {
            this.ResourceType = resourceType;
            this.Quantity = quantity;
        }

        public ResourceType ResourceType { get; }
        public int Quantity { get; }
    }
}
