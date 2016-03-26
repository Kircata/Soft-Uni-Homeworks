namespace _1.Empires.Models.Units
{
    public class Swordsman : Unit
    {
        private const int DefaultDamage = 13;
        private const int DefaultHealth = 40;

        public Swordsman() 
            :base(DefaultDamage, DefaultHealth)
        {
        }
    }
}
