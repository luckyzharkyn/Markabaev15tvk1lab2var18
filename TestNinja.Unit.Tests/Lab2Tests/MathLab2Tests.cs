using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class MathLab2Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Math_Lab2 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab2();
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        //[TestCase(2, 1, 1)]
        //[TestCase(1, 2, 1)]
        //[TestCase(1, 1, 2)]

        public void Max_WhenCalled_ReturnTheGreatherArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Max(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, 1, 6)]
        [TestCase(1, 5, 6)]
        //[TestCase(1, 1, 3)]
        //[TestCase(1, 1, -2)]
        public void Add_WhenCalled_ReturnTheGreatherArgument(int a, int b, int expectedResult)
        {
            //Act
            var result = _math.Add(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
