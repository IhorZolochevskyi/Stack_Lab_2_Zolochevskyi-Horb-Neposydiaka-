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
            // Используем HashSet для хранения уникальных значений
            HashSet<T> uniqueItems = new HashSet<T>();

            // Добавляем элементы в HashSet (дубликаты автоматически игнорируются)
            for (int i = 0; i < A.Length; i++)
            {
                T item = A[i];
                uniqueItems.Add(item);
            }

            // Преобразуем HashSet обратно в массив
            return uniqueItems.ToArray();
        }
    }
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.GetEncoding(1251);
            //Console.OutputEncoding = Encoding.GetEncoding(1251);

            Car car = new Car(123, "жовтий", "audi", 5); 

            String[] A= { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };

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
        }
    }
}
