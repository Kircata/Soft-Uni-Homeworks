using System;
using System.Linq;
namespace Person
{
    class Person
    {
        //Field
        private string name;
        private int age;
        private string email;

        //Constructors
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age) : this(name,age,null)
        {
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name shouldn't be an empty string or null.");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age should be in the range [0...100]");
                }
                this.age = value;
            }
        } 
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null || value.Contains('@'))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Email should be null and should contain @.");
                }
               
            }
        }

        // Overriding ToString()
        public override string ToString()
        {    
            return string.Format("Name: {0} Age: {1} Email: {2}", this.name, this.age, this.email ?? "[doesn't have an email]");
        }
    }
}
