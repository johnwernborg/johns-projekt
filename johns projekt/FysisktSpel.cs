using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class FysisktSpel : Spel
    {
        int enheter;

        public FysisktSpel(int id, string titel, string genre, int aldersgrans, string plattform,
            bool nedladd, int pris, int utgivning, int enheter)
            : base (id, titel, genre, aldersgrans, plattform, nedladd, pris, utgivning)
        {
            Enheter = enheter;
        }

        public int Enheter { get => enheter; set => enheter = value; }
    }
}
