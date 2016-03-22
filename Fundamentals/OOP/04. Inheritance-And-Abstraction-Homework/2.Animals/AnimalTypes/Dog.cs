namespace _2.Animals.AnimalTypes
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            :base(name,age,gender)
        {         
        }

        public override string ProduceSound()
        {
            return "Bark!";
        }
    }
}
