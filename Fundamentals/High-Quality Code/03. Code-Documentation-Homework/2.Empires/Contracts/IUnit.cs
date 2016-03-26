namespace _1.Empires.Contracts
{
    /// <summary>
    /// An object that can attack and get destroyed
    /// </summary>
    public interface IUnit : IAttacker, IDestroyable
    {
    }
}
