using DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void Subject_Returns_Message()
        {
            // Arrange
            ISubject subject = new Subject();
            var expected = "message";
            // Act
            var actual = subject.GetMessage();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subject_Returns_DecoratorMessage()
        {
            // Arrange
            ISubject subject = new Subject();
            ISubject decorator = new Decorator(subject);
            var expected = "decorator message";
            // Act
            var actual = decorator.GetMessage();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
