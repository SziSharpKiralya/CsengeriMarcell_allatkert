using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class Allat
    {
        private string nev;
        private int sebesseg;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }

        public Allat(string nev, int sebesseg)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
        }
    }
}
