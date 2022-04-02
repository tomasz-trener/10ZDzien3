using P01ZadanieTemperatury.Bledy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class PogodaWalidacja
    {
        public Jednostka WalidujJednostke(string jednostka)
        {
            if (jednostka == "c")
                return Jednostka.Celcjusz;
            if (jednostka == "f")
                return Jednostka.Farenheit;
            if (jednostka == "k")
                return Jednostka.Klevin;

            throw new UnsupportedUnitException();
        }
    }
}
