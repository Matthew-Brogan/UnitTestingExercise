using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(1,1,1,3)]
        [InlineData(5,5,5,15)]
        [InlineData(3,3,3,9)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,0)]
        [InlineData(10,5,5)]
        [InlineData(23,3,20)]
        [InlineData(-1,1,-2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.Subtraction(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2,0,0)]
        [InlineData(4,4,16)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.MultiplyEm(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,1)]
        [InlineData(12,6,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act

            var actual = sut.DivideEm(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SayHi()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();

            //Act
            var actual = sut.SayHello();
            //Assert
            Assert.Equal("Hello", actual);

        }

        [Fact]
        public void SayBye()
        {
            //Arrange
            UnitTestMethods sut = new UnitTestMethods();
            //Act
            var actual = sut.SayGoodBye();
            //Assert
            Assert.Equal("Bye!", actual);
        }
    }
}
