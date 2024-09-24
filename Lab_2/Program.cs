using ClassLib;

namespace Lab_2
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            Car car = new Car(123, "жовтий", "audi", 5); 

            String[] A= { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };

            int[] B = { 2, -7, -10, 6, 7, 9, 3 };

            String[] C = { "Light Green", "Red", "Green", "Yellow", "Purple", "Dark Green", 
                "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };

            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };

            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            Console.WriteLine("Масив A в по порядку: ");
            foreach (string i in A)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i].Reverse());
            }

            Console.WriteLine("\nМасив A в зворотньому порядку: ");
            foreach (string i in A)
            {
                Console.WriteLine(i);
            }
        }
    }
}
