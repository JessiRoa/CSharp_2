using System;
//using System.Text;
//using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorytellerLib;

namespace StoretellerTestsLib
{
    [TestClass]
    public class StoretellerTests
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            var actual = sut.TellStory("Jessica", 27, false);
            // Assert
            Assert.AreEqual("Lyssna nu Jessica. Det var en gång en prinsessa " + "som tyckte om att dansa", actual);
        }
        [TestMethod]
        public void TellStoryToOldYoungJessicaNotScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            string actual = sut.TellStory("Jessica", 27, true);
            Assert.AreEqual($"Lyssna nu Jessica.  Det var en gång en prinsessa " + "som egentligen var en varulv", actual);
        }
        [TestMethod]
        public void TellStoryToOldJohnnyNotScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            string actual = sut.TellStory("Johhny", 32, false);
            Assert.AreEqual($"Hallå Johnny! En gång fanns en kille som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldJohnnyScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            string actual = sut.TellStory("Johnny", 32, true);
            Assert.AreEqual($"Hallå Johnny! En gång fanns en kille som egentligen var en varulv.", actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            string actual = sut.TellStory("Mariela", 4, true);
            // Assert
            // Assert.AreEqual("Hallå Marco! En gång fanns en kille " + "som egentligen var en varulv", actual);
        }
    }
}
    