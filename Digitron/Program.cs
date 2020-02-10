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

            string[] ignorisi = { "-", " ","+","*","/"};


            Console.WriteLine("Unesite dva broja i operaciju. Npr : 1000-200");
            string unos = Console.ReadLine();


            string[] delovi = unos.Split(ignorisi, StringSplitOptions.RemoveEmptyEntries);

            bool oduzimanje = unos.Contains("-");
            bool sabiranje = unos.Contains("+");
            bool mnozenje = unos.Contains("*");
            bool deljenje = unos.Contains("/");

            double a = double.Parse(delovi[0]);
            double b = double.Parse(delovi[1]);

            if (oduzimanje)
            {
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
