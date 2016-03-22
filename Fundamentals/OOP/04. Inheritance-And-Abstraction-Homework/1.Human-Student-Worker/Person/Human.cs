namespace _1.Human_Student_Worker.Person
{
    public abstract class Human
    {
        //Constructor
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //Properties
        public string FirstName { get; }
        public string LastName { get; }

    }
}
