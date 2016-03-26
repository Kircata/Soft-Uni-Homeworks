namespace _1.Empires.Models.Units
{
    public class Archer : Unit
    {
        private const int DefaultDamage = 7;
        private const int DefaultHealth = 25;

        public Archer() 
            : base(DefaultDamage, DefaultHealth)
        {
        }
    }
}
