using System.Xml.Linq;

namespace ClassLib
{
    public class Car
    {
            public int topSpeed;
            public string color;
            public string manufacturer;
            public int passangerAmount;

        public int TopSpeed
        {
            get { return topSpeed; }
            set { topSpeed = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public int PassangerAmount
        {
            get { return passangerAmount; }
            set { passangerAmount = value; }
        }

        public Car(int TopSpeed, string Color, string Manufacturer, int PassangerAmount)
        {
            topSpeed = TopSpeed;
            color = Color;
            manufacturer = Manufacturer;
            passangerAmount = PassangerAmount;
        }
    }
}
