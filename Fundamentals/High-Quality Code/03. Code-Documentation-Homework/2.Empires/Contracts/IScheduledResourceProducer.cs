namespace _1.Empires.Contracts
{
    public interface IScheduledResourceProducer : IResourceProducer
    {
        bool CanProduceResource { get; }
    }
}
