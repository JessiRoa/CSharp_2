using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusLib
{
    public class Circus
    {
        private string name;
        private Dictionary<Artist, int> ArtistFöreställningarDictionary = new Dictionary<Artist, int>(); //För att varje artist ta redan på hur många anställda finns
        public Circus(string ArtistName)
        {
            this.name = ArtistName;
        }

        public int AntalArtist {
            get
            {
                return this.ArtistFöreställningarDictionary.Count;
            }
        }

        public void Anställ(Artist artist)
        {
            ArtistFöreställningarDictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            ArtistFöreställningarDictionary[artist]++;
        }

        public override string ToString()
        {
            var message = $"Circusen {this.name} har {this.AntalArtist} artister.";
            foreach (var artistFöreställningarEntry in ArtistFöreställningarDictionary)
            {
                string gånger = "gång";
                if (artistFöreställningarEntry.Value > 1)
                {
                    gånger += "er";
                }
                message += $" {artistFöreställningarEntry.Key.name} har uppträtt {artistFöreställningarEntry.Value} {gånger}.";
            }
            //Debug.WriteLine(message);
            return message;
        }
    }
}
