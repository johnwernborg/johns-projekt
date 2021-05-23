using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class Order : IControlTextbox
    {
        int id;
        int produktid;
        int kontoid;
        string address;
        int pris;
        DateTime datum;

        public Order(int id, int produktid, int kontoid, string address, int pris, DateTime datum)
        {
            Id = id;
            Produktid = produktid;
            Kontoid = kontoid;
            Address = address;
            Pris = pris;
            Datum = datum;
        }

        public Order() { }

        public int Kontoid { get => kontoid; set => kontoid = value; }
        public string Address { get => address; set => address = value; }
        public int Pris { get => pris; set => pris = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Produktid { get => produktid; set => produktid = value; }
        public int Id { get => id; set => id = value; }

        public bool KontrollAddress(string address)
        {
            bool adrSiffra = false;
            bool adrBokstav = false;
            bool ok = false;
            foreach (char t in address)
            {
                int tecken = t;
                if (tecken > 47 && tecken < 58) adrSiffra = true;
                if ((tecken > 64 && tecken < 90) || (tecken > 96 && tecken < 123)) adrBokstav = true;
                if (adrSiffra && adrBokstav)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }

        public bool KontrollEpost(string epost)
        {
            throw new NotImplementedException();
        }
    }
}
