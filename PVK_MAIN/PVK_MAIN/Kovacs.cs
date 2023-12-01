using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Kovacs()
        {
            Console.Clear();

            helyszin = "Varázslatos Kalapács Varázsló";
            IrjaKiAStatokat("A kovácsműhelyben találod magad, nagy a kínálat");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Veszel egy fegyvert, ami 70 krajcárba kerül");
            Console.WriteLine("\t2. Veszel egy páncéldarabot, ami 100 krajcárba kerül");
            Console.WriteLine("\t3. Az árak láttán öklendezve kifutsz");

            int input = BekerLehetosegek(3);
            if (input == 1)
            {
                penz -= 70;
                verszomj += 40;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "Nagyon pacek stukkert vettél, egyből megjött a kedved egy kis gyilkolászásra...";

                Console.ReadKey();

                Kovacs();
            }
            else if (input == 2)
            {
                penz -= 100;
                eletkedv += 40;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                Console.WriteLine();
                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "Az nyíl álló mellényed tökéletesen passzol";

                Console.ReadKey();

                Kovacs();
            }
            else if (input == 3)
            {
                eletkedv -= 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "Kifutottál egészen az utcáig";

                Console.ReadKey();

                //Fout();
            }
        }
    }
}
