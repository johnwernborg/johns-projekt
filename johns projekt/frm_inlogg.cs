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
    public partial class frm_inlogg : Form
    {
        public frm_inlogg()
        {
            InitializeComponent();
            tbx_epost.Text = "john.wernborg@yahoo.se";
            tbx_losenord.Text = "jllya_W0123";
        }

        private void btn_loggaIn_Click(object sender, EventArgs e)
        {
            string fornamn = "";
            string efternamn = "";
            string epost = tbx_epost.Text;
            string losenord = tbx_losenord.Text;
            string roll = "";

            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Söker efter personalen i databasen
            string sqlsats = $"SELECT * FROM konton WHERE Epost = '{epost}' AND Losenord = '{losenord}'";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            List<string> kolumner = new List<string>();

            while (dataReader.Read())
            {

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
            }
            if (kolumner.Count == 0)
            {
                lbl_inloggFel.Visible = true;
            }
            else
            {
                fornamn = kolumner[1];
                efternamn = kolumner[2];
                roll = kolumner[5];

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
