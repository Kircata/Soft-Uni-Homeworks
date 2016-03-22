using System;
using System.Text;
namespace LaptopShop.Classes
{
    class Laptop
    {
        //Field
        private string model;
        private decimal price;
        private Battery battery;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private readonly string separator = new string('-', 25);

        //Constructors
        public Laptop(string model,string manufacturer,string processor,int ram,string graphicsCard,string hdd,string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = battery;
            this.Price = price;
        }
        public Laptop(string model, string screen, Battery battery, decimal price)
            : this(model, null, null, 0, null, null, screen, battery, price)
        {
        }
        public Laptop(string model, decimal price)
           : this(model, null, null, price)
        {
        }

        //Properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.processor = value;
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The ram cannot be a negative number.");
                }
                this.ram = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.graphicsCard = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value?.Trim().Length == 0)
                {
                    throw new ArgumentException("The string cannot be empty.");
                }
                this.screen = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price cannot be a negative number.");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine();
            result.AppendLine("               Laptop                 ");
            result.AppendLine($"|{"model",-15}||{this.Model,-60}|");
            result.AppendLine($"|{"manufacturer",-15}||{this.Manufacturer ?? "[no manucaturer]",-60}|");
            result.AppendLine($"|{"processor",-15}||{this.Processor ?? "[no processor]",-60}|");
            if (this.Ram == 0)
            {
                result.AppendLine($"|{"RAM",-15}||{"[no RAM]",-60}|");
            }
            else
            {
                result.AppendLine($"|{"RAM",-15}||{this.Ram + "GB",-60}|");
            }
            result.AppendLine($"|{"graphics card",-15}||{this.GraphicsCard ?? "[no graphics card]",-60}|");
            result.AppendLine($"|{"HDD",-15}||{this.Hdd ?? "[no hdd]",-60}|");
            result.AppendLine($"|{"screen",-15}||{this.Screen ?? "[no screen]",-60}|");
            if (this.battery != null)
            {
                result.AppendLine($"|{"battery info",-15}||{this.battery,-60}|");
            }
            else
            {
                result.AppendLine($"|{"battery info",-15}||{"[no battery]",-60}|");
            }
            result.AppendLine($"|{"price",-15}||{this.Price + "lv.",-60}|");
            return result.ToString();
        }

    }
}
