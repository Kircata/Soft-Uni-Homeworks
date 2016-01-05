using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PCCatalog.Classes
{
    class Computer
    {
        // Field
        private string name;
        private List<Component> components;

        //Constructors
        public Computer(string name, params Component[] pcComponents)
        {
            this.name = name;
            this.AddComponentsToList(pcComponents);
        }

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException("The computers name cannot be blank.");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.components.Sum(component => component.Price);
            }
        }

        //Add the user input components to the list
        private void AddComponentsToList(Component[] pcComponents)
        {
            this.components = new List<Component>();
            foreach (var component in pcComponents)
            {
                this.components.Add(component);
            }
        }

        // Overriding ToString() method
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string seperator = "+" + new string('-', 15) + "+" + new string('-', 35) + "+";

            output.AppendLine(seperator);
            output.AppendLine($"|{"pc name",15}|{this.Name,35}|");

            foreach (var component in this.components)
            {
                output.Append(component);
            }
            output.AppendLine(seperator);
            output.AppendLine($"|{"total price",15}|{this.Price,35:c}|");
            output.AppendLine(seperator);

            return output.ToString();
        }
    }
}
