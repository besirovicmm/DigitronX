using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitron
{
    class Program
    {
        static void Main(string[] args)
        {

            //Unosimo komandu za racunanje
            Console.WriteLine("Unesite dva broja i operaciju. Npr : 1000-200");
            string unos = Console.ReadLine();

            //na kojim mestima da delimo unos
            string[] ignorisi = { "-", " ", "+", "*", "/"};

            //delimo unos i delove stavljamo u niz "delovi"
            string[] delovi = unos.Split(ignorisi, StringSplitOptions.RemoveEmptyEntries);

            //pretvaramo tekst u brojeve
            double a = double.Parse(delovi[0]);
            double b = double.Parse(delovi[1]);

            //Pretrazujemo unos u potrazi za sledecim operacijama
            bool oduzimanje = unos.Contains("-");
            bool sabiranje = unos.Contains("+");
            bool mnozenje = unos.Contains("*");
            bool deljenje = unos.Contains("/");

            
            //Obrada i stampanje rezultata
            if (oduzimanje)
            {
                Console.WriteLine(  );
                Console.WriteLine(a-b);
            }
            else if (sabiranje)
            {
                Console.WriteLine(a + b);
            }
            else if (mnozenje)
            {
                Console.WriteLine(a * b);
            }
            else if (deljenje)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("pogresan unos");
            }

            Console.ReadLine();
        
        }
    }
}
