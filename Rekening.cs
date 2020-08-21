using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Overervingsoefening_bankapp
{
    public class Rekening
    {
        public string rekeningnr;
        private double crediet;
        Random rng = new Random();
        public Rekening(double crediet)
        {
            MaakRekeningnr();
            this.crediet = crediet;
        }
        private void MaakRekeningnr()
        {
            rekeningnr = "BE" + rng.Next(100).ToString().PadLeft(2, '0');

            for (int i = 1; i <= 3; i++)
            {
                int randomnr = rng.Next(10000);
                rekeningnr += " " + randomnr.ToString().PadLeft(4, '0');
            }

        }
        public void AddCrediet(double amount)
        {
            crediet += amount;
        }
        public virtual void OverSchrijven(double amount)
        {
            crediet -= amount;
        }
        public virtual void OverSchrijven(double amount, Rekening schuldeiser)
        {
            crediet -= amount;
            schuldeiser.AddCrediet(amount);
        }
        public double GetCrediet()
        {
            return Math.Round(crediet, 2);
        }
        public override string ToString()
        {
            return $"{rekeningnr} | €{GetCrediet()}";
        }
    }
}
