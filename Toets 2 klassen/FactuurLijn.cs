using System;
using System.Collections.Generic;
using System.Text;

namespace Toets_2_klassen
{
    internal class FactuurLijn
    {
        public int Aantal { get; set; }
        public double Prijs { get; set; }
        public string Product { get; set; }
        public FactuurLijn()
        {

        }
        public FactuurLijn(int aantal, string productNaam, double prijs)
        {
            aantal = Aantal;
            prijs = Prijs;
            Product = productNaam;
        }
        public override string ToString()
        {
            return Product;
        }
        public double BerekenFactuurTotaal()
        {
            double Berekening = Prijs * Aantal;
            return Berekening;
        }
    }
}
