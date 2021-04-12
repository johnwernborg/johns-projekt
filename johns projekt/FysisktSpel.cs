using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class FysisktSpel : Spel
    {
        string nyRad = Environment.NewLine;

        int enheter;

        public FysisktSpel(int id, string titel, string genre, int aldersgrans, string plattform,
            bool nedladd, int pris, int utgivning, int enheter)
            : base (id, titel, genre, aldersgrans, plattform, nedladd, pris, utgivning)
        {
            Enheter = enheter;
        }

        public override string GetShortInfo()
        {
            string nedladdning = "Nedladdningsbart";
            if (!Nedladd) nedladdning = "Ej nedladdningsbart";
            int pris = 0;
            if (Pris > 0) pris = Pris;

            return $"{Titel}{nyRad}{Genre}{nyRad}{Aldersgrans}+{nyRad}{Plattform}{nyRad}{nedladdning}{nyRad}{Pris} kr{nyRad}{Utgivning}{nyRad}{Utgivning}";
        }

        public int Enheter { get => enheter; set => enheter = value; }
    }
}
