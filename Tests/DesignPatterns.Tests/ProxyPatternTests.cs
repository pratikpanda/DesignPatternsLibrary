using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ProxyPatternTests
    {
        [TestMethod]
        public void Proxy_AllowAccess_GetsMessage()
        {
            // Arrange
            var subject = new Subject();
            var proxy = new Proxy(AccessTypes.AllowAccess);
            var expected = "message";
            // Act
            var actual = proxy.GetData();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Proxy_DenyAccess_ThrowsException()
        {
            // Arrange
            var subject = new Subject();
            var proxy = new Proxy(AccessTypes.DenyAccess);
            // Act / Assert
            Assert.ThrowsException<Exception>(() =>
            {
                proxy.GetData();
            });
        }
    }
}
