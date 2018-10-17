using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpUnitTestExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnString1GivenInteger1()
        {
            //Arrange
            int input = 1;
            string expected = "1";

            //Act
            string actual = FizzBuzzIt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnString2GivenInteger2()
        {
            //Arrange
            int input = 2;
            string expected = "2";

            //Act
            string actual = FizzBuzzIt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ShouldReturnStringFizzGivenInteger3()
        {
            //Arrange
            int input = 3;
            string expected = "Fizz";

            //Act
            string actual = FizzBuzzIt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private string FizzBuzzIt(int toFizzBuzz)
        {
            return toFizzBuzz.ToString();
        }
    }
}
