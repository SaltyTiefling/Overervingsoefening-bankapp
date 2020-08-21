using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingsoefening_bankapp
{
    class Debit : Rekening
    {

        public Debit(double crediet) : base(crediet)
        {

        }
        public override void OverSchrijven(double amount)
        {
            if (amount > GetCrediet())
            {
                MessageBox.Show("je kan niet onder null gaan met een debitrekening");
            }
            else
            {
                base.OverSchrijven(amount);
            }
        }

        public override void OverSchrijven(double amount, Rekening schuldeiser)
        {
            if (amount > GetCrediet())
            {
                MessageBox.Show("je kan niet onder null gaan met een debitrekening");
            }
            else
            {
                base.OverSchrijven(amount, schuldeiser);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "| Debit rekening";
        }
    }
}
