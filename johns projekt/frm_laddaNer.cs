using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace johns_projekt
{
    public partial class frm_laddaNer : Form
    {
        Spel laddaNerSpel = new Spel();
        Konto kundFaktura = new Konto();
        public frm_laddaNer()
        {
            InitializeComponent();
        }

        private void btn_mapp_Click(object sender, EventArgs e)
        {
        }

        private void btn_laddaNer_Click(object sender, EventArgs e)
        {
            //Välj plats där filen ska sparas
            DialogResult resultat = dlgSparaFil.ShowDialog();
            dlgSparaFil.Filter = "(*.txt) | *.txt";

            if(resultat == DialogResult.OK)
            {
                string filnamn = dlgSparaFil.FileName;
                if (!(filnamn.Contains(".txt")))
                {
                    filnamn += ".txt";
                }
                FileStream utStrom = new FileStream(filnamn, FileMode.OpenOrCreate, FileAccess.Write);

                BinaryWriter skrivare = new BinaryWriter(utStrom);

                //Skriver detta i textdokumentet
                skrivare.Write($"{laddaNerSpel.Titel} installation file\n");
                skrivare.Write("///////////////////////////////////////\n");
                skrivare.Write($"Thanks for downloading {laddaNerSpel.Titel}");

                skrivare.Dispose();
            }

            //Läser in all beställningsinfo
            string produktId = laddaNerSpel.Id.ToString();
            string produktTitel = laddaNerSpel.Titel;
            int produktPris = laddaNerSpel.Pris;
            int kundId = kundFaktura.Id;
            DateTime betalDatum = DateTime.Now.AddDays(30);

            //Hämtar koppling till databasen
            string connectionString =
    "SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);

            //Skickar faktura till fakturor
            conn.Open();
            string sqlsats = $"INSERT INTO fakturor(ProduktID, KundID, Pris, Datum) VALUES ({produktId}, {kundId}, {produktPris}, '{betalDatum}')";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            //Lägger till en nedladdning till spelet
            conn.Open();
            sqlsats = $"UPDATE spel SET Nedladdningar = Nedladdningar + 1 WHERE ProduktID = {produktId}";
            MySqlCommand cmd2 = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            conn.Close();

            lbl_laddatNer.Visible = true;
        }

        public void hamtaInfo(Spel valtSpel, Konto kund)
        {
            laddaNerSpel = valtSpel;
            kundFaktura = kund;
            lbl_valtSpel.Text = laddaNerSpel.Titel;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
