using FacadePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FacadePatternTests
    {
        [TestMethod]
        public void Facade_Works_Correctly()
        {
            // Arrange
            var subsystemA = new SubsystemA();
            var subsystemB = new SubsystemB();
            var facade = new Facade();
            var expectedOperation1 = "a: operation1" + Environment.NewLine + "b: operation1" + Environment.NewLine;
            var expectedOperation2 = "a: operation2" + Environment.NewLine + "b: operation2" + Environment.NewLine;
            // Act
            var actualOperation1 = subsystemA.Operation1() + subsystemB.Operation1();
            var actualOperation2 = subsystemA.Operation2() + subsystemB.Operation2();
            var actualFacadeOperation1 = facade.Operation1();
            var actualFacadeOperation2 = facade.Operation2();
            // Assert
            Assert.AreEqual(expectedOperation1, actualOperation1);
            Assert.AreEqual(expectedOperation2, actualOperation2);
            Assert.AreEqual(expectedOperation1, actualFacadeOperation1);
            Assert.AreEqual(expectedOperation2, actualFacadeOperation2);
        }
    }
}
