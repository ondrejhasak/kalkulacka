using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka_složitější
{
    class Program
    {
        static void Main(string[] args)
        {
            double cislo1, cislo2, vysledek = 0;
            string operace;

            cislo1 = double.Parse(Console.ReadLine());
            cislo2 = double.Parse(Console.ReadLine());
            operace = Console.ReadLine();

            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
            }
            else if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
            }
            else if (operace == "*")
            {
                vysledek = cislo1 * cislo2;
            }
            else if (operace == "/")
            {
                vysledek = cislo1 / cislo2;
            }

            else
            {
                Console.WriteLine("Špatná operace");
            }

            Console.WriteLine("Výsledek: " + vysledek);
            Console.ReadKey();
        }
    }
}
