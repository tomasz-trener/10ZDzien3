using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieTemperatury
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerPogody mp = new ManagerPogody();

            while (true)
            {
                Console.WriteLine("Podaj miasto");
                string miasto = Console.ReadLine();
                double t = mp.PodajTemperature(miasto,'g');
                Console.WriteLine(t);
            }
        }
    }
}
