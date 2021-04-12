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
        public frm_bestall()
        {
            InitializeComponent();
        }

        private void frm_bestall_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Går tillbaka till grundfönstret
            //Rensa textboxer eller inte???
        }

        private void btn_bestall_Click(object sender, EventArgs e)
        {
            //Måste hämta ProduktID och Pris från grundfönstret, 

            //Läser in all beställningsinfo
            int antal = nud_antal.DecimalPlaces;
            string address = tbx_address.Text;
            string kontaktnamn = tbx_kontaktnamn.Text;
            string telefon = tbx_telenum.Text;


            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Skickar kundinfo till kunder
            string sqlsats = $"Insert Into kunder(KundID, KontaktNamn, Telefon, Address) Values (1, {kontaktnamn}, {address}, {telefon})";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            //Skickar orderinfo till orders
            sqlsats = $"Insert Into orders(ProduktID, KundID, OrderPris, Frakt, Datum) Values (1, 1, {antal} * 100, 20, {telefon})";
            cmd = new MySqlCommand(sqlsats, conn);
            dataReader = cmd.ExecuteReader();
            lbl_bestallSkickad.Visible = true;
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            //Går tillbaka till grundfönstret
            //Rensa textboxer eller inte???
        }
    }
}
