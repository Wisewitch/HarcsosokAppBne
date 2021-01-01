using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcsosokAppBne
{
    class Harcosok
    {
        int id;
        string nev;
        DateTime letrehozas;

        public Harcosok(int id, string nev, DateTime letrehozas)
        {
            this.id = id;
            this.nev = nev;
            this.letrehozas = letrehozas;
        }


        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Letrehozas { get => letrehozas; set => letrehozas = value; }


        public override string ToString()
        {
            return String.Format("{0} - {1} ({2})", id, nev, letrehozas);
        }
    }
}
