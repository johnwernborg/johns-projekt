using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class Faktura
    {
        int id;
        int produktid;
        int kundid;
        int pris;
        DateTime datum;

        public Faktura(int id, int produktid, int kundid, int pris, DateTime datum)
        {
            Id = id;
            Produktid = produktid;
            Kundid = kundid;
            Pris = pris;
            Datum = datum;
        }

        public Faktura() { }

        public int Id { get => id; set => id = value; }
        public int Kundid { get => kundid; set => kundid = value; }
        public int Pris { get => pris; set => pris = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Produktid { get => produktid; set => produktid = value; }
    }
}
