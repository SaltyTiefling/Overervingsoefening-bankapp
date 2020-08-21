using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingsoefening_bankapp
{
    public partial class fNieuweRekening : Form
    {
        public string antwoord;
        public double crediet = 0.00;
        public fNieuweRekening()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            crediet = (Double)numSaldo.Value;
            antwoord = cbxAntwoord.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void fNieuweRekening_Load(object sender, EventArgs e)
        {

            cbxAntwoord.SelectedIndex = 0;
        }
    }
}
