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
        Spel updSpel = new Spel();
        Spel nyttSpel = new Spel();
        List<Spel> MinaNyaSpel = new List<Spel>();
        int updNedladd = 0;
        int updEnheter = 0;
        public frm_adderaUppd()
        {
            InitializeComponent();
        }

        public void hamtaLista(List<Spel> allaSpel)
        {
            lbx_spel.DataSource = allaSpel;
            MinaNyaSpel = allaSpel;
            btn_adderaUpd.Text = "Lägg till nytt spel";
        }

        public void hamtaSpel(Spel valtSpel, int nedladdningar, int enheter)
        {
            //Spelet hämtas från grundfönstret och all information sparas
            tbx_titel.Text = valtSpel.Titel;
            tbx_genre.Text = valtSpel.Genre;
            tbx_aldersgrans.Text = valtSpel.Aldersgrans.ToString();
            tbx_plattform.Text = valtSpel.Plattform;
            tbx_utgivning.Text = valtSpel.Utgivning.ToString();
            tbx_pris.Text = valtSpel.Pris.ToString();
            if(valtSpel is DigitaltSpel)
            {
                lbl_digFys.Text = "Nedladdningar";
                tbx_digFys.Text = nedladdningar.ToString();
                rb_digSpel.Checked = true;
                rb_fysSpel.Enabled = false;
            }
            else if(valtSpel is FysisktSpel)
            {
                lbl_digFys.Text = "Enheter i lager";
                tbx_digFys.Text = enheter.ToString();
                rb_fysSpel.Checked = true;
                rb_digSpel.Enabled = false;
            }

            btn_adderaUpd.Text = "Uppdatera spelet";
            updSpel = valtSpel;
            updEnheter = enheter;
            updNedladd = nedladdningar;


        }

        private void btn_laggTill_Click(object sender, EventArgs e)
        {
            int id = 0;
            string titel = tbx_titel.Text;
            string genre = tbx_genre.Text;
            int aldersgrans = int.Parse(tbx_aldersgrans.Text);
            string plattform = tbx_plattform.Text;
            int utgivning = int.Parse(tbx_utgivning.Text);
            int pris = int.Parse(tbx_pris.Text);
            int nedladdningar = 0;
            int enheter = 0;
            bool tom = false;
            TextBox[] boxes = { tbx_titel, tbx_genre, tbx_aldersgrans, tbx_plattform, tbx_utgivning, tbx_pris };
            foreach(TextBox box in boxes)
            {
                if(box.Text == "")
                {
                    tom = true;
                    break;
                }
            }
            if (!tom)
            {
                //Uppdaterar spelet
                if (btn_adderaUpd.Text == "Uppdatera spelet")
                {
                    id = updSpel.Id;
                    nedladdningar = updNedladd;
                    enheter = updEnheter;

                    //Hämtar koppling till databasen
                    string connectionString =
        "SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();

                    //Uppdaterar spelet med alla värdena i textboxarna
                    string sqlsats = $"UPDATE spel SET ProduktNamn = '{titel}', ProduktGenre = '{genre}', Aldersgrans = {aldersgrans}" +
                        $", Plattform = '{plattform}', EnhetPris = {pris}, UtgivningsAr = {utgivning}, EnheterILager = {enheter}, Nedladdningar = {nedladdningar}" +
                        $" WHERE ProduktID = {id}";
                    MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    conn.Close();
                    lbl_lagtTill.Text = "Spelet har uppdaterats!";


                }
                //Lägger till ett nytt spel
                else if (btn_adderaUpd.Text == "Lägg till nytt spel")
                {
                    id = MinaNyaSpel.Count + 1;

                    if (rb_digSpel.Checked)
                    {
                        nedladdningar = int.Parse(tbx_digFys.Text);
                        nyttSpel = new DigitaltSpel(id, titel, genre, aldersgrans, plattform, pris, utgivning, nedladdningar);

                    }
                    else if (rb_fysSpel.Checked)
                    {
                        enheter = int.Parse(tbx_digFys.Text);
                        nyttSpel = new FysisktSpel(id, titel, genre, aldersgrans, plattform, pris, utgivning, enheter);
                    }

                    //Hämtar koppling till databasen
                    string connectionString =
        "SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();

                    //Skickar det nya spelet till databasen
                    string sqlsats = $"INSERT INTO spel(ProduktID, ProduktNamn, ProduktGenre, Aldersgrans, Plattform, " +
                        $"EnhetPris, UtgivningsAr, EnheterILager, Nedladdningar) VALUES ({id}, '{titel}', '{genre}', {aldersgrans}, " +
                        $"'{plattform}', {pris}, {utgivning}, {enheter}, {nedladdningar})";
                    MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    conn.Close();
                    lbl_lagtTill.Text = "Spelet har lagts till!";
                }
                lbl_lagtTill.Visible = true;
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
            //Skickar tillbaka det nya spelet till grundfönstret
            var newForm = new Form1();
            newForm.hamtaNyttSpel(nyttSpel);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frm_adderaUppd_Load(object sender, EventArgs e)
        {

        }
    }
}
