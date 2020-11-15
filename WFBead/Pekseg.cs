using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBead
{
    class Pekseg
    {
        private string nev;
        private List<Pekaru> termekek;
        private DateTime alapitva;

        public Pekseg(string nev, List<Pekaru> termekek, DateTime alapitva)
        {
            this.nev = nev;
            this.termekek = termekek;
            this.alapitva = alapitva;
        }

        public string Nev { get => nev; set => nev = value; }
        public DateTime Alapitva { get => alapitva; set => alapitva = value; }
        internal List<Pekaru> Termekek { get => termekek; set => termekek = value; }
        public override string ToString()
        {
            return string.Format("{0}-{1}",this.nev,this.alapitva.Date);
        }
    }
}
