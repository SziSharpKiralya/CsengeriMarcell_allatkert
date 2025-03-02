using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class SarkiRoka
    {
        private string nev;
        private int kor;
        private int sebesseg;
        private int ravaszsag;

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Ravaszsag { get => ravaszsag; set => ravaszsag = value; }

        public SarkiRoka(string nev, int kor, int sebesseg, int ravaszsag)
        {
            this.nev = nev;
            this.kor = kor;
            this.sebesseg = sebesseg;
            this.ravaszsag = ravaszsag;
        }
    }
}
