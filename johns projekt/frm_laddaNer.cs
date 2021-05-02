using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace johns_projekt
{
    public partial class frm_laddaNer : Form
    {
        Spel laddaNerSpel = new Spel();
        public frm_laddaNer()
        {
            InitializeComponent();
        }

        private void btn_mapp_Click(object sender, EventArgs e)
        {
            //Välja mapp där spelet laddas ner
            //Funkar inte riktigt... gör på något annat sätt
            OpenFileDialog filValjare = new OpenFileDialog();
            filValjare.Filter = "";
            DialogResult result = filValjare.ShowDialog();
            if(result == DialogResult.OK)
            {

            }
            else
            {

            }
        }

        private void btn_laddaNer_Click(object sender, EventArgs e)
        {
            //Välj plats där filen ska sparas
            DialogResult resultat = dlgSparaFil.ShowDialog();
            //Blir en tom fil, får inget format???
            dlgSparaFil.Filter = "(*.txt) | *.txt";

            if(resultat == DialogResult.OK)
            {
                FileStream utStrom = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                BinaryWriter skrivare = new BinaryWriter(utStrom);

                //Skriver detta i textdokumentet
                skrivare.Write($"{laddaNerSpel.Titel} installation file\n");
                skrivare.Write("///////////////////////////////////////\n");
                skrivare.Write($"Thanks for downloading {laddaNerSpel.Titel}");

                skrivare.Dispose();
            }
        }

        public void hamtaSpel(Spel valtSpel)
        {
            laddaNerSpel = valtSpel;
            lbl_valtSpel.Text = laddaNerSpel.Titel;
        }
    }
}
