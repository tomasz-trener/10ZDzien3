using P01ZadanieTemperatury.Bledy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class Program
    {
        /*
         
        1) problem z uzytkownikiem końcowym
        2) problem z programistą  

         */

        // walidacja danych wyjsćiowych (dla uzytnikownika koncowego)
        // ujdenolicenie kodu , poprawa danych wejsciowych do naszych metod i klas (dla programisty)

        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();

            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();

                Console.WriteLine("Podaj jednostke (f,c lub k)");
                string jednostka = Console.ReadLine().ToLower();

                //Wersja 3 walidacji

                try
                {
                    Jednostka jednostkaWal = new PogodaWalidacja().WalidujJednostke(jednostka);
                    double wynik = mp.PodajTemperature(miasto, jednostkaWal);
                    Console.WriteLine(wynik);
                }
                catch (UnsupportedUnitException)
                {
                    Console.WriteLine("Nieznana jednostka");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieznany błąd");
                }
             


                // Wersja 2 walidacji
                //Jednostka? jednostkaWal = new PogodaWalidacja().WalidujJednostke(jednostka);

                //if(jednostkaWal!= null)
                //{
                //    double wynik = 
                //        mp.PodajTemperature(miasto, (Jednostka)jednostkaWal);
                //    Console.WriteLine(wynik);
                //}
                //else
                //    Console.WriteLine("Zla jednostka");

                // Wersja 1 walidacji 
                //double? t;
                //if (jednostka == "c")
                //    t = mp.PodajTemperature(miasto, Jednostka.Celcjusz);                  
                //else if (jednostka == "f")
                //    t = mp.PodajTemperature(miasto, Jednostka.Farenheit);        
                //else if (jednostka == "k")
                //    t = mp.PodajTemperature(miasto, Jednostka.Klevin);
                //else // błędna jednostka 
                //    t = null;

                //if(t== null)
                //    Console.WriteLine("Podano złą jednostkę");
                //else
                //    Console.WriteLine(t);
            }

            //https://github.com/tomasz-trener/10ZDzien3
        }
    }
}
