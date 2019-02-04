using FactoryMethodPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FactoryMethodPatternTests
    {
        [TestMethod]
        public void Factory_Creates_Subject1()
        {
            // Arrange
            IFactory factory = new Factory();
            // Act
            var subject = factory.GetSubject("subject1");
            // Assert
            Assert.IsInstanceOfType(subject, typeof(Subject1));
        }

        [TestMethod]
        public void Factory_Creates_Subject2()
        {
            // Arrange
            IFactory factory = new Factory();
            // Act
            var subject = factory.GetSubject("subject2");
            // Assert
            Assert.IsInstanceOfType(subject, typeof(Subject2));
        }
    }
}
