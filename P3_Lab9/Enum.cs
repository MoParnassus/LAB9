using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Lab9
{
        [Flags]
        public enum GrupaWiekowa
        {
            Brak=0,
            Dzieci =1, 
            Mlodziez=2,
            Dorosli=4,
            Starsi=8,
            
        }

        public enum Zainteresowania
        {
            Komputer,
            Gaming,
            Elektronika,
            Cos
        }
    
}
