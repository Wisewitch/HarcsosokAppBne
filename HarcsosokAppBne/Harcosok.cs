using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcsosokAppBne
{
    class Harcosok
    {
        int harcos_id;
        string nev;
        DateTime letrehozas;

        public Harcosok(int harcos_id, string nev, DateTime letrehozas)
        {
            this.harcos_id = harcos_id;
            this.nev = nev;
            this.letrehozas = letrehozas;
        }


        public int Harcos_Id { get => harcos_id; set => harcos_id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Letrehozas { get => letrehozas; set => letrehozas = value; }


        public override string ToString()
        {
            return String.Format("{0} - {1} ({2})", harcos_id, nev, letrehozas);
        }
    }
}
