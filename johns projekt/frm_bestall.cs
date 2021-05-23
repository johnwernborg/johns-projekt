using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace johns_projekt
{
    public partial class frm_bestall : Form
    {
        //Hämtas från första fönstret
        Spel bestalltSpel = new Spel();
        Konto kundBestallt = new Konto();

        public frm_bestall()
        {
            InitializeComponent();

            //Den snabbaste dagen spelbutiken kan leverera är inom tre dagar
            DateTime minDag = DateTime.Now.AddDays(3);
            //Om dagen är en helgdag kommer den bli nästa måndag
            while(minDag.DayOfWeek.ToString() == "Saturday" || minDag.DayOfWeek.ToString() == "Sunday")
            {
                minDag = minDag.AddDays(1);
            }
            monthCalendar1.MinDate = minDag;

            nud_antal.Value = 1;
            nud_antal.Minimum = 1;
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
            lbl_bestallInfo.Visible = true;
            CultureInfo provider = CultureInfo.InvariantCulture;

            //Läser in all beställningsinfo
            int produktId = bestalltSpel.Id;
            int kundId = kundBestallt.Id;
            string produktTitel = bestalltSpel.Titel;
            int produktPris = bestalltSpel.Pris;
            int antal = Convert.ToInt32(Math.Round(nud_antal.Value, 0));
            int orderPris = produktPris * antal;
            string address = tbx_address.Text;
            string datumText = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime datum = DateTime.ParseExact(datumText, "yyyy-MM-dd", provider);
            DateTime betalDatum = DateTime.Now.AddDays(30);
            
            

            //Kollar så att address är ok

            if (kundBestallt.KontrollAddress(address))
            {
                //Hämtar koppling till databasen
                string connectionString =
    "SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                //Skickar kundinfo till kunder
                string sqlsats = $"INSERT INTO orders(ProduktID, KundID, Address, OrderPris, Datum) " +
                    $"VALUES ({produktId}, {kundId}, '{address}', {orderPris}, '{datum}')";
                MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();

                //Skickar faktura till fakturor
                conn.Open();
                sqlsats = $"INSERT INTO fakturor(ProduktID, KundID, Pris, Datum) VALUES ({produktId}, {kundId}, {orderPris}, '{betalDatum}')";
                MySqlCommand cmd2 = new MySqlCommand(sqlsats, conn);
                MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                conn.Close();

                //Tar bort X enheter från spelet i lagret
                conn.Open();
                sqlsats = $"UPDATE spel SET EnheterILager = EnheterILager - {antal} WHERE ProduktID = {produktId}";
                MySqlCommand cmd3 = new MySqlCommand(sqlsats, conn);
                MySqlDataReader dataReader3 = cmd3.ExecuteReader();
                conn.Close();

                lbl_bestallInfo.Text = "Beställningen är skickad!";
            }
            else
            {
                lbl_bestallInfo.Text = "Dina uppgifter var ej giltiga. Försök igen.";
            }
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            //Går tillbaka till grundfönstret
            this.Close();
        }

        public void hamtaOrderInfo(Spel valtSpel, Konto kund)
        {
            bestalltSpel = valtSpel;
            kundBestallt = kund;
            lbl_valtSpel.Text = bestalltSpel.Titel;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btn_bestallInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
