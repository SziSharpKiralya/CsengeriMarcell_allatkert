using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class Pingvin
    {
        private string nev;
        private int kor;
        private int sebesseg;
        private int uszasiSebesseg;

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int UszasiSebesseg { get => uszasiSebesseg; set => uszasiSebesseg = value; }

        public Pingvin(string nev, int kor, int sebesseg, int uszasiSebesseg)
        {
            this.nev = nev;
            this.kor = kor;
            this.sebesseg = sebesseg;
            this.uszasiSebesseg = uszasiSebesseg;
        }


    }
}
