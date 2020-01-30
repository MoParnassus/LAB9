using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Lab9
{
    public class Reklama
    {
        public string Tekst { get; set; }
        public GrupaWiekowa grupawiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, GrupaWiekowa grupawiekowa, Zainteresowania zainteresowania)
        {
            this.Tekst = tekst;
            this.grupawiekowa = grupawiekowa;
            this.zainteresowania = zainteresowania;
        }
    }
    
}
