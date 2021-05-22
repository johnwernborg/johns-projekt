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
        Konto inloggad = new Konto();

        public Form1()
        {
            InitializeComponent();

            LäsInAllaSpel(MinaSpel);
            dgv_spel.DataSource = MinaSpel;
        }

        public void LoggaIn(Konto inlogg)
        {
            inloggad = inlogg;
            lbl_kontoNamn.Text = $"{inloggad.Fornamn} ({inloggad.Roll})";
            Button[] knappar = { btn_radera, btn_uppdatera};
            if (inloggad.Roll == "Kund")
            {
                btn_hamtaSpel.Text = "Beställ";
                btn_laggTill.Text = "Se mina fakturor";
                foreach(Button knapp in knappar)
                {
                    knapp.Visible = false;
                    knapp.Enabled = false;
                }
            }
            else if (inloggad.Roll == "Personal")
            {
                btn_hamtaSpel.Text = "Se alla beställningar";
                btn_laggTill.Text = "Lägg till nytt spel";
            }
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            //Kollar om varje radiobutton är itryckt och sorterar utefter det listan
            if (rb_az.Checked || rb_za.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Titel).ToList<Spel>();
                if (rb_za.Checked)
                {
                    MinaSpel.Reverse();
                }
            }
            else if (rb_stigande.Checked || rb_fallande.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Pris).ToList<Spel>();
                if (rb_fallande.Checked)
                {
                    MinaSpel.Reverse();
                }
            }
            else if (rb_retro.Checked || rb_modernt.Checked)
            {
                MinaSpel = MinaSpel.OrderBy(spel => spel.Utgivning).ToList<Spel>();
                if (rb_modernt.Checked)
                {
                    MinaSpel.Reverse();
                }
            }

            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;

        }

        private void btn_hamtaSpel_Click(object sender, EventArgs e)
        {
            //Känner av vilket spel man vill köpa
            Spel aktuelltSpel = (Spel)dgv_spel.CurrentRow.DataBoundItem;
            if (btn_hamtaSpel.Text == "Beställ")
            {
                var newForm = new frm_bestall();
                newForm.hamtaOrderInfo(aktuelltSpel, inloggad);
                newForm.Show();
            }
            else if(btn_hamtaSpel.Text == "Ladda ner")
            {
                var newForm = new frm_laddaNer();
                newForm.hamtaInfo(aktuelltSpel, inloggad);
                newForm.Show();
            }
            else if(btn_hamtaSpel.Text == "Se alla beställningar")
            {
                var newForm = new frm_bestallningar();
                newForm.Show();
            }

        }



        private void btn_rensa_Click(object sender, EventArgs e)
        {
            //Gör så att ingen knappt är itryckt
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
            string sqlsats = $"DELETE FROM spel WHERE ProduktID = {aktuelltSpel.Id}";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            MinaSpel.Remove(aktuelltSpel);
            conn.Close();
            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;
        }

        private void btn_laggTill_Click(object sender, EventArgs e)
        {
            if (btn_laggTill.Text == "Lägg till nytt spel")
            {
                var newForm = new frm_adderaUppd();
                //För över alla spel till beställ-fönstret
                newForm.hamtaLista(MinaSpel);

                //När man trycker på OK i adderaUppd-fönstret händer detta
                if (DialogResult.OK == newForm.ShowDialog())
                {
                    //Uppdaterar listan med spel
                    MinaSpel.Clear();
                    LäsInAllaSpel(MinaSpel);
                    dgv_spel.DataSource = null;
                    dgv_spel.DataSource = MinaSpel;
                }
            }
            else if(btn_laggTill.Text == "Se mina fakturor")
            {

            }

        }

        private void btn_uppdatera_Click(object sender, EventArgs e)
        {
            var newForm = new frm_adderaUppd();
            //Beroende på om det är fysiskt eller digitalt spel skickas nedladdningar eller enheter
            if (dgv_spel.CurrentRow.DataBoundItem is FysisktSpel)
            {
                FysisktSpel aktuelltFysSpel = (FysisktSpel)dgv_spel.CurrentRow.DataBoundItem;
                newForm.hamtaSpel(aktuelltFysSpel, 0, aktuelltFysSpel.Enheter);
            }
            else if (dgv_spel.CurrentRow.DataBoundItem is DigitaltSpel)
            {
                DigitaltSpel aktuelltDigSpel = (DigitaltSpel)dgv_spel.CurrentRow.DataBoundItem;
                newForm.hamtaSpel(aktuelltDigSpel, aktuelltDigSpel.Nedladdningar, 0);
            }
            //När man trycker på OK i adderaUppd-fönstret händer detta
            if (DialogResult.OK == newForm.ShowDialog())
            {
                //Uppdaterar listan med spel
                MinaSpel.Clear();
                LäsInAllaSpel(MinaSpel);
                dgv_spel.DataSource = null;
                dgv_spel.DataSource = MinaSpel;
            }
        }

        public void hamtaNyttSpel(Spel nyttSpel)
        {
            MinaSpel.Add(nyttSpel);
            dgv_spel.DataSource = null;
            dgv_spel.DataSource = MinaSpel;
        }

        private void btn_laddaNer_Click(object sender, EventArgs e)
        {
            //Känner av vilket spel man vill köpa
            Spel aktuelltSpel = (Spel)dgv_spel.CurrentRow.DataBoundItem;

            //Går bara att ladda ner spel som är digitala
            if (aktuelltSpel is DigitaltSpel)
            {
                var newForm = new frm_laddaNer();
                newForm.hamtaInfo(aktuelltSpel, inloggad);
                newForm.Show();
            }
        }

        private void dgv_spel_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dgv_spel.DataSource != null && dgv_spel.CurrentRow != null)
            {
                Spel aktuelltSpel = (Spel)dgv_spel.CurrentRow.DataBoundItem;
                lbl_spel.Text = aktuelltSpel.Titel;
                if (aktuelltSpel is DigitaltSpel && inloggad.Roll == "Kund")
                {
                    btn_hamtaSpel.Text = "Ladda ner";
                }
                else if (aktuelltSpel is FysisktSpel && inloggad.Roll == "Kund")
                {
                    btn_hamtaSpel.Text = "Beställ";
                }
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
        }

        public void LäsInAllaSpel(List<Spel> MinaSpel)
        { 
            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla spel
            string sqlsats = "SELECT * FROM spel";
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
                //Kollar ifall det är fysiskt eller digitalt spel
                bool fys = false;
                bool dig = false;

                //Om nedladdningar är noll kan det vara både fysiskt eller digitalt
                if (kolumner[8] == 0.ToString())
                {
                    //Om enheter också är noll är det helt ett nytt digitalt spel som inte laddats ner förut
                    if (kolumner[7] == 0.ToString())
                    {
                        dig = true;
                    }
                    //Annars är det ett fysiskt spel
                    fys = true;
                }
                //Om nedladdningar inte är noll är det ett digitalt spel
                else
                {
                    dig = true;
                }

                //Lägger till spelet i listan

                //Lägger bara till ett fysiskt spel om det finns enheter i lagret
                if (fys && kolumner[7] != 0.ToString())
                {
                    FysisktSpel sp = new FysisktSpel(int.Parse(kolumner[0]), kolumner[1], kolumner[2], int.Parse(kolumner[3]),
                                kolumner[4], int.Parse(kolumner[5]), int.Parse(kolumner[6]), int.Parse(kolumner[7]));
                    MinaSpel.Add(sp);
                }
                else if(dig)
                {
                    DigitaltSpel sp = new DigitaltSpel(int.Parse(kolumner[0]), kolumner[1], kolumner[2], int.Parse(kolumner[3]),
                                kolumner[4], int.Parse(kolumner[5]), int.Parse(kolumner[6]), int.Parse(kolumner[8]));
                    MinaSpel.Add(sp);
                }
            }
        }
    }
}
