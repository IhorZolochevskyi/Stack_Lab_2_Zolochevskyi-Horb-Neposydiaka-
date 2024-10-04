using Xunit;
using Lab_2;
using ClassLib_team2;

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
        public void Reverse_ReversesArrayCorrectly()
        {
            string[] array = { "element1", "element2", "element3" };
            string[] expected = { "element3", "element2", "element1" };

            array.Reverse();

            Assert.Equal(expected, array);
        }

        [Fact]
        public void CountChar_CountsCharactersCorrectly()
        {
            string[] array = { "car", "bike", "truck" };
            char character = 'r';
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
            int[] array = { 2, 0, 5, 3, 5 };
            int item = 5;
            int expectedCount = 2;

            int result = array.CountMatch(item);

            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void DelSame_RemovesDuplicateElements()
        {
            int[] array = { 0, 9, 8, 8, 7 };
            int[] expected = { 0, 9, 8, 7 };

            int[] result = array.DelSame();

            Assert.Equal(expected, result);
        }
    }
    public class CarTests
    {
        [Fact]
        public void Car_Constructor_SetsPropertiesCorrectly()
        {
            var car = new Car(220, "Black", "Toyota", 7);

            Assert.Equal(220, car.TopSpeed);
            Assert.Equal("Black", car.Color);
            Assert.Equal("Toyota", car.Manufacturer);
            Assert.Equal(7, car.PassangerAmount);
        }

        [Fact]
        public void Car_ToString_ReturnsCorrectFormat()
        {
            var car = new Car(220, "Black", "Toyota", 7);
            string expected = "Car Manufacturer: Toyota\n Max Speed: 220\n Color: Black\n Passengers: 7";

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
            string expected = "Name: Product A\n Description: Description A\n Amount: 100";

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