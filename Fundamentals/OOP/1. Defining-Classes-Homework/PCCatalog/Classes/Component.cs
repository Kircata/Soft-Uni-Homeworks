using System;
using System.Text;
namespace PCCatalog.Classes
{
    class Component
    {
        //Field
        private string name;
        private string detail;
        private decimal price;

        //Constructors
        public Component(string name, string detail, decimal price)
        {
            this.Name = name;
            this.Detail = detail;
            this.Price = price;
        }
        public Component(string name, decimal price) 
            : this(name,null,price)
        {
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("The name of the component shouldn't be null or an empty string.");
                }
                this.name = value;
            }
        }
        public string Detail
        {
            get { return this.detail; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException("The detail cannot be blank.");
                }
                this.detail = value;
            }
        } 
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be below 0.");
                }
                this.price = value;
            }
        }

        //ToString()
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";
            output.AppendLine(seperator);
            if (this.Detail != null)
            {
                output.AppendLine($"|{"component name",15}|{this.Name + " (" + this.Detail + ")",35}|");
            }
            else
            {
                output.AppendLine($"|{"component name",15}|{this.Name,35}|");
            }

            output.AppendLine($"|{"",15}|{this.Price,35:C}|");
            return output.ToString();
        }
    }
}
