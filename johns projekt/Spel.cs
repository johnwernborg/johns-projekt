using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class Spel : IComparable<Spel>
    {
        string titel;
        string genre;
        int aldersgrans;
        string plattform;
        bool nedladd;
        int pris;
        int utgivning;

        public Spel(string titel, string genre, int aldersgrans, string plattform, 
            bool nedladd, int pris, int utgivning)
        {
            Titel = titel;
            Genre = genre;
            Aldersgrans = aldersgrans;
            Plattform = plattform;
            Nedladd = nedladd;
            Pris = pris;
            Utgivning = utgivning;
        }
        public Spel() { }

        public override string ToString()
        {
            return $"{Titel} ({Genre})";
        }

        public int CompareTo(Spel other)
        {
            return this.pris - other.pris;
        }

        public string Genre { get => genre; set => genre = value; }
        public int Aldersgrans { get => aldersgrans; set => aldersgrans = value; }
        public string Plattform { get => plattform; set => plattform = value; }
        public bool Nedladd { get => nedladd; set => nedladd = value; }
        public int Pris { get => pris; set => pris = value; }

        public string Titel { get => titel; set => titel = value; }
        public int Utgivning { get => utgivning; set => utgivning = value; }
    }
}
