using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overervingsoefening_bankapp
{
    class Credit : Rekening
    {
        public string CVC { get; }
        Random rng = new Random();

        public Credit(double crediet) : base(crediet)
        {
            this.CVC = rng.Next(0, 1000).ToString().PadLeft(3, '0');
        }


        public override string ToString()
        {

            return base.ToString() + " | Credit rekening";
        }

    }
}
