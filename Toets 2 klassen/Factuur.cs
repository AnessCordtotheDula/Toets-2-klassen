using System;
using System.Collections.Generic;
using System.Text;

namespace Toets_2_klassen
{
    internal class Factuur
    {
       public List<Factuur> Factuurlijnen = new List<Factuur>();
        public int FactuurID { get; set; }
        public int KlantID { get; set; }
        public string KlantNaam { get; set; }
        public List<Factuur> FactuurLijnen { get; }
        
        public Factuur()
        {

        }
        public Factuur(int factuurID, int klantID, string klantNaam)
        {
            FactuurID = factuurID;
            KlantID = klantID;
            KlantNaam = klantNaam;
        }
        public override string ToString()
        {
            return KlantNaam;
        }
        public void VoegFactuurLijnToe(int aantal, string productNaam, double Prijs)
        {
           
        }
        
    }
}
