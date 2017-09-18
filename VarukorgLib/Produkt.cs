using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarukorgLib
{
    public class Produkt
    {
        private string v;

        public Produkt(string v)
        {
            this.v = v;
        }

        public int Pris { get; set; }
    }
}
