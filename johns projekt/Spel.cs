using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class Spel : IComparable<Spel>
    {
        string nyRad = Environment.NewLine;

        int id;
        string titel;
        string genre;
        int aldersgrans;
        string plattform;
        int pris;
        int utgivning;

        public Spel(int id, string titel, string genre, int aldersgrans, string plattform, 
            int pris, int utgivning)
        {
            Id = id;
            Titel = titel;
            Genre = genre;
            Aldersgrans = aldersgrans;
            Plattform = plattform;
            Pris = pris;
            Utgivning = utgivning;
        }
        public Spel() { }

        public override string ToString()
        {
            return $"{Titel} ({Genre})";
        }

        public virtual string GetShortInfo()
        {
            int pris = 0;
            if (Pris > 0) pris = Pris;

            return $"{Titel}{nyRad}Genre: {Genre}{nyRad}Aldersgrans: {Aldersgrans}+{nyRad}Plattform: {Plattform}" +
                $"{nyRad}Pris: {Pris} kr{nyRad}Utgivningsår: {Utgivning}";
        }

        public int CompareTo(Spel other)
        {
            return string.Compare(this.titel, other.titel);
        }

        public string Genre { get => genre; set => genre = value; }
        public int Aldersgrans { get => aldersgrans; set => aldersgrans = value; }
        public string Plattform { get => plattform; set => plattform = value; }
        public int Pris { get => pris; set => pris = value; }

        public string Titel { get => titel; set => titel = value; }
        public int Utgivning { get => utgivning; set => utgivning = value; }
        public int Id { get => id; set => id = value; }
    }
}
