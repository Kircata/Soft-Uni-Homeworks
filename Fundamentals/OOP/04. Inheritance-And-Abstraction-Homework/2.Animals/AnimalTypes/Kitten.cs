namespace _2.Animals.AnimalTypes
{

    class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
            :base(name,age,gender)
        {           
        }

        public override string ProduceSound()
        {
            return "Kitten said: Meow!";
        }
    }
}
