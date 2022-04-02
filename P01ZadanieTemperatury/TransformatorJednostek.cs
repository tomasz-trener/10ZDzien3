using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class TransformatorJednostek
    {
        /// <summary>
        /// Podaj wartość oraz jednostki, które chcesz transformować
        /// </summary>
        /// <param name="wartosc">Wartość do transformacji</param>
        /// <param name="jednostkaDocelowa">jednostka docelowa do wyboru c,f,k</param>
        /// <param name="jednostkaWejsciowa">jednostka wejsciowa do wyboru c,f,k</param>
        /// <returns></returns>
        public double ZamienTemperature(int wartosc, char jednostkaDocelowa, char jednostkaWejsciowa)
        {
            jednostkaDocelowa = Convert.ToChar(jednostkaDocelowa.ToString().ToLower());
            jednostkaWejsciowa = Convert.ToChar(jednostkaWejsciowa.ToString().ToLower());

            if (jednostkaWejsciowa == 'c' && jednostkaDocelowa== 'f')
                return (wartosc * 1.8) + 32;
            
            if (jednostkaWejsciowa == 'c' && jednostkaDocelowa == 'k')
                return wartosc + 273.15;

            if (jednostkaWejsciowa == 'f' && jednostkaDocelowa == 'c')
                return (wartosc - 32) / 1.8;

            if (jednostkaWejsciowa == 'f' && jednostkaDocelowa == 'k')
                return (wartosc + 459.67) * 5 / 9;

            if (jednostkaWejsciowa == 'k' && jednostkaDocelowa == 'c')
                return wartosc - 273.15;

            if (jednostkaWejsciowa == 'k' && jednostkaDocelowa == 'f')
                return (wartosc * 1.8) - 459.67;


            Console.WriteLine("Podano nieznaną jednostkę");


             
          //  return 0;
            throw new Exception("Podano nieznaną jednostkę"); 
        }
    }
}
