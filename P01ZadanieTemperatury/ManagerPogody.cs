using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class ManagerPogody
    {

        public double PodajTemperature(string miasto, char jednostkaDocelowa)
        {
            const char znak = '°';
            const string znakKoncowy = ">";
            const char jednostkaWejciowa = 'c';
            const string adresGooglePogoda = "https://www.google.com/search?q=pogoda";


            string adres = $"{adresGooglePogoda} {miasto}";
            string dane = new WebClient().DownloadString(adres);

            int indx = dane.IndexOf(znak);
            int aktualnaPoz = indx;

            while (dane.Substring(aktualnaPoz, 1) != znakKoncowy)
                aktualnaPoz--;

            string wynik = dane.Substring(aktualnaPoz + 1, indx + 1 - aktualnaPoz -2);// -2 znaki bo nie uwzgledniamy jednostki

            TransformatorJednostek tj = new TransformatorJednostek();
            double temp= tj.ZamienTemperature(Convert.ToInt32(wynik), jednostkaDocelowa, jednostkaWejciowa);
            
            return temp;
        }



    }
}
