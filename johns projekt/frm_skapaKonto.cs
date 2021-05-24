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
    public partial class frm_skapaKonto : Form
    {
        Konto kontroll = new Konto();
        public frm_skapaKonto()
        {
            InitializeComponent();
        }

        private void btn_skapaKonto_Click(object sender, EventArgs e)
        {
            lbl_kontoInfo.Visible = true;

            string fornamn = tbx_fornamn.Text;
            string efternamn = tbx_efternamn.Text;
            string epost = tbx_epost.Text;
            string losenord = tbx_losenord.Text;
            string roll = "";
            bool unik = true;
            bool tom = false;
            //Kollar så att alla uppgifter är korrekt ifyllda
            if (rb_kund.Checked)
            {
                roll = "Kund";
            }
            else if (rb_personal.Checked)
            {
                roll = "Personal";
            }
            string[] boxes = { fornamn, efternamn, epost, losenord, roll };
            foreach(string b in boxes)
            {
                if(b == "")
                {
                    tom = true;
                    break;
                }
            }

            //Hämtar koppling till databasen
            if(!tom && kontroll.KontrollEpost(epost))
            {
                string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                //Kollar att kontot är unikt
                string sqlsats = $"SELECT * FROM konton WHERE Epost = '{epost}'";
                MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    unik = false;
                }
                conn.Close();

                //Gör ett ett nytt konto
                if (unik)
                {
                    conn.Open();
                    string sqlsats2 = $"INSERT INTO konton(Fornamn, Efternamn, Epost, Losenord, Roll) VALUES('{fornamn}', '{efternamn}', '{epost}', '{losenord}', '{roll}')";

                    MySqlCommand cmd2 = new MySqlCommand(sqlsats2, conn);
                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lbl_kontoInfo.Text = "Eposten är redan registrerad. Försök igen";
                }
            }
            else
            {
                lbl_kontoInfo.Text = "Alla uppgifter måste vara korrekt ifyllda.";
            }


        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_visa_Click(object sender, EventArgs e)
        {
            if (btn_visa.Text == "Visa")
            {
                tbx_losenord.PasswordChar = '\0';
                btn_visa.Text = "Dölj";
            }
            else if (btn_visa.Text == "Dölj")
            {
                tbx_losenord.PasswordChar = '*';
                btn_visa.Text = "Visa";
            }
        }
    }
}
