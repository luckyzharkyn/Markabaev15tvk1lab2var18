using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    //var18
    [TestFixture]
    public class MathLab1Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Math_Lab1 _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math_Lab1();
        }

        [Test]
        [TestCase(0, 11, true)]
        [TestCase(6, 5, false)]
        //[ErrorTests]
        //[TestCase(0, 11, false))]
        //[TestCase(6, 5, true))]

        public void SumDivisibleBy11_WhenCalled_ReturnTheGreatherArgument(int a, int b, bool expectedResult)
        {
            //Act
            var result = _math.IsSumDivisibleBy11(a, b);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
