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



        public frm_bestall()
        {
            InitializeComponent();

            DateTime minDag = DateTime.Now.AddDays(4);
            while(minDag.DayOfWeek.ToString() == "Saturday" || minDag.DayOfWeek.ToString() == "Sunday")
            {
                minDag = minDag.AddDays(1);
            }
            monthCalendar1.MinDate = minDag;
            lbl_datum.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

            nud_antal.Value = 1;
            nud_antal.Minimum = 1;

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
            lbl_bestallInfo.Visible = true;
            CultureInfo provider = CultureInfo.InvariantCulture;

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
            DateTime datum = DateTime.ParseExact(datumText, "yyyy-MM-dd", provider);

            bool adrSiffra = false;
            bool adrBokstav = false;
            bool namnSiffra = false;
            bool teleBokstav = false;

            //Kollar så att address är ok
            foreach (char t in address)
            {
                int tecken = t;
                if (tecken > 47 && tecken < 58) adrSiffra = true;
                if ((tecken > 64 && tecken < 90) || (tecken > 96 && tecken < 123)) adrBokstav = true;
                if (adrSiffra && adrBokstav) break;
            }

            //Kollar så att kontaktnamn är ok
            foreach (char t in kontaktnamn)
            {
                int tecken = t;
                if (tecken > 47 && tecken < 58)
                {
                    namnSiffra = true;
                    break;
                }
            }

            //Kollar så att telefonnummer är ok
            foreach (char t in telefon)
            {
                int tecken = t;
                if ((tecken > 64 && tecken < 90) || (tecken > 96 && tecken < 123))
                {
                    teleBokstav = true;
                    break;
                }
            }

            if (adrBokstav && adrBokstav && !namnSiffra && !teleBokstav)
            {
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
                lbl_bestallInfo.Text = "Din beställning har skickats!";
                conn.Close();
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lbl_datum.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }
    }
}
