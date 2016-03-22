using System;
namespace LaptopShop.Classes
{
    class Battery
    {
        //Field
        private string info;
        private decimal life;

        //Constructor
        public Battery(string name, decimal price)
        {
            this.Info = name;
            this.Life = price;
        }

        //Properties
        public string Info
        {
            get { return this.info;  }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery's info cannot be null or blank.");
                }
                this.info = value;
            }
        }
        public decimal Life
        {
            get { return this.life; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery life cannot be a negative number.");
                }
                this.life = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}; {1} hours", this.info, this.life);
        }
    }

}
