using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class Assigment1Tests
    {
        // Setup
        private Assignment1 _assignment1;

        [SetUp]
        public void SetUp()
        {
            _assignment1 = new Assignment1();
        }

        // Tests
        [Test]
        [TestCase(5, 2, "25")]

        // Error Tests
        //[TestCase(5, "Monday", "day off")]
        public void PowerOfNumber_ReturnTheGreatherArgument(int number, int count, string expectedResult)
        {
            // Act
            var result = _assignment1.PowerOfNumber(number, count);

            /// Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
