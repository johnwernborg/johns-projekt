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
    public partial class frm_adderaUppd : Form
    {
        List<Spel> MinaNyaSpel = new List<Spel>();
        public frm_adderaUppd()
        {
            InitializeComponent();
        }

        public void hamtaLista(List<Spel> allaSpel)
        {
            lbx_spel.DataSource = allaSpel;
            MinaNyaSpel = allaSpel;
        }

        public void hamtaSpel(Spel valtSpel)
        {
            tbx_valtSpel.Text = valtSpel.GetShortInfo();

            tbx_titel.Text = valtSpel.Titel;
            tbx_genre.Text = valtSpel.Genre;
            tbx_aldersgrans.Text = valtSpel.Aldersgrans.ToString();
            tbx_plattform.Text = valtSpel.Plattform;
            tbx_utgivning.Text = valtSpel.Utgivning.ToString();
            tbx_pris.Text = valtSpel.Pris.ToString();
            if(valtSpel is DigitaltSpel)
            {
                lbl_digFys.Text = "Nedladdningar";
                tbx_digFys.Text = "Nedladdningar";
            }
            else if(valtSpel is FysisktSpel)
            {
                lbl_digFys.Text = "Enheter i lager";
                tbx_digFys.Text = "Enheter i lager";
            }
            if (valtSpel.Nedladd == false) tbx_jaNej.Text = "Nej";
            else tbx_jaNej.Text = "Ja";




        }

        private void btn_laggTill_Click(object sender, EventArgs e)
        {
            if (btn_adderaUpd.Text == "Uppdatera spelet")
            {

            }
            else if(btn_adderaUpd.Text == "Lägg till nytt spel")
            {
                int id = MinaNyaSpel.Count + 1;
                string titel = tbx_titel.Text;
                string genre = tbx_genre.Text;
                int aldersgrans = int.Parse(tbx_aldersgrans.Text);
                string plattform = tbx_plattform.Text;
                int utgivning = int.Parse(tbx_utgivning.Text);
                int pris = int.Parse(tbx_pris.Text);
                int nedladdningar = 0;
                int enheter = 0;
                bool nedladd = false;
                if (tbx_jaNej.Text == "Ja")
                {
                    nedladd = true;
                }
                else if (tbx_jaNej.Text == "Nej")
                {
                    nedladd = false;
                }
                Spel nyttSpel = new Spel();
                if (rb_digSpel.Checked)
                {
                    nedladdningar = int.Parse(tbx_digFys.Text);
                    nyttSpel = new DigitaltSpel(id, titel, genre, aldersgrans, plattform, nedladd, pris, utgivning, nedladdningar);

                }
                else if (rb_fysSpel.Checked)
                {
                    enheter = int.Parse(tbx_digFys.Text);
                    nyttSpel = new FysisktSpel(id, titel, genre, aldersgrans, plattform, nedladd, pris, utgivning, enheter);
                }
                MinaNyaSpel.Add(nyttSpel);

                //Hämtar koppling till databasen
                string connectionString =
    "SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                //Skickar det nya spelet till databasen
                string sqlsats = $"Insert Into spel(ProduktID, ProduktNamn, ProduktGenre, Aldersgrans, Plattform, Nedladdningsbart, " +
                    $"EnhetPris, UtgivningsAr, EnheterILager, Nedladdningar) Values ('{id}', '{titel}', '{genre}', '{aldersgrans}', " +
                    $"'{plattform}', '{nedladd}', '{pris}', '{utgivning}', '{enheter}', '{nedladdningar}')";
                MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        private void rb_fysSpel_CheckedChanged(object sender, EventArgs e)
        {
            lbl_digFys.Text = "Enheter i lager";
        }

        private void rb_digSpel_CheckedChanged(object sender, EventArgs e)
        {
            lbl_digFys.Text = "Nedladdningar";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var newForm = new Form1();
            newForm.hamtaUpdLista(MinaNyaSpel);
            frm_adderaUppd.ActiveForm.Close();
        }
    }
}
