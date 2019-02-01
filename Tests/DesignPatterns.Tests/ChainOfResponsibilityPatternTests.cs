using ChainOfResponsibilityPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ChainOfResponsibilityPatternTests
    {
        [TestMethod]
        public void Command_Is_Null()
        {
            // Arrange
            var processor1 = new Processor(1, LevelTypes.Level1);
            var processor2 = new Processor(2, LevelTypes.Level2);
            processor1.Next = processor2;
            var processor3 = new Processor(3, LevelTypes.Level3);
            processor2.Next = processor3;
            // Act
            var actual = processor1.Process(null);
            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Next_Is_Null()
        {
            // Arrange
            var processor1 = new Processor(1, LevelTypes.Level1);
            var processor2 = new Processor(2, LevelTypes.Level2);
            processor1.Next = processor2;
            var command = new Command(LevelTypes.Level3);
            // Act
            var actual = processor1.Process(null);
            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Level1_Processor()
        {
            // Arrange
            var processor1 = new Processor(1, LevelTypes.Level1);
            var processor2 = new Processor(2, LevelTypes.Level2);
            processor1.Next = processor2;
            var processor3 = new Processor(3, LevelTypes.Level3);
            processor2.Next = processor3;
            var command = new Command(LevelTypes.Level1);
            var expected = "processed by processor: 1";
            // Act
            var actual = processor1.Process(command);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Level2_Processor()
        {
            // Arrange
            var processor1 = new Processor(1, LevelTypes.Level1);
            var processor2 = new Processor(2, LevelTypes.Level2);
            processor1.Next = processor2;
            var processor3 = new Processor(3, LevelTypes.Level3);
            processor2.Next = processor3;
            var command = new Command(LevelTypes.Level2);
            var expected = "processed by processor: 2";
            // Act
            var actual = processor1.Process(command);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Level3_Processor()
        {
            // Arrange
            var processor1 = new Processor(1, LevelTypes.Level1);
            var processor2 = new Processor(2, LevelTypes.Level2);
            processor1.Next = processor2;
            var processor3 = new Processor(3, LevelTypes.Level3);
            processor2.Next = processor3;
            var command = new Command(LevelTypes.Level3);
            var expected = "processed by processor: 3";
            // Act
            var actual = processor1.Process(command);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
