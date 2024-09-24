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
    //public static class ArrayExtensions<T> where T : struct
    //{
    //    public static int CountMatch(this T[] A, T item)
    //    {
    //        int counter = 0;
    //            for (int i = 0; i < A.Length; i++)
    //            {
    //                if (A[i] == item)
    //                    counter++;
    //            }
    //        return counter;
    //    }
    //}
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.GetEncoding(1251);
            //Console.OutputEncoding = Encoding.GetEncoding(1251);

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

            A.ReverseA();

            Console.WriteLine("\nМасив A в зворотньому порядку: ");
            foreach (string i in A)
            {
                Console.WriteLine(i);
            }

            char c = 't';
            Console.WriteLine($"\nКiлькiсть входжень символу '{c }' = {A.CountChar(c)}");
            
        }
    }
}
