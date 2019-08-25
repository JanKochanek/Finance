using System;
using System.Collections.Generic;
using System.Text;

namespace HomeFinance.Model
{
    public class Prijem
    {
        public string Nazev { get; set; }
        public string Datum { get; set; }
        public string Druh { get; set; }
        public string Castka { get; set; }

        public Prijem (string nazev, string datum, string druh, string castka)
        {
            Nazev = nazev;
            Datum = datum;
            Druh = druh;
            Castka = castka;
        }
    }
}
