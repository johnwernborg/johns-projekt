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
    public partial class frm_laddaNer : Form
    {
        public frm_laddaNer()
        {
            InitializeComponent();
        }

        private void btn_mapp_Click(object sender, EventArgs e)
        {
            //Välja mapp där spelet laddas ner
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
    }
}
