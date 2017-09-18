using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusLib;

namespace CircusTestLib
{
    [TestClass]
    public class CircusTest
    {
        [TestMethod]
        public void CircusArtister()

        {   //Arrage 
            Circus sut = new Circus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansare = new Artist("Lindansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansare);
            sut.ArtistUppträdande(clown);
            sut.ArtistUppträdande(lindansare);
            sut.ArtistUppträdande(lindansare);
            var expected = "Circusen Elefanten har 2 artister. Clownen Surskratt har uppträtt 1 gång. Lindansaren Repo har uppträtt 2 gånger.";

            //Act
            string actual = sut.ToString();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
