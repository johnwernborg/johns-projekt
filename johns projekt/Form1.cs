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
        public Form1()
        {
            InitializeComponent();

            MinaSpel.Add(new Offlinespel("Indiana Jones and the Last Crusade: The Action Game", "Äventyr", 7, "PC", true, 99, 1989, 1, 15));
            MinaSpel.Add(new Offlinespel("Super Mario 64", "Plattform", 3, "Nintendo 64", false, 399, 1996, 1, 15));
            MinaSpel.Add(new Onlinespel("Fortnite", "Battle Royale", 12, "PC", true, 0, 2017, 350*10^6));


            listBox1.DataSource = MinaSpel;
        }
    }
}
