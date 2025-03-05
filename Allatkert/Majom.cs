using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    internal class Majom
    {
        private string nev;
        private int kor;
        private int sebesseg;
        private int intelligencia;

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Intelligencia { get => intelligencia; set => intelligencia = value; }

        public Majom(string nev, int kor, int sebesseg, int intelligencia)
        {
            this.nev = nev;
            this.kor = kor;
            this.sebesseg = sebesseg;
            this.intelligencia = intelligencia;
        }
    }
}
