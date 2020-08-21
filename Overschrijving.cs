using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingsoefening_bankapp
{
    public partial class fOverschrijving : Form
    {
        List<Rekening> schuldeisers = new List<Rekening>();
        public string accountnr;
        public double bedrag;

        public fOverschrijving(List<Rekening> schuldeiser)
        {
            this.schuldeisers = schuldeiser;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (NoErrors())
            {
                bedrag = (double)numSaldo.Value;
                accountnr = txtAccount.Text;
                this.DialogResult = DialogResult.OK;
            }


        }
        bool NoErrors()
        {
            bool result = true;
            if (!Regex.IsMatch(txtAccount.Text.ToUpper(), @"BE\d{2} \d{4} \d{4} \d{4}"))
            {
                epAccount.SetError(txtAccount, "geef een geldig account in");
                result = false;
            }
            else
            {
                epAccount.Clear();
            }

            if (numSaldo.Value < 0)
            {
                epbedrag.SetError(numSaldo, "geef een getal boven de 0");
                result = false;
            }
            else
            {
                epbedrag.Clear();
            }

            return result;
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            //NoErrors();
        }

        private void numSaldo_ValueChanged(object sender, EventArgs e)
        {
            NoErrors();
        }

        private void fOverschrijving_Load(object sender, EventArgs e)
        {
            foreach (Rekening item in schuldeisers)
            {
                MessageBox.Show(item.ToString());
                txtAccount.AutoCompleteCustomSource.Add(item.rekeningnr);
            }
            NoErrors();
        }
    }
}
