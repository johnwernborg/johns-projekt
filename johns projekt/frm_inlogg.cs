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
        int forsok = 0;
        public frm_inlogg()
        {
            InitializeComponent();
        }

        private void btn_loggaIn_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fornamn = "";
            string efternamn = "";
            string epost = tbx_epost.Text;
            string losenord = tbx_losenord.Text;
            string roll = "";

            if(epost != "" && losenord != "")
            {
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
                    forsok++;

                    if (forsok > 5)
                    {
                        //Om användaren misslyckas med att logga in 5 ggr misstänks den för att
                        //hacka sig in på någon annans konto. För att hindra detta kastas exception
                        throw new LogInRepetitionException();
                    }
                }
                else
                {
                    forsok = 0;
                    id = int.Parse(kolumner[0]);
                    fornamn = kolumner[1];
                    efternamn = kolumner[2];
                    roll = kolumner[5];

                    //Skickar över det inloggade kontot till grundfönstret
                    Konto inlogg = new Konto(id, fornamn, efternamn, epost, losenord, roll);
                    var newForm = new Form1();
                    newForm.LoggaIn(inlogg);
                    this.Hide();
                    newForm.Show();
                }
            }
            else
            {
                lbl_inloggFel.Visible = true;
                lbl_inloggFel.Text = "Alla uppgifter måste vara ifyllda. Försök igen.";

            }


        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
