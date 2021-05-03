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
    public partial class Form1 : Form
    {
        List<Spel> MinaSpel = new List<Spel>();
        List<Spel> EttSpel = new List<Spel>();

        int aktuellIndex = 0;
        public Form1()
        {
            InitializeComponent();

            LäsInAllaSpel(MinaSpel);

            //MinaSpel.Add(new DigitaltSpel("The Last Crusade Action Game", "Äventyr", 7, "PC", true, 99, 1989, 1, 0.25));
            //MinaSpel.Add(new DigitaltSpel("Super Mario 64", "Plattform", 3, "Nintendo 64", false, 399, 1996, 1, 5));
            //MinaSpel.Add(new FysisktSpel("Fortnite", "Battle Royale", 12, "PC", true, 0, 2017, 350*10^6));
            //MinaSpel.Add(new DigitaltSpel("The Legend of Zelda: Twilight Princess", "Äventyr", 7, "Nintendo Wii", false, 399, 2006, 1, 26));


            lbx_spel.DataSource = MinaSpel;
            dgv_spel.DataSource = MinaSpel;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Textboxen är lite otydlig. Kanske visa genom en datagridview istället?

            ////Rensar textboxen så att ny text kan skrivas
            //tbx_spel.Clear();

            //    aktuellIndex = lbx_spel.SelectedIndex;
            //    Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;

            //    tbx_spel.AppendText(aktuelltSpel.GetShortInfo());

            //    //if (aktuelltSpel.Nedladd) btn_hamtaSpel.Text = "Ladda ner";
            //    //else btn_hamtaSpel.Text = "Beställ";


            //    if (aktuelltSpel is DigitaltSpel)
            //    {

            //    }
            //    else
            //    {

            //    }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            //Kollar om varje radiobutton är itryckt och sorterar utefter det listan
            if (rb_az.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Titel).ToList<Spel>();
                if (rb_za.Checked)
                {
                    MinaSpel.Reverse();
                }
            }
            else if (rb_stigande.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Pris).ToList<Spel>();
                if (rb_fallande.Checked)
                {
                    MinaSpel.Reverse();
                }
            }
            else if (rb_retro.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Utgivning).ToList<Spel>();
                if (rb_modernt.Checked)
                {
                    MinaSpel.Reverse();
                }
            }


            //Sortera utefter vad användaren har valt
            lbx_spel.DataSource = null;
            lbx_spel.Items.Clear();
            lbx_spel.DataSource = MinaSpel;
            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;

        }

        private void btn_hamtaSpel_Click(object sender, EventArgs e)
        {
            //Känner av vilket spel man vill köpa (OBS! ändra från listbox till datagridview)
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;
            if(btn_hamtaSpel.Text == "Beställ")
            {
                var newForm = new frm_bestall();
                //För över produktID till beställ-fönstret
                newForm.hamtaProduktInfo(aktuelltSpel);
                newForm.Show();
            }
            else if(btn_hamtaSpel.Text == "Ladda ner")
            {
                var newForm = new frm_laddaNer();
                newForm.hamtaSpel(aktuelltSpel);
                newForm.Show();
            }

        }



        private void btn_rensa_Click(object sender, EventArgs e)
        {
            RadioButton[] knappar = { rb_az, rb_za, rb_stigande, rb_fallande, rb_modernt, rb_retro };

            foreach(RadioButton knapp in knappar)
            {
                knapp.Checked = false;
            }
            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;

            tbx_sok.Clear();
        }

        private void spelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Funkar bara när man trycker på ett spel, inte när man bläddrar i listan
            Spel aktuelltSpel = (Spel)dgv_spel.CurrentRow.DataBoundItem;
            lbl_spel.Text = aktuelltSpel.Titel;
        }

        private void btn_radera_Click(object sender, EventArgs e)
        {
            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            Spel aktuelltSpel = (Spel)dgv_spel.CurrentRow.DataBoundItem;

            //Raderar aktuellt spel
            //Blir felmeddelande med databasen men spelet tas bort?
            string sqlsats = $"Delete From spel Where ProduktID = {aktuelltSpel.Id}";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            MinaSpel.Remove(aktuelltSpel);
            conn.Close();
        }

        private void btn_laggTill_Click(object sender, EventArgs e)
        {
            var newForm = new frm_adderaUppd();
            //För över alla spel till beställ-fönstret
            newForm.hamtaLista(MinaSpel);

            newForm.Show();
        }

        private void btn_uppdatera_Click(object sender, EventArgs e)
        {
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;

            var newForm = new frm_adderaUppd();
            //För över produktID till beställ-fönstret
            newForm.hamtaSpel(aktuelltSpel);

            newForm.Show();
        }

        public void hamtaUpdLista(List<Spel> nyLista)
        {
            MinaSpel = nyLista;
            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;
        }

        private void btn_laddaNer_Click(object sender, EventArgs e)
        {
            //Känner av vilket spel man vill köpa (OBS! ändra från listbox till datagridview)
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;
            //Ska bara gå om nedladdninsbart är true
            if (aktuelltSpel.Nedladd)
            {
                var newForm = new frm_laddaNer();
                newForm.hamtaSpel(aktuelltSpel);
                newForm.Show();
            }
        }

        private void dgv_spel_CurrentCellChanged(object sender, EventArgs e)
        {
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;
            lbl_spel.Text = aktuelltSpel.Titel;
            if (aktuelltSpel.Nedladd)
            {
                if(aktuelltSpel is FysisktSpel) btn_hamtaSpel.Text = "Beställ / Ladda ner";
                else btn_hamtaSpel.Text = "Ladda ner";
            }
            else
            {
                btn_hamtaSpel.Text = "Beställ";
            }
        }

        private void btn_sok_Click(object sender, EventArgs e)
        {
            EttSpel.Clear();
            string soktSpel = tbx_sok.Text;
            bool hittat = false;
            foreach(Spel sp in MinaSpel)
            {
                if(sp.Titel == soktSpel)
                {
                    hittat = true;
                    EttSpel.Add(sp);
                    break;
                }
            }
            if (hittat)
            {
                lbl_ejHitta.Visible = false;
                dgv_spel.DataSource = null;
                dgv_spel.DataSource = EttSpel;
            }
            else
            {
                lbl_ejHitta.Visible = true;
            }

//            string connectionString =
//"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
//            MySqlConnection conn = new MySqlConnection(connectionString);
//            conn.Open();

//            //Söker efter alla spel
//            string specSpel = tbx_sok.Text;
//            string sqlsats = $"Select * From spel Where ProduktNamn = '{specSpel}'";
//            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
//            MySqlDataReader dataReader = cmd.ExecuteReader();
//            MinaSpel.Clear();

//            while (dataReader.Read())
//            {

//            }
        }

        public void LäsInAllaSpel(List<Spel> MinaSpel)
        {

            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla spel
            string sqlsats = "Select * from spel";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Läser in alla spel
            while (dataReader.Read())
            {
                List<string> kolumner = new List<string>();

                //Samlar alla kolumner i en lista
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    //Om en kolumn är NULL får den en string "NULL" för att undvika felmeddelande
                    if (!dataReader.IsDBNull(i))
                    {
                        kolumner.Add(dataReader.GetString(i));
                    }
                    else
                    {
                        kolumner.Add("NULL");
                    }
                }
                //Kollar ifall det är fysiskt eller digitalt, fysiskt har en kolumn med bool
                if (kolumner.Contains("false"))
                {
                    FysisktSpel sp = new FysisktSpel(int.Parse(kolumner[0]), kolumner[1], kolumner[2], int.Parse(kolumner[3]),
                             kolumner[4], bool.Parse(kolumner[5]), int.Parse(kolumner[6]), int.Parse(kolumner[7]), int.Parse(kolumner[8]));
                    MinaSpel.Add(sp);
                }
                else
                {
                    DigitaltSpel sp = new DigitaltSpel(int.Parse(kolumner[0]), kolumner[1], kolumner[2], int.Parse(kolumner[3]),
                                kolumner[4], bool.Parse(kolumner[5]), int.Parse(kolumner[6]), int.Parse(kolumner[7]), int.Parse(kolumner[9]));
                    MinaSpel.Add(sp);
                }
            }
        }
    }
}
