using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class Szarvas
    {
        private string nev;
        private int kor;
        private int sebesseg;
        private int szelidseg;

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Szelidseg { get => szelidseg; set => szelidseg = value; }

        public Szarvas(string nev, int kor, int sebesseg, int szelidseg)
        {
            this.nev = nev;
            this.kor = kor;
            this.sebesseg = sebesseg;
            this.szelidseg = szelidseg;
        }
    }
}
