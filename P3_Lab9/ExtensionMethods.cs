using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P3_Lab9
{
    public static class ExtensionMethods
    {
        public static (int wynik, int resztaZDzielenia) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int ZliczZnaki(this string tekst, char znak)
        {
            return tekst.Count(x =>x.Equals(znak) );
        }
        public static int ZliczZnaki(this string tekst, string znak)
        {
            if (znak.Length > 1)
            {
                throw new ArgumentException();
            }
            return ZliczZnaki(tekst, znak[0]);
            return tekst.ZliczZnaki(znak[0]);
        }

        public static int SumaGrupWiekowych(this GrupaWiekowa grupa)
        {
            return Enum.GetValues(typeof(GrupaWiekowa)).Cast<int>().Sum();

            int suma = 0;
            foreach (var item in Enum.GetValues(typeof(GrupaWiekowa)))
            {
                suma += (int)item;
            }
            return suma;
        }

        public static int SumaEnuma<T>(this T element)where T:System.Enum
        {
            return Enum.GetValues(typeof(T)).Cast<int>().Sum();
        }
    }

}
