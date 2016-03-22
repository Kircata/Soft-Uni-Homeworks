namespace _2.Animals.AnimalTypes
{

    class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender)
            :base(name,age,gender)
        {           
        }

        public override string ProduceSound()
        {
            return "Tomcat said: Meow!";
        }
    }

}
