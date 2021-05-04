using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class DigitaltSpel : Spel
    {
        string nyRad = Environment.NewLine;

        int nedladdningar;

        public DigitaltSpel(int id, string titel, string genre, int aldersgrans, string plattform,
    int pris, int utgivning, int nedladdningar)
    : base(id, titel, genre, aldersgrans, plattform, pris, utgivning)
        {
            Nedladdningar = nedladdningar;
        }

        public override string GetShortInfo()
        {
            int pris = 0;
            if (Pris > 0) pris = Pris;

            return $"{Titel}{nyRad}Genre: {Genre}{nyRad}Aldersgrans: {Aldersgrans}+{nyRad}Plattform: {Plattform}" +
                $"{nyRad}Pris: {Pris} kr{nyRad}Utgivningsar: {Utgivning}" +
                $"{nyRad}Antal nedladdningar: {Nedladdningar}";
        }

        public int Nedladdningar { get => nedladdningar; set => nedladdningar = value; }
    }
}
