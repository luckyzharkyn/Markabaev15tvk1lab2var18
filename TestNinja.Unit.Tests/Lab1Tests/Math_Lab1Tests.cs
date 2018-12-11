using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.Lab1Tests
{
    //var18
    [TestClass]
    public class Math_Lab1Tests
    {
        [TestMethod]
        public void SumDivisibleBy11_IsArgumentsAandB_ReturnsTrue()
        {
            //Arrange
            var math_Lab1 = new Math_Lab1();

            //Act
            var result = math_Lab1.IsSumDivisibleBy11(0,11);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SumDivisibleBy11_IsArgumentsAandB_ReturnsFalse()
        {
            //Arrange
            var math_Lab1 = new Math_Lab1();

            //Act
            var result = math_Lab1.IsSumDivisibleBy11(5,6);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
