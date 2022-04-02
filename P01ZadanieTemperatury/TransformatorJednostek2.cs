using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    enum Jednostka
    {
        Celcjusz,
        Klevin,
        Farenheit ,
    }


    class TransformatorJednostek2
    {
        /// <summary>
        /// Podaj wartość oraz jednostki, które chcesz transformować
        /// </summary>
        /// <param name="wartosc">Wartość do transformacji</param>
        /// <param name="jednostkaDocelowa">jednostka docelowa do wyboru uzywajac enumeratora Jednostka</param>
        /// <param name="jednostkaWejsciowa">jednostka wejsciowa do wyboru uzywajac enumeratora Jednostka</param>
        /// <returns></returns>
        public double ZamienTemperature(int wartosc, Jednostka jednostkaDocelowa, Jednostka jednostkaWejsciowa)
        {
            if (jednostkaWejsciowa == jednostkaDocelowa)
                return wartosc;

            if (jednostkaWejsciowa == Jednostka.Celcjusz && jednostkaDocelowa== Jednostka.Farenheit)
                return (wartosc * 1.8) + 32;
            
            if (jednostkaWejsciowa == Jednostka.Celcjusz && jednostkaDocelowa == Jednostka.Klevin)
                return wartosc + 273.15;

            if (jednostkaWejsciowa == Jednostka.Farenheit && jednostkaDocelowa == Jednostka.Celcjusz)
                return (wartosc - 32) / 1.8;

            if (jednostkaWejsciowa == Jednostka.Farenheit && jednostkaDocelowa == Jednostka.Klevin)
                return (wartosc + 459.67) * 5 / 9;

            if (jednostkaWejsciowa == Jednostka.Klevin && jednostkaDocelowa == Jednostka.Celcjusz)
                return wartosc - 273.15;

            if (jednostkaWejsciowa == Jednostka.Klevin && jednostkaDocelowa == Jednostka.Farenheit)
                return (wartosc * 1.8) - 459.67;

            // Console.WriteLine("Podano nieznaną jednostkę");
            //  return 0;

            Exception bladSzczegolowy = null;
            if (!(jednostkaDocelowa == Jednostka.Celcjusz || jednostkaDocelowa ==  Jednostka.Klevin || jednostkaDocelowa==Jednostka.Farenheit ))
                bladSzczegolowy = new Exception("Problem z jednostka docelowa");

            if (!(Convert.ToInt32(jednostkaWejsciowa) <3))
                bladSzczegolowy = new Exception("Problem z jednostka wejsciowa");

            throw new Exception("Podano nieznaną jednostkę",bladSzczegolowy); 
        }
    }
}
