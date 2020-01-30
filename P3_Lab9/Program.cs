using System;

namespace P3_Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extension
            Console.WriteLine("Ala ma kota".ZliczZnaki('a')) ;

            Console.WriteLine();

            /*
            int liczba = Convert.ToInt32(Console.ReadLine());
            int wynik, reszta;
            (wynik,reszta)=liczba.DzielenieZReszta(3);


            Console.WriteLine($"{liczba}/3={wynik}r{reszta}");
            */
            #endregion

            var reklama = new Reklama(
                "Kup teraz",
                GrupaWiekowa.Dorosli|GrupaWiekowa.Starsi,
                Zainteresowania.Komputer);

            for (int i = 0; i <= GrupaWiekowa.Brak.SumaEnuma(); i++)
            {
                Console.WriteLine((GrupaWiekowa)i);
            }

        }
    }
}
