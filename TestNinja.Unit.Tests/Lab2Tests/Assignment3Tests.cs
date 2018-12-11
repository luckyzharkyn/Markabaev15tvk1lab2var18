using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.Unit.Tests.Lab2Tests
{
    [TestFixture]
    public class Assigment3Tests
    {
        // Setup
        private Assignment3 _assignment3;

        [SetUp]
        public void SetUp()
        {
            _assignment3 = new Assignment3();
        }

        // Tests
        [Test]
        [TestCase(true)]
        public void OpenCabinet_IsBool_ReturnTrue(bool iskey)
        {
            // Act
            var result = _assignment3.OpenCabinet(iskey);

            /// Assert
            Assert.That(result, Is.TypeOf<OpenDoor>());
            Assert.That(result, Is.InstanceOf<OpenDoor>());
        }

        [Test]
        [TestCase(false)]
        public void OpenCabinet_IsBool_ReturnFalse(bool iskey)
        {
            // Act
            var result = _assignment3.OpenCabinet(iskey);

            /// Assert
            Assert.That(result, Is.TypeOf<ErrorNotKey>());
            Assert.That(result, Is.InstanceOf<ErrorNotKey>());
        }
    }
}
