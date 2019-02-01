using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObserverPattern;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ObserverPatternTests
    {
        [TestMethod]
        public void Dispose_Any_Observer()
        {
            // Arrange
            var subject = new Subject();
            var observer1 = new Observer1();
            var observer2 = new Observer2();
            var observer3 = new Observer3();
            var unsubscriber1 = observer1.Register(subject);
            var unsubscriber2 = observer2.Register(subject);
            var unsubscriber3 = observer3.Register(subject);
            // Act
            unsubscriber2.Dispose();
            // Assert
            Assert.AreEqual(2, subject.Observers.Count);
        }

        [TestMethod]
        public void Register_All_Observers()
        {
            // Arrange
            var subject = new Subject();
            var observer1 = new Observer1();
            var observer2 = new Observer2();
            var observer3 = new Observer3();
            // Act
            var unsubscriber1 = observer1.Register(subject);
            var unsubscriber2 = observer2.Register(subject);
            var unsubscriber3 = observer3.Register(subject);
            // Assert
            Assert.AreEqual(3, subject.Observers.Count);
        }

        [TestMethod]
        public void Register_Observer1()
        {
            // Arrange
            var subject = new Subject();
            var observer1 = new Observer1();
            // Act
            var unsubscriber1 = observer1.Register(subject);
            // Assert
            Assert.AreEqual(1, subject.Observers.Count);
        }

        [TestMethod]
        public void Register_Observer2()
        {
            // Arrange
            var subject = new Subject();
            var observer2 = new Observer2();
            // Act
            var unsubscriber2 = observer2.Register(subject);
            // Assert
            Assert.AreEqual(1, subject.Observers.Count);
        }

        [TestMethod]
        public void Register_Observer3()
        {
            // Arrange
            var subject = new Subject();
            var observer3 = new Observer3();
            // Act
            var unsubscriber3 = observer3.Register(subject);
            // Assert
            Assert.AreEqual(1, subject.Observers.Count);
        }

        [TestMethod]
        public void Subject_SendMessage()
        {
            // Arrange
            var subject = new Subject();
            var observer1 = new Observer1();
            var unsubscriber1 = observer1.Register(subject);
            var expected = "message";
            // Act
            subject.SendMessage("message");
            // Assert
            Assert.AreEqual(expected, observer1.Message);
        }
    }
}