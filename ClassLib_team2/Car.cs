using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLib_team2
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
        public override string ToString()
        {
            return $"Марка: {Manufacturer}\n Макс.шв.: {TopSpeed}\n Колiр: {Color}\n Кiлькiсть пасажирiв: {PassangerAmount}";
        }
    }
}
