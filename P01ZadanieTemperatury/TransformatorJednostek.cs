using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class TransformatorJednostek
    {
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

            throw new Exception("Podano nieznaną jednostkę"); 
        }
    }
}
