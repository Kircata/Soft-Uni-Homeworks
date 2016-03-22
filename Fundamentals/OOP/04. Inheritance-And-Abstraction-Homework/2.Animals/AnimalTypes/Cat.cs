namespace _2.Animals.AnimalTypes
{
    abstract class Cat : Animal
    {
        protected Cat(string name, int age, string gender)
            :base(name,age,gender)
        {           
        }

        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
}
