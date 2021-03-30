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

//            string connectionString =
//"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
//            MySqlConnection conn = new MySqlConnection(connectionString);
//            conn.Open();

//            string sqlsats = "Select * from spel";
//            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
//            MySqlDataReader dataReader = cmd.ExecuteReader();

//            while (dataReader.Read())
//            {
//                List<string> kolumner = new List<string>();

//                for (int i = 0; i < dataReader.FieldCount; i++)
//                {
//                    if (!dataReader.IsDBNull(i))
//                    {
//                        kolumner.Add(dataReader.GetString(i));
//                    }
//                    else
//                    {
//                        kolumner.Add("NULL");
//                    }
//                }
//                Spel sp = new Spel(int.Parse(kolumner[0]), kolumner[1], kolumner[2], int.Parse(kolumner[3]), 
//                    kolumner[4], bool.Parse(kolumner[5]), int.Parse(kolumner[6]), int.Parse(kolumner[7]));
//                MinaSpel.Add(sp);
//            }

            //MinaSpel.Add(new DigitaltSpel("The Last Crusade Action Game", "Äventyr", 7, "PC", true, 99, 1989, 1, 0.25));
            //MinaSpel.Add(new DigitaltSpel("Super Mario 64", "Plattform", 3, "Nintendo 64", false, 399, 1996, 1, 5));
            //MinaSpel.Add(new FysisktSpel("Fortnite", "Battle Royale", 12, "PC", true, 0, 2017, 350*10^6));
            //MinaSpel.Add(new DigitaltSpel("The Legend of Zelda: Twilight Princess", "Äventyr", 7, "Nintendo Wii", false, 399, 2006, 1, 26));


            lbx_spel.DataSource = MinaSpel;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_spel.Clear();
            if (lbx_spel.Items.Contains(MinaSpel))
            {
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
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            MinaSpel.Sort();
            lbx_spel.DataSource = null;
            lbx_spel.Items.Clear();
            lbx_spel.DataSource = MinaSpel;
            
        }
    }
}
