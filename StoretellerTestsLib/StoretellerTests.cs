using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorytellerLib;

namespace StoretellerTestsLib
{
    [TestClass]
    public class StorytellerTests
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Jehnny", 6, false);
            Assert.AreEqual($"Lyssna nu Jehnny. Det var en gång en prinsessasom tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Jessica", 8, false);
            Assert.AreEqual($"Hallå Jessica! En gång fanns en kille som tyckte om att dansa.", actual);
        }
        [TestMethod]
        public void TellStoryToOldScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Jessica", 8, true);
            Assert.AreEqual($"Hallå Jessica! En gång fanns en kille som egentligen var en varulv.", actual);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new Storyteller();
            string actual = sut.TellStory("Mariela", 4, true);
        }
    }
}