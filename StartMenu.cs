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
    public partial class fStartMenu : Form
    {
        public List<Rekening> rekeningenlijst { get; set; } = new List<Rekening>();
        public fStartMenu()
        {
            InitializeComponent();
        }

        private void fNewAccount_Load(object sender, EventArgs e)
        {
            rekeningenlijst.Add(new Rekening(10000));
            laadRekeningen();
        }

        private void laadRekeningen()
        {
            lbxRekeningen.DataSource = null;
            lbxRekeningen.DataSource = rekeningenlijst;
            lbxRekeningen.SelectedIndex = 0;
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            fNieuweRekening fnieuweRekening = new fNieuweRekening();
            if (fnieuweRekening.ShowDialog() == DialogResult.OK)
            {
                switch (fnieuweRekening.antwoord.ToLower())
                {
                    case "credit":
                        rekeningenlijst.Add(new Credit(fnieuweRekening.crediet));
                        break;
                    case "debit":
                        rekeningenlijst.Add(new Debit(fnieuweRekening.crediet));
                        break;
                    case "spaarrekening":
                        rekeningenlijst.Add(new Spaar(fnieuweRekening.crediet));
                        break;
                    default:
                        break;
                }
            }

            laadRekeningen();
        }

        private void btnOverschrijven_Click(object sender, EventArgs e)
        {
            fOverschrijving overschrijving = new fOverschrijving(rekeningenlijst);
            if (overschrijving.ShowDialog() == DialogResult.OK)
            {
                bool accountExists = false;
                foreach (Rekening item in rekeningenlijst)
                {
                    if (item.rekeningnr.Equals(overschrijving.accountnr) && !accountExists)
                    {
                        rekeningenlijst[lbxRekeningen.SelectedIndex].OverSchrijven(overschrijving.bedrag,item);
                        accountExists = true;
                    }
                }
                if (!accountExists)
                {
                    
                }
            } 
            laadRekeningen();
        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (rekeningenlijst[lbxRekeningen.SelectedIndex].GetCrediet() == 0.00)
            {
                rekeningenlijst.RemoveAt(lbxRekeningen.SelectedIndex);
            }
            else
            {
                MessageBox.Show($"Je rekening moet voledig leeg zijn je hebt nog €{rekeningenlijst[lbxRekeningen.SelectedIndex].GetCrediet()}");
            }

            laadRekeningen();
        }

        private void lbxRekeningen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
