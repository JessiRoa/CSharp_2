using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestsLib
{
    [TestClass]
    public class FileConversionTests
    {
        [TestMethod]
        public void jessica_roa_1990()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("marco;erice;1978");
            Assert.AreEqual("MARCO ERICE ÄR 39 ÅR GAMMAL.", actual);
        }
        [TestMethod]
        public void mariela_gomez_1930()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("annai;erice;2016");
            Assert.AreEqual("ANNAI ERICE ÄR 1 ÅR GAMMAL.", actual);
        }
    }
}
