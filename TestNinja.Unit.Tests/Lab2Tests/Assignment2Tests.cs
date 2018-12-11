using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class Assigment2Tests
    {
        // Setup
        private Assignment2 _assignment2;

        [SetUp]
        public void SetUp()
        {
            _assignment2 = new Assignment2();
        }

        // Tests
        [Test]
        public void PowerOfNumber_ReturnTheGreatherArgument()
        {
            // Act
            var result = _assignment2.GetNumbersDivedBy100(325);

            /// Assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(3));
            Assert.That(result, Does.Contain(100));
            Assert.That(result, Does.Contain(200));
            Assert.That(result, Does.Contain(300));
            Assert.That(result, Is.EquivalentTo(new[] {100, 200,300}));
        }
    }
}
