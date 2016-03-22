using _2.Animals.Interfaces;

namespace _2.Animals.AnimalTypes
{

    abstract class Animal : ISoundProducible
    {
        //Field
        private string name;
        private int age;
        private string gender;

        //Constructor
        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
      
        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"I'm a {this.GetType().Name} and my name is {this.Name}, {ProduceSound()}";
        }
    }
}
