using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public static class StringArrayExtension
    {
        public static void ReverseA(this string[] A)
        {
            for (int i = 0, j = A.Length - 1; i < j; i++, j--)
            {
                string t;
                t = A[i];
                A[i] = A[j];
                A[j] = t;
            }
        }
        public static int CountChar(this string[] A, char c)
        {
            int counter = 0;
            for (int j = 0; j < A.Length; j++)
            {
                for (int i = 0; i < A[j].Length; i++)
                {
                    if (A[j][i] == c)
                        counter++;
                }
            }
            return counter;
        }
        public static string[] FindStringsContainingDigits(this string[] A)
        {
            return A.Where(str => str.Any(char.IsDigit)).ToArray();
        }
    }
    public static class ArrayExtensions
    {
        public static int CountMatch<T>(this T[] A, T item)
        {
            int counter = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Equals(item))
                    counter++;
            }
            return counter;
        }
        public static T[] DelSame<T>(this T[] A)
        {
            HashSet<T> uniqueItems = new HashSet<T>();

            for (int i = 0; i < A.Length; i++)
            {
                T item = A[i];
                uniqueItems.Add(item);
            }
            return uniqueItems.ToArray();
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.GetEncoding(1251);
            //Console.OutputEncoding = Encoding.GetEncoding(1251);

            Car[]car = new Car[5];
            car[0] = new Car(120, "Зелений", "Audi", 5);
            car[1] = new Car(157, "Червоний","Toyota",3);
            car[2] = new Car(250,"Зелений","Skoda",5);
            car[3] = new Car(210, "Чорний", "Renault", 7);
            car[4] = new Car(300, "Бiлий", "Zeekr", 2);

            Product[] products = new Product[5];
            products[0] = new Product("Портвейн 777","алкоголь",100);
            products[1] = new Product("Сухарики три корочки", "снек", 10);
            products[2] = new Product("Байкал", "напiток", 55);
            products[3] = new Product("Чамбо", "напiток", 44);
            products[4] = new Product("Мивина", "страва", 66);

            String[] A= { "Falluot", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };

            int[] B = { 2, -7, -10, 2, 7, 2, 3 };

            String[] C = { "Light Green", "Red", "Green", "Yellow", "Red", "Dark Green", 
                "Light Red", "Dark Red", "Dark Yellow", "Light Yellow" };

            List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };

            List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

            Console.WriteLine("Масив A в по порядку: ");
            foreach (string i in A)
            {
                Console.WriteLine(i);
            }

            A.ReverseA();

            Console.WriteLine("\nМасив A в зворотньому порядку: ");
            foreach (string i in A)
            {
                Console.WriteLine(i);
            }

            char c = 't';
            Console.WriteLine($"\nКiлькiсть входжень символу '{c }' = {A.CountChar(c)}");

            Console.WriteLine($"\nКiлькiсть входжень символу '{2}' = {B.CountMatch(2)}");

            Console.WriteLine($"\nКiлькiсть входжень символу Red = {C.CountMatch("Red")}");

            Console.WriteLine("Масив з унiкальних елементiв\n");
            foreach (var i in B.DelSame())
            {
                Console.WriteLine(i);
            }

            string[] stringsWithDigits = A.FindStringsContainingDigits();
            Console.WriteLine("\nСтроки, содержащие цифры:");
            foreach (var str in stringsWithDigits)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\n\n");

            var res = from n in B where n > 0 select n;
            foreach (int positive in res)
            {
                Console.WriteLine(positive);
            }

            Console.WriteLine("\n\n");
            string[] redColors = (from n in C where n.Contains("Red") select n).ToArray();
            foreach(var color in redColors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine("\n\n");

            var resCar = from n in car where n.TopSpeed > 200 select n;

            foreach (var res2 in resCar)
            {
                Console.WriteLine(res2.ToString());
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            var resProd = from n in products where n.Amount > 50 select n;

            foreach (var res3 in resProd)
            {
                Console.WriteLine(res3.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");

            var uniqueCars = myCars.Union(yourCars);

            Console.WriteLine("Уникальные машины:");
            foreach (var car321 in uniqueCars)
            {
                Console.WriteLine(car321);
            }

            var dictionary = new ExtendedDictionary<int, string, double>();

            dictionary.Add(1, "First", 1.1);
            dictionary.Add(2, "Second", 2.2);
            dictionary.Add(3, "Third", 3.3);

            dictionary.Remove(2);

            Console.WriteLine(dictionary.ContainsKey(2));

            Console.WriteLine(dictionary.ContainsValue("First", 1.1)); 

            var element = dictionary[1];
            Console.WriteLine(element); 

            foreach (var elem in dictionary)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine($"Count: {dictionary.Count}");
        }
    }
}
