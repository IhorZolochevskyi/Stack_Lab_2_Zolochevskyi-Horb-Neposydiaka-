using Xunit;
using Lab_2;
using ClassLib;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }
    public class StringArrayExtensionTests
    {
        [Fact]
        public void ReverseA_ReversesArrayCorrectly()
        {
            string[] array = { "first", "second", "third" };
            string[] expected = { "third", "second", "first" };

            array.ReverseA();

            Assert.Equal(expected, array);
        }

        [Fact]
        public void CountChar_CountsCharactersCorrectly()
        {
            string[] array = { "first", "second", "third" };
            char character = 'i';
            int expectedCount = 2;

            int result = array.CountChar(character);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void FindStringsContainingDigits_FindsStringsWithDigits()
        {
            string[] array = { "noDigits", "has123", "456here", "none" };
            string[] expected = { "has123", "456here" };

            string[] result = array.FindStringsContainingDigits();

            Assert.Equal(expected, result);
        }
    }
    public class ArrayExtensionsTests
    {
        [Fact]
        public void CountMatch_CountsMatchingElementsCorrectly()
        {
            int[] array = { 1, 2, 2, 3, 4 };
            int item = 2;
            int expectedCount = 2;

            int result = array.CountMatch(item);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void DelSame_RemovesDuplicateElements()
        {
            int[] array = { 1, 2, 2, 3, 4 };
            int[] expected = { 1, 2, 3, 4 };

            int[] result = array.DelSame();

            Assert.Equal(expected, result);
        }
    }
    public class CarTests
    {
        [Fact]
        public void Car_Constructor_SetsPropertiesCorrectly()
        {
            var car = new Car(250, "Red", "Audi", 4);

            Assert.Equal(250, car.TopSpeed);
            Assert.Equal("Red", car.Color);
            Assert.Equal("Audi", car.Manufacturer);
            Assert.Equal(4, car.PassangerAmount);
        }

        [Fact]
        public void Car_ToString_ReturnsCorrectFormat()
        {
            var car = new Car(250, "Red", "Audi", 4);
            string expected = "Марка: Audi\n Макс.шв.: 250\n Колiр: Red\n Кiлькiсть пасажирiв: 4";

            string result = car.ToString();

            Assert.Equal(expected, result);
        }
    }
    public class ProductTests
    {
        [Fact]
        public void Product_Constructor_SetsPropertiesCorrectly()
        {
            var product = new Product("Product A", "Description A", 100);

            Assert.Equal("Product A", product.Name);
            Assert.Equal("Description A", product.Description);
            Assert.Equal(100, product.Amount);
        }

        [Fact]
        public void Product_ToString_ReturnsCorrectFormat()
        {
            var product = new Product("Product A", "Description A", 100);
            string expected = "Назва: Product A\n Опис: Description A\n Кiлькiсть: 100";

            string result = product.ToString();

            Assert.Equal(expected, result);
        }
    }
    public class ExtendedDictionaryTests
    {
        [Fact]
        public void Add_AddsElementCorrectly()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "First", 1.1);

            Assert.True(dictionary.ContainsKey(1));
        }

        [Fact]
        public void Remove_RemovesElementCorrectly()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "First", 1.1);
            bool removed = dictionary.Remove(1);

            Assert.True(removed);
            Assert.False(dictionary.ContainsKey(1));
        }

        [Fact]
        public void Indexer_ReturnsCorrectElement()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "First", 1.1);

            var element = dictionary[1];

            Assert.Equal("First", element.FirstValue);
            Assert.Equal(1.1, element.SecondValue);
        }

        [Fact]
        public void ContainsValue_ReturnsTrueForMatchingElement()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "First", 1.1);

            bool contains = dictionary.ContainsValue("First", 1.1);

            Assert.True(contains);
        }
    }
}