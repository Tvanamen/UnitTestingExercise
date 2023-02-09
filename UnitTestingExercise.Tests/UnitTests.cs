using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3,54,8,65)]
        [InlineData(9,32,10,51)]
        [InlineData(6,0,12,18)]
        [InlineData(12,19,13,44)]
        [InlineData(38,-1,14,51)]
        [InlineData(1,6,15,22)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Arrange
            // create a Calculator object
            var addition = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var addMath = addition.Add(num1,num2,num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, addMath);
        }

        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(3, 54, -51)]
        [InlineData(9, 32, -23 )]
        [InlineData(6, 0, 6)]
        [InlineData(12, 19, -7)]
        [InlineData(38, -1, 39)]
        [InlineData(1, 6, -5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtract = new Calculator();
            //Act
            var subtractMath = subtract.Subtract(minuend,subtrhend);
            //Assert
            Assert.Equal(expected, subtractMath);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(3, 54, 162)]
        [InlineData(9, 32, 288)]
        [InlineData(6, 0, 0)]
        [InlineData(12, 19, 228)]
        [InlineData(38, 1, 38)]
        [InlineData(10, 6, 60)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiply = new Calculator();
            //Act
            var multiplyMath = multiply.Multipy(num1,num2);
            //Assert
            Assert.Equal(expected, multiplyMath);
        }

        [Theory]
        [InlineData(2, 3, 1.5)]
        [InlineData(3, 54, 18)]
        [InlineData(9, 36, 4)]
        [InlineData(6, 2, 3)]
        [InlineData(20, 10, 2)]
        [InlineData(38, 1, 38)]
        [InlineData(1, 6, 6)]
        public void DivideTest(double num1, double num2, double expected)
        {
            //Arrange
            var divide = new Calculator();
            //Act
            var divideMath = divide.Divide(num1,num2);
            //Assert
            Assert.Equal(expected, divideMath);
        }

    }
}
