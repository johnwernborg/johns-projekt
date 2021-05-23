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
    public partial class frm_valkommen : Form
    {
        public frm_valkommen()
        {
            InitializeComponent();
        }

        private void btn_skapaKonto_Click(object sender, EventArgs e)
        {
            var newForm = new frm_skapaKonto();

            //När man trycker på Skapa konto i skapaKonto-fönstret händer detta
            if (DialogResult.OK == newForm.ShowDialog())
            {

            }

        }

        private void btn_loggaIn_Click(object sender, EventArgs e)
        {
            var newForm = new frm_inlogg();

            if (DialogResult.OK == newForm.ShowDialog())
            {
                //var newForm2 = new Form1();
                //this.Hide();
                //newForm2.Show();


            }
        }

        private void frm_valkommen_Load(object sender, EventArgs e)
        {

        }

        private void btn_avsluta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
