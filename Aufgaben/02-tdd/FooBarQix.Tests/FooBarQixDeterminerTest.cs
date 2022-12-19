using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public async void TestNumberCanBeDividedByThree()
        {
            //Arrange
            int numb = 3;
            string expected = "Foo";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async void TestNumberCanBeDividedByFive()
        {
            //Arrange
            int numb = 5;
            string expected = "Bar";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async void TestNumberCanBeDividedBySeven()
        {
            //Arrange
            int numb = 7;
            string expected = "Qix";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async void TestNumberCanBeDividedByThreeAndFive()
        {
            //Arrange
            int numb = 15;
            string expected = "FooBar";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async void TestNumberCanBeDividedByThreeAndSeven()
        {
            //Arrange
            int numb = 21;
            string expected = "FooQix";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public async void TestNumberCanBeDividedByThreeFiveAndSeven()
        {
            //Arrange
            int numb = 105;
            string expected = "FooBarQix";

            //Act
            string actual = FooBarQixDeterminer.Determine(numb);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
