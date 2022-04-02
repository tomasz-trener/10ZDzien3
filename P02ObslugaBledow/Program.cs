using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ObslugaBledow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");      
            string[] c = new string[2];

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                c[a] = "ok";
                int b = 5 / a; // instrukcja niebezpieczna 
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Wystąpił błąd: podałeś złą wartość, nie podawaj 0");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Podaleś zbyt duża liczbe, podaj od 0 do 1");
            }
            catch (FormatException)
            {
                Console.WriteLine("Nie podałeś liczby, tylko tekst ");
            }
            catch (Exception)
            {
                Console.WriteLine("Nieznany bład");
            }
            Console.ReadKey();

            //instrukcje niebepzpieczne to takie, które pracuja na danych z zewnatrz 
            // -np konsola, intrefejs desktopowy, webowy lub inny, lub zewntrzne api, baza danych lub dowolne inne źródło 


        }
    }
}
