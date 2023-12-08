using System;
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

            eletkedv += 10;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            verszomj += 5;
            verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

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
                penz -= 30;
                eletkedv = 100;

                elozo_helyszin = "Retek Taverna étterem";
                elozo_hely_uzenete = "Nagyon ízlett a püfűthús, egyből jobb lett a kedved";

                Console.ReadKey();

                Etterem();
            }
            else if (input == 2)
            {
                if (jozansag <= 50)
                {
                    elozo_helyszin = "Retek Taverna étterem";
                    elozo_hely_uzenete = "Az asztalra ürítettél, és elkaptak a rendőrök";

                    Console.ReadKey();

                    //Borton();
                }
                else
                {
                    elozo_helyszin = "Retek Taverna étterem";
                    elozo_hely_uzenete = "Túl józan vagy még ilyet csinálni";

                    Console.ReadKey();

                    Etterem();
                }
            }
            else if (input == 3)
            {
                elozo_helyszin = "Retek Taverna étterem";
                elozo_hely_uzenete = "Kimentél a főútra";

                Console.ReadKey();

                //Fout();
            }
        }
    }
}
