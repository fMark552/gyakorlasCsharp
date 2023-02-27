using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    internal class Program
    {
        static void feladatok()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Még 1 szám: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} szám a nagyobb");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} a nagyobb szám");
            }
            else
            {
                Console.WriteLine("egyenlő a két szám");
            }

            Console.WriteLine("");
            List<int> lista = new List<int>();
            Console.WriteLine("Adjon meg egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            lista.Add(szam);
            Console.WriteLine("szám: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            lista.Add(szam2);
            Console.WriteLine("szám: ");
            int szam3 = Convert.ToInt32(Console.ReadLine());
            lista.Add(szam3);
            Console.WriteLine($"{lista.Max()} a legnagyobb szám");
            Console.WriteLine($"{lista.Min()} a legkisebb szám");
        }
        static void Main(string[] args)
        {
            feladatok();

            Console.ReadKey();
        }
    }
}
