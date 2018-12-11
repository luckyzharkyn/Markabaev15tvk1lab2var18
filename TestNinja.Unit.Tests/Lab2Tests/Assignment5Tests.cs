using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment5;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class Assigment5Tests
    {
        [Test]
        [TestCase(0, "sd")]
        [TestCase(1, "")]
        [TestCase(0, "")]
        public void Log_InvalidError_ThrowArgumentNullException(int id, string name)
        {
            /// Act
            var logger = new Assignment5();

            /// Assert
            Assert.That(() => logger.EntranceToUniver(id, name), Throws.ArgumentNullException);

        }
    }
}
