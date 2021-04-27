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

        int aktuellIndex = 0;
        public Form1()
        {
            InitializeComponent();

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

            //MinaSpel.Add(new DigitaltSpel("The Last Crusade Action Game", "Äventyr", 7, "PC", true, 99, 1989, 1, 0.25));
            //MinaSpel.Add(new DigitaltSpel("Super Mario 64", "Plattform", 3, "Nintendo 64", false, 399, 1996, 1, 5));
            //MinaSpel.Add(new FysisktSpel("Fortnite", "Battle Royale", 12, "PC", true, 0, 2017, 350*10^6));
            //MinaSpel.Add(new DigitaltSpel("The Legend of Zelda: Twilight Princess", "Äventyr", 7, "Nintendo Wii", false, 399, 2006, 1, 26));


            lbx_spel.DataSource = MinaSpel;
            dataGridView1.DataSource = MinaSpel;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Textboxen är lite otydlig. Kanske visa genom en datagridview istället?

            //Rensar textboxen så att ny text kan skrivas
            tbx_spel.Clear();

                aktuellIndex = lbx_spel.SelectedIndex;
                Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;

                tbx_spel.AppendText(aktuelltSpel.GetShortInfo());

                if (aktuelltSpel.Nedladd) btn_hamtaSpel.Text = "Ladda ner";
                else btn_hamtaSpel.Text = "Beställ";


                if (aktuelltSpel is DigitaltSpel)
                {

                }
                else
                {

                }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            //Gör en if-sats som kollar vilka radiobuttons som är itryckta
            //och skicka sedan en sql-sats till databasen för att få tillbaka rätt sorterat
            if (rb_az.Checked)
            {

            }
            else if (rb_za.Checked)
            {

            }

            //Sortera utefter vad användaren har valt
            MinaSpel.Sort();
            lbx_spel.DataSource = null;
            lbx_spel.Items.Clear();
            lbx_spel.DataSource = MinaSpel;
            
        }

        private void btn_hamtaSpel_Click(object sender, EventArgs e)
        {
            //Känner av vilket spel man vill köpa (OBS! ändra från listbox till datagridview)
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;
            var newForm = new frm_bestall();
            //För över produktID till beställ-fönstret
            newForm.hamtaProduktInfo(aktuelltSpel);

            newForm.Show();
        }



        private void btn_rensa_Click(object sender, EventArgs e)
        {

        }

        private void spelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Funkar bara när man trycker på ett spel, inte när man bläddrar i listan
            Spel aktuelltSpel = (Spel)dataGridView1.CurrentRow.DataBoundItem;
            lbl_spel.Text = aktuelltSpel.Titel;
        }

        private void btn_radera_Click(object sender, EventArgs e)
        {
            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            Spel aktuelltSpel = (Spel)dataGridView1.CurrentRow.DataBoundItem;

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
    }
}
