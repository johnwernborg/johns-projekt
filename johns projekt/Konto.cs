using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace johns_projekt
{
    public class Konto
    {
        string fornamn;
        string efternamn;
        string epost;
        string losenord;
        string roll;

        public Konto(string fornamn, string efternamn, string epost, string losenord, string roll)
        {
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
    }
}
