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
    public partial class frm_adderaUppd : Form
    {

        public frm_adderaUppd()
        {
            InitializeComponent();
        }

        public void hamtaProduktInfo(Spel valtSpel)
        {
            tbx_valtSpel.Text = valtSpel.GetShortInfo();
        }
    }
}
