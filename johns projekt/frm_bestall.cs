using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace johns_projekt
{
    public partial class frm_bestall : Form
    {
        //Hämtas från första fönstret
        Spel bestalltSpel = new Spel();



        public frm_bestall()
        {
            InitializeComponent();

            nud_antal.Value = 1;

            tbx_address.Text = "Linnégatan 29";
            tbx_kontaktnamn.Text = "John Wernborg";
            tbx_telenum.Text = "0767753637";
        }

        private void frm_bestall_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Går tillbaka till grundfönstret
            this.Close();
        }

        private void btn_bestall_Click(object sender, EventArgs e)
        {


            //Måste hämta ProduktID och Pris från grundfönstret, 

            //Läser in all beställningsinfo
            string produktId = bestalltSpel.Id.ToString();
            string produktTitel = bestalltSpel.Titel;
            int produktPris = bestalltSpel.Pris;
            int antal = Convert.ToInt32(Math.Round(nud_antal.Value, 0));
            string address = tbx_address.Text;
            string kontaktnamn = tbx_kontaktnamn.Text;
            string telefon = tbx_telenum.Text;
            string datumText = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime datum = new DateTime(2021, 04, 29, 13, 37, 23);




            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Skickar kundinfo till kunder
            string sqlsats = $"Insert Into kunder(KundID, KontaktNamn, Address, Telefon) Values (1, '{kontaktnamn}', '{address}', '{telefon}')";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            //Skickar orderinfo till orders
            conn.Open();
            sqlsats = $"Insert Into orders(ProduktID, KundID, OrderPris, Frakt, Datum) Values ({produktId}, 1, {antal} * {produktPris}, 20, '{datum}')";
            MySqlCommand cmd2 = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader2 = cmd2.ExecuteReader();
            lbl_bestallSkickad.Visible = true;
            conn.Close();
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            //Går tillbaka till grundfönstret
            this.Close();
            //Rensa textboxer eller inte???
        }

        public void hamtaProduktInfo(Spel valtSpel)
        {
            bestalltSpel = valtSpel;
            lbl_valtSpel.Text = bestalltSpel.Titel;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbl_datum.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
