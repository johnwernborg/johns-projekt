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
        public frm_skapaKonto()
        {
            InitializeComponent();
            tbx_fornamn.Text = "John";
            tbx_efternamn.Text = "Wernborg";
            tbx_epost.Text = "john.wernborg@yahoo.se";
            tbx_losenord.Text = "jllya_W0123";
        }

        private void btn_skapaKonto_Click(object sender, EventArgs e)
        {
            string fornamn = tbx_fornamn.Text;
            string efternamn = tbx_efternamn.Text;
            string epost = tbx_epost.Text;
            string losenord = tbx_losenord.Text;
            string roll = "";
            bool unik = true;
            if (rb_kund.Checked)
            {
                roll = "Kund";
            }
            else if (rb_personal.Checked)
            {
                roll = "Personal";
            }

            //Hämtar koppling till databasen
            string connectionString =
"SERVER=localhost;DATABASE=spelbutik;UID=lennart;PASSWORD=abcdef";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            //Lägger till en ny kund/personal
            string sqlsats = $"SELECT * FROM konton WHERE Epost = '{epost}'";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                unik = false;
            }
            conn.Close();

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
                lbl_kontoInfo.Visible = true;
                lbl_kontoInfo.Text = "Eposten är redan registrerad. Försök igen";
            }

        }

        private void btn_avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
