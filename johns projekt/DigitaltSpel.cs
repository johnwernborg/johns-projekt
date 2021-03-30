using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class DigitaltSpel : Spel
    {
        int nedladdningar;

        public DigitaltSpel(int id, string titel, string genre, int aldersgrans, string plattform,
    bool nedladd, int pris, int utgivning, int nedladdningar)
    : base(id, titel, genre, aldersgrans, plattform, nedladd, pris, utgivning)
        {
            Nedladdningar = nedladdningar;
        }

        public int Nedladdningar { get => nedladdningar; set => nedladdningar = value; }
    }
}
