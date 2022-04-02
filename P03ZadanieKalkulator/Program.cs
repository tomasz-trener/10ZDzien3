using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorUniwersalny ku = new KalkulatorUniwersalny();

            ku.Waga = 20;
            ku.typKalkulatora = TypKalkulatora.Dodajacy;


            double a= ku.WykonajOperacje(4, 6);
            double b = ku.WykonajOperacje(4, 10);


        }
    }
}
