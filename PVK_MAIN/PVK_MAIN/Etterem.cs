using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Etterem()
        {
            Console.Clear();
            if (etterem_meglatogatva == false)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                verszomj += 5;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);
                etterem_meglatogatva = true;
            }
            

            helyszin = "Retek Taverna étterem";
            IrjaKiAStatokat("Megcsap a püfűthús és szalmakrumpli illata és megjön az étvágyad");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Eszel, ami 30 krajcárba kerül");
            Console.WriteLine("\t2. Az egyik asztalra ürítesz");
            Console.WriteLine("\t3. Kimész a Főútra");

            int input = BekerLehetosegek(3);
            if (input == 1)
            {
                if (penz >= 30)
                {
                    penz -= 30;
                    eletkedv = 100;
                    Console.WriteLine("Egy csodálatosat lakomáztál, amitől jobb lett a kedved");

                    Console.ReadKey();

                    Etterem();
                }
                else
                {
                    Console.WriteLine("A pincér rádkiáltott, mert nincs elég pénzed");

                    Console.ReadKey();

                    Etterem();
                }               

                elozo_helyszin = "Retek Taverna étterem";
                elozo_hely_uzenete = "Nagyon ízlett a püfűthús, egyből jobb lett a kedved";

            }
            else if (input == 2)
            {
                if (jozansag <= 50)
                {
                    Console.WriteLine("Az asztalra ürítetté, és elkaéptak a rendőrök");

                    elozo_helyszin = "Retek Taverna étterem";
                    elozo_hely_uzenete = "Az asztalra ürítettél";

                    Console.ReadKey();

                    //Borton();
                }
                else
                {
                    Console.WriteLine("Túl józan vagy még ilyet csinálni");


                    elozo_helyszin = "Retek Taverna étterem";
                    elozo_hely_uzenete = "Inkább nem csináltad meg";

                    Console.ReadKey();

                    Etterem();
                }
            }
            else if (input == 3)
            {
                elozo_helyszin = "Retek Taverna étterem";
                elozo_hely_uzenete = "Kimentél a főútra";

                Console.ReadKey();

                Fout();
            }
        }
    }
}
