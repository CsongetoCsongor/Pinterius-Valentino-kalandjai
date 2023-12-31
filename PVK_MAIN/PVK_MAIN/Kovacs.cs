﻿using System;
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
            SzazasVerszomj();
            helyszin = "Varázslatos Kalapács Varázsló";
            IrjaKiAStatokat("A kovácsműhelyben találod magad, nagy a kínálat");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Veszel egy fegyvert, ami 70 krajcárba kerül");
            Console.WriteLine("\t2. Veszel egy páncéldarabot, ami 100 krajcárba kerül");
            Console.WriteLine("\t3. Elhagyod az épületet");

            int input = BekerLehetosegek(3);
            if (input == 1)
            {

                if (penz >= 70)
                {
                    penz -= 70;
                    verszomj += 40;
                    verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);
                    Console.WriteLine("Vettél egy erős fegyvert");
                    fegyver_birtoklasa = true;

                    Console.ReadKey();

                    Kovacs();
                }
                else
                {
                    Console.WriteLine("A kovács csúnyán nézett rád, mert nincs elég pénzed");

                    Console.ReadKey();

                    Kovacs();
                }

                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "Nagyon pacek stukkert vettél, egyből megjött a kedved egy kis gyilkolászásra...";
                
            }
            else if (input == 2)
            {

                if (penz >= 100)
                {
                    penz -= 100;
                    eletkedv += 40;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    Console.WriteLine("Vettél egy nyíl álló mellényt");
                    pancel_birtoklasa = true;

                    Console.ReadKey();

                    Kovacs();
                }
                else
                {
                    Console.WriteLine("A kovács csúnyán nézett rád, mert nincs elég pénzed");

                    Console.ReadKey();

                    Kovacs();
                }

                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "Az nyíl álló mellényed tökéletesen passzol";

            }
            else if (input == 3)
            {
                

                elozo_helyszin = "Varázslatos Kalapács Varázsló";
                elozo_hely_uzenete = "";
                Console.WriteLine("Kimész az ajtón...");

                Console.ReadKey();

                Fout();
            }
        }
    }
}
