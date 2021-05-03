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
        public frm_laddaNer()
        {
            InitializeComponent();
        }

        private void btn_mapp_Click(object sender, EventArgs e)
        {
            //Välja mapp där spelet laddas ner
            //Funkar inte riktigt... gör på något annat sätt
            OpenFileDialog filValjare = new OpenFileDialog();
            filValjare.Filter = "";
            DialogResult result = filValjare.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
            else
            {

            }
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
            string address = tbx_address.Text;




            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Skickar kundinfo till kunder
            string sqlsats = $"Insert Into kunder(KundID, KontaktNamn, Address, Telefon) Values (1, 'NULL', '{address}', 'NULL')";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            //Skickar orderinfo till orders
            conn.Open();
            sqlsats = $"Insert Into orders(ProduktID, KundID, OrderPris, Frakt, Datum) Values ({produktId}, 1, {produktPris}, 20, 'NULL')";
            MySqlCommand cmd2 = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            conn.Close();

            lbl_laddatNer.Visible = true;
        }

        public void hamtaSpel(Spel valtSpel)
        {
            laddaNerSpel = valtSpel;
            lbl_valtSpel.Text = laddaNerSpel.Titel;
        }
    }
}
