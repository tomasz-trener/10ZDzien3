using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieZawodnicy
{
    class ManagerZawodnikow
    {
        private const char separator = ';';
        private const string nowaLinia = "\r\n";
        public string sciezka;


        public ManagerZawodnikow(string sciezka)
        {
            this.sciezka = sciezka; // this odwołuje siędo ciała klasy i jest potzrebne tylko w styuacji gdy wystepuje konflikt nazw
        }


        public Zawodnik[] WygenerujZawodnikow()
        {
            
            string dane = new WebClient().DownloadString(sciezka);
            string[] wiersze = dane.Split(new string[1] { nowaLinia }, StringSplitOptions.RemoveEmptyEntries);
            int liczbaWierszy = wiersze.Length;
            List<Zawodnik> zawodnicy = new List<Zawodnik>();
            List<string> wierszeZleSformatowane = new List<string>();
            for (int i = 1; i < liczbaWierszy; i++)
            {
                string[] komorki = wiersze[i].Split(separator);
                try
                {
                    Zawodnik z = new Zawodnik();
                    z.Id = Convert.ToInt32(komorki[0]);
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
            return zawodnicy.ToArray();

        }

    }
}
