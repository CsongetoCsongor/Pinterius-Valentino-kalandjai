using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Erdo()
        {
            Console.Clear();
            helyszin = "Sárguló Sörerdő";
            IrjaKiAStatokat("Az erdőbe érve gonosz démonok hívását hallod. Mintha a pokolból millió ember sikolya szólna hozzád...");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Megeszel egy furcsa gombát");
            Console.WriteLine("\t2. Megiszod egy sárga fa gyantáját");
            Console.WriteLine("\t3. Lemész a bányába");
            Console.WriteLine("\t4. Elmész a tóhoz");
            Console.WriteLine("\t5. Bemész a vadászházba");
            Console.WriteLine("\t6. Visszamész a főútra");
            int input = BekerLehetosegek(6);

            if (input == 1)
            {

                eletkedv += 5;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                jozansag -= 5;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                verszomj += 10;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

                Console.WriteLine("Bolondgombát ettél. Szerencsére az immunrendszered már megszokta a terhelést, szóval nem kerültél detoxba.");
                Console.ReadKey();
                Console.Clear();
                Erdo();
            }
            else if (input == 2)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                jozansag -= 10;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                

                Console.WriteLine("A gyanta Rákóczi Sör volt. Nem véletlenül nevezik ezt a helyet SÖRerdőnek...");
                Console.ReadKey();
                Console.Clear();
                Erdo();
            }
            else if (input == 3)
            {
                Console.WriteLine("Elindulsz a bánya felé...");
                elozo_helyszin = "Sárguló Sörerdő";
                Console.ReadKey();
                elozo_hely_uzenete = "";
                //Banya();
            }
            else if (input == 4)
            {

                Console.WriteLine("Elindulsz a tó felé...");
                elozo_helyszin = "Sárguló Sörerdő";
                Console.ReadKey();
                elozo_hely_uzenete = "";
                //To();
            }
            else if(input == 5)
            {
                Console.WriteLine("Elindulsz a vadaszhaz felé...");
                elozo_helyszin = "Sárguló Sörerdő";
                Console.ReadKey();
                elozo_hely_uzenete = "";
                //Vadaszhaz();
            }
            else if(input == 6)
            {
                elozo_helyszin = "Sárguló Sörerdő";
                Fout();
            }
        }
    }
}
