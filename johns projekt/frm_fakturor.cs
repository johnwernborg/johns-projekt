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
    public partial class frm_fakturor : Form
    {
        List<Faktura> MinaFakturor = new List<Faktura>();
        Faktura aktuellFaktura = new Faktura();
        public frm_fakturor()
        {
            InitializeComponent();
            LäsInAllaFakturor(MinaFakturor);
            dgv_fakturor.DataSource = MinaFakturor;
        }
        public void LäsInAllaFakturor(List<Faktura> fakturor)
        {
            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla orders
            string sqlsats = "SELECT * FROM fakturor";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();


            //Läser in alla orders
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
                Faktura fak = new Faktura(int.Parse(kolumner[0]), int.Parse(kolumner[1]), int.Parse(kolumner[2]), DateTime.Parse(kolumner[3]));
                fakturor.Add(fak);
            }
        }

        private void btn_betala_Click(object sender, EventArgs e)
        {
            int fakturaID = aktuellFaktura.Id;

            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter alla orders
            string sqlsats = $"DELETE FROM fakturor WHERE FakturaID = {fakturaID}";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            dgv_fakturor.DataSource = null;
            MinaFakturor.Clear();
            LäsInAllaFakturor(MinaFakturor);
            dgv_fakturor.DataSource = MinaFakturor;
        }

        private void dgv_fakturor_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgv_fakturor.DataSource != null && dgv_fakturor.CurrentRow != null)
            {
                aktuellFaktura = (Faktura)dgv_fakturor.CurrentRow.DataBoundItem;
            }
        }
    }
}
