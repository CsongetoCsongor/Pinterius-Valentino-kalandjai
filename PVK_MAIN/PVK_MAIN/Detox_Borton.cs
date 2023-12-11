using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Detox()
        {
            Console.Clear();
            helyszin = "Második Esély Klinika, Detoxikáló részleg";
            IrjaKiAStatokat("A véralkoholszinted túl magas volt, kiütötted magad. Szerencsédre rádtaláltak, és bevittek a detoxba.");

            Console.WriteLine("Kérdésekre kell válaszolnod, hogy leteszteljék, hogy elég józan vagy-e.");
            Console.WriteLine();
            Console.WriteLine("Vigyáz! Ha 2-nál többet hibázol megölnek, mert úgy ítélik, nem vagy hasznos tagja a társadalomnak.");
            Console.WriteLine();

            Random esely = new Random();

            int mistakes = 0;

            int rounds = 0;

            void feladat1()
            {
                Console.Clear();
                int a = esely.Next(1, 16);
                int b = esely.Next(1, 16);

                Console.WriteLine($"Mennyi {a} + {b}?");
                int valasz;

                do
                {
                    Console.Write("Válasz: ");

                }
                while (!int.TryParse(Console.ReadLine(), out valasz));

                if (valasz == a + b)
                {
                    Console.WriteLine("Helyes válasz!");
                    rounds++;
                }
                else
                {
                    Console.WriteLine("Hibát vétettünk!!!");
                    rounds++;
                    mistakes++;
                }
                
            }

            void feladat2()
            {
                Console.Clear();
                int a = esely.Next(1, 16);
                int b = esely.Next(1, 16);

                Console.WriteLine($"Mennyi {a} - {b}?");
                int valasz;

                do
                {
                    Console.Write("Válasz: ");

                }
                while (!int.TryParse(Console.ReadLine(), out valasz));

                if (valasz == a - b)
                {
                    Console.WriteLine("Helyes válasz!");
                    rounds++;
                }
                else
                {
                    Console.WriteLine("Hibát vétettünk!!!");
                    rounds++;
                    mistakes++;
                }

            }

            while (rounds <= 5 && mistakes <3)
            {
                if (rounds % 2 == 0)
                {
                    feladat1();
                }
                else
                {
                    feladat2();
                }
            }
            if(mistakes == 3)
            {
                Console.WriteLine("Meghaltál!");
            }
            else
            {
                Console.WriteLine("Kijutottál!");
            }

            
        }
    }
}
