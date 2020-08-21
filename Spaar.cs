using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingsoefening_bankapp
{
    class Spaar : Rekening
    {

        public Spaar(double crediet) : base(crediet)
        {
        }

        public override void OverSchrijven(double amount)
        { 
            MessageBox.Show("Deze rekening kan niet overschrijven");
        }
        public override void OverSchrijven(double amount, Rekening schuldeiser)
        {
            MessageBox.Show("Deze rekening kan niet overschrijven");
        }

        public override string ToString()
        {
            return base.ToString() + " | Spaarrekening";
        }
    }
}
