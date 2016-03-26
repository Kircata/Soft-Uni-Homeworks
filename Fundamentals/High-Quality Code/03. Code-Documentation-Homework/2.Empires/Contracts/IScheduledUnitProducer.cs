namespace _1.Empires.Contracts
{
    public interface IScheduledUnitProducer : IUnitProducer
    {
        bool CanProduceUnit { get; }
    }
}
