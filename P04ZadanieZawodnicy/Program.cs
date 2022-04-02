using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zawodnik z = new Zawodnik();
            //z.Imie = "Jan";
            //z.Nazwisko = "Kowalski";

            //Console.WriteLine(z.PrzedstawSie());

            //Zawodnik[] zawodnicy = new Zawodnik[2];

            //zawodnicy[0] = z;
            //zawodnicy[1] = new Zawodnik()
            //{
            //    Imie = "Adam",
            //    Nazwisko = "Nowak"
            //};

            ////zapis 
            //Zawodnik z2 = new Zawodnik()
            //{
            //    Imie = "Ola",
            //    Nazwisko = "Kowalska"
            //};

            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(sciezka);

            // int a= dane.Count(x => x == '\n');

            string[] wiersze = dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int liczbaWierszy = wiersze.Length;


            // Zawodnik[] zawodnicy = new Zawodnik[liczbaWierszy - 1];
            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            List<string> wierszeZleSformatowane = new List<string>();
            for (int i = 1; i < liczbaWierszy; i++)
            {
                string[] komorki = wiersze[i].Split(';');

                try
                {
                    Zawodnik z = new Zawodnik();
                    z.Id = Convert.ToInt32(komorki[0]);
                    //if (!string.IsNullOrWhiteSpace(komorki[1]))
                    z.IdTrenera = Convert.ToInt32(komorki[1]);
                    z.Imie = komorki[2];
                    z.Nazwisko = komorki[3];
                    z.Kraj = komorki[4];
                    z.DataUrodzenia = Convert.ToDateTime(komorki[5]);
                    z.Wzrost = Convert.ToInt32(komorki[6]);
                    z.Waga = Convert.ToInt32(komorki[7]);
                    zawodnicy.Add(z);
                }
                catch (Exception)
                {
                    wierszeZleSformatowane.Add(wiersze[i]);
                }   
            }

            Console.WriteLine("Zawodnicy poprawnie zaimportowani");
            for (int i = 0; i < zawodnicy.Count; i++)
                Console.WriteLine(zawodnicy[i].PrzedstawSie());

            Console.WriteLine("Zle sformatowane rekordy");
            for (int i = 0; i < wierszeZleSformatowane.Count; i++)
                Console.WriteLine(wierszeZleSformatowane[i]);

            Console.ReadKey();
        }
    }
}
