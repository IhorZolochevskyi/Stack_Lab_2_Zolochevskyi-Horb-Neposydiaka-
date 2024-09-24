namespace ClassLib
{
     public class Product
        {
            public string name;
            public string description;
            public int amount;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Product()
        {
            name = Name;
            description = Description;
            amount = Amount;
        }
     }
}