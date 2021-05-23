using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class Konto : IControlTextbox
    {
        int id;
        string fornamn;
        string efternamn;
        string epost;
        string losenord;
        string roll;

        public Konto(int id, string fornamn, string efternamn, string epost, string losenord, string roll)
        {
            Id = id;
            Fornamn = fornamn;
            Efternamn = efternamn;
            Epost = epost;
            Losenord = losenord;
            Roll = roll;
        }

        public Konto() { }

        public string Fornamn { get => fornamn; set => fornamn = value; }
        public string Efternamn { get => efternamn; set => efternamn = value; }
        public string Epost { get => epost; set => epost = value; }
        public string Losenord { get => losenord; set => losenord = value; }
        public string Roll { get => roll; set => roll = value; }
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
            bool ok = false;
            if (epost.Contains('@'))
            {
                string[] foreoefter = epost.Split('@');
                if(foreoefter[0].Length > 0 && foreoefter[1].Length > 0)
                {
                    if (foreoefter[1].Contains('.'))
                    {
                        string[] address = foreoefter[1].Split('.');
                        if(address[1] == "se" || address[1] == "com" || address[1] == "nu")
                        {
                            ok = true;
                        }
                    }
                }
            }
            return ok;
        }
    }
}
