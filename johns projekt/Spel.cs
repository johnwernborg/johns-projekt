using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    class Spel : IComparable<Spel>
    {
        string nyRad = Environment.NewLine;

        int id;
        string titel;
        string genre;
        int aldersgrans;
        string plattform;
        bool nedladd;
        int pris;
        int utgivning;

        public Spel(int id, string titel, string genre, int aldersgrans, string plattform, 
            bool nedladd, int pris, int utgivning)
        {
            Id = id;
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

        public string GetShortInfo()
        {
            string nedladdning = "Nedladdningsbart";
            if (!Nedladd) nedladdning = "Ej nedladdningsbart";
            int pris = 0;
            if (Pris > 0) pris = Pris;

            return $"{Titel}{nyRad}{Genre}{nyRad}{Aldersgrans}+{nyRad}{Plattform}{nyRad}{nedladdning}{nyRad}{Pris} kr{nyRad}{Utgivning}";
        }

        public int CompareTo(Spel other)
        {
            return string.Compare(this.titel, other.titel);
        }

        public int PriceUpCompareTo(Spel other)
        {
            return this.pris - other.pris;
        }

        //public int PriceDownCompareTo(Spel other)
        //{
        //    return other.pris - this.pris;
        //}

        //public int TitleAZCompareTo(Spel other)
        //{
        //    return string.Compare(this.titel, other.titel);
        //}
        //public int TitleZACompareTo(Spel other)
        //{
        //    return string.Compare(other.titel, this.titel);
        //}

        public string Genre { get => genre; set => genre = value; }
        public int Aldersgrans { get => aldersgrans; set => aldersgrans = value; }
        public string Plattform { get => plattform; set => plattform = value; }
        public bool Nedladd { get => nedladd; set => nedladd = value; }
        public int Pris { get => pris; set => pris = value; }

        public string Titel { get => titel; set => titel = value; }
        public int Utgivning { get => utgivning; set => utgivning = value; }
        public int Id { get => id; set => id = value; }
    }
}
