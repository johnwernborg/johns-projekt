using System;
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
        BindingList<Spel> MinaSpel = new BindingList<Spel>();

        int aktuellIndex = 0;
        public Form1()
        {
            InitializeComponent();

            MinaSpel.Add(new Offlinespel("The Last Crusade Action Game", "Äventyr", 7, "PC", true, 99, 1989, 1, 0.25));
            MinaSpel.Add(new Offlinespel("Super Mario 64", "Plattform", 3, "Nintendo 64", false, 399, 1996, 1, 5));
            MinaSpel.Add(new Onlinespel("Fortnite", "Battle Royale", 12, "PC", true, 0, 2017, 350*10^6));
            MinaSpel.Add(new Offlinespel("The Legend of Zelda: Twilight Princess", "Äventyr", 7, "Nintendo Wii", false, 399, 2006, 1, 26));


            lbx_spel.DataSource = MinaSpel;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbx_spel.Clear();
            aktuellIndex = lbx_spel.SelectedIndex;
            Spel aktuelltSpel = (Spel)lbx_spel.SelectedValue;

            tbx_spel.AppendText(aktuelltSpel.GetShortInfo());

            if (aktuelltSpel.Nedladd) btn_hamtaSpel.Text = "Ladda ner";
            else btn_hamtaSpel.Text = "Beställ";


            if (aktuelltSpel is Offlinespel)
            {

            }
            else
            {

            }
        }
    }
}
