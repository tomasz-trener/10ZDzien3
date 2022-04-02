using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    enum TypKalkulatora
    {
        Dodajacy,
        Odejmujacy,
        Mnozacy,
        Dzielacy
    }


    class KalkulatorUniwersalny
    {

        //1) pola
        //2) właściwosći
        //3) konstruktory
        //4) metody 


        public int Waga;
        public TypKalkulatora typKalkulatora;

        public double WykonajOperacje(int a, int b)
        {
            if (typKalkulatora == TypKalkulatora.Dodajacy)
                new KalkulatorDodajacy().Dodaj(a, b);
            if (typKalkulatora == TypKalkulatora.Odejmujacy)
                new KalkulatorOdejmujacy().Odejmij(a, b);
            if (typKalkulatora == TypKalkulatora.Mnozacy)
                new KalkulatorMnozacy().Przemnoz(a, b);
            if (typKalkulatora == TypKalkulatora.Dzielacy)
                new KalkulatorDzielacy().Podziel(a, b);

            throw new Exception("Nieznany Typ kalkulator");
        }

        //public double Dodaj(int a, int b)
        //{
        //    KalkulatorDodajacy kd = new KalkulatorDodajacy();
        //    return kd.Dodaj(a, b);
        //}

        //public double Odejmij(int a, int b)
        //{
        //    KalkulatorOdejmujacy ko = new KalkulatorOdejmujacy();
        //    return ko.Odejmij(a, b);

        //}

    }
}
