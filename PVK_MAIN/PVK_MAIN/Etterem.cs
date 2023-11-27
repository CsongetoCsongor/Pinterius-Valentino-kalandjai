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
            eletkedv += 10;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            verszomj += 5;
            verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

            helyszin = "Étterem";
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
                Etterem();
            }
            else if (input == 2)
            {
                if (jozansag <= 50)
                {
                    Console.WriteLine("Az asztalra ürítettél, és elkaptak a rendőrök");
                    //Borton();
                }
                else
                {
                    Etterem();
                }
            }
            else if (input == 3)
            {
                //Fout();
            }
        }
    }
}
