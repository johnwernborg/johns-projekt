using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class Offlinespel : Spel
    {
        int spelare;
        double langd;

        public Offlinespel(string titel, string genre, int aldersgrans, string plattform,
    bool nedladd, int pris, int utgivning, int spelare, double langd)
    : base(titel, genre, aldersgrans, plattform, nedladd, pris, utgivning)
        {
            Spelare = spelare;
            Langd = langd;
        }

        public int Spelare { get => spelare; set => spelare = value; }
        public double Langd { get => langd; set => langd = value; }
    }
}
