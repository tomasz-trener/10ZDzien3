using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            ManagerZawodnikow mz = new ManagerZawodnikow(sciezka);
         //mz.sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            Zawodnik[] zawodnicy= mz.WygenerujZawodnikow();

            foreach (var z in zawodnicy)
                Console.WriteLine(z.PrzedstawSie());

            Console.ReadKey();
        }
    }
}
