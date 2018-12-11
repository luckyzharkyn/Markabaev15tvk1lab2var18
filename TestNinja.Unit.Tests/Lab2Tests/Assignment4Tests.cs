using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment4;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class Assigment4Tests
    {
        // Setup
        private Assignment4 _assignment4;

        [SetUp]
        public void SetUp()
        {
            _assignment4 = new Assignment4();
        }

        // Tests
        [Test]
        public void GetFullName_IsNameSurname_ReturnIsEquaToFullName()
        {
            /// Act
            var result = new Assignment4();
            result.EntranceToUniver(1, "Arman");

            /// Assert
            Assert.That(result.SaveLastVisited, Is.EqualTo(1));

        }
    }
}
