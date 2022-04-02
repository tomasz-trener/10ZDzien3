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
        // nazwy metod jezeli publiczne to z Duzej , jak prywatne to z malej
        // argumenty wejsciowe do metod zawsze malej 
        // Nazwy klas lub enumeratorow piszemy z duzej 
        // nazwy zmiennych wewnatrz metod zawsze z malej litery 

        private void prywatnaMetoda()
        {

        }

        public double PodajTemperature(string miasto, Jednostka jednostkaDocelowa)
        {      
            const char znak = '°';
            const string znakKoncowy = ">";
            const Jednostka jednostkaWejciowa = Jednostka.Celcjusz;
            const string adresGooglePogoda = "https://www.google.com/search?q=pogoda";


            prywatnaMetoda();

            string adres = $"{adresGooglePogoda} {miasto}";
            string dane = new WebClient().DownloadString(adres);

            int indx = dane.IndexOf(znak);
            int aktualnaPoz = indx;

            while (dane.Substring(aktualnaPoz, 1) != znakKoncowy)
                aktualnaPoz--;

            string wynik = dane.Substring(aktualnaPoz + 1, indx + 1 - aktualnaPoz -2);// -2 znaki bo nie uwzgledniamy jednostki

            TransformatorJednostek2 tj = new TransformatorJednostek2();
            double temp= tj.ZamienTemperature(Convert.ToInt32(wynik), jednostkaDocelowa, jednostkaWejciowa);
            
            return temp;
        }



    }
}
