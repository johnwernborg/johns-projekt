using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class Onlinespel : Spel
    {
        int aktiva;

        public Onlinespel(string titel, string genre, int aldersgrans, string plattform,
            bool nedladd, int pris, int utgivning, int aktiva)
            : base (titel, genre, aldersgrans, plattform, nedladd, pris, utgivning)
        {
            Aktiva = aktiva;
        }



        public int Aktiva { get => aktiva; set => aktiva = value; }
    }
}
