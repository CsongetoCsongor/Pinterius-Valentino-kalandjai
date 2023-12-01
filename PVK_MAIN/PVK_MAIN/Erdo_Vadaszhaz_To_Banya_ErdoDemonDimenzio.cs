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

            if (jozansag <= 30)
            {
                elozo_hely_uzenete = "";
                ErdoDemonDimenzio();
            }

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

        static void ErdoDemonDimenzio()
        {
            Console.Clear();
            helyszin = "DÉMON DIMENZIÓ";
            IrjaKiAStatokat("A démonok hívásának nem tudtál ellen állni, egy alternatív valóságba estél és megtámadott egy démon.");

            Console.WriteLine("BOGNÁR EXAEL VAGYOK, DÉMONOK URA, VILÁGOK PUSZTÍTÓJA ÉS C# PROGRAMOZÓ TANÁR!");
            Console.WriteLine("MINDEM ÓRÁMAT MEGKESERÍTETTE, EZÉRT MOST BOSSZÚT ÁLLOK!");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elfutsz a démon elől...");
            Console.WriteLine("\t2. Rátámadsz a démonra...");
            int input = BekerLehetosegek(2);

            if (input == 1)
            {

                if (jozansag >= 20)
                {
                    Console.WriteLine("Szerencséd volt, elég józan voltál, hogy elfuss...");
                    Console.ReadKey();
                    elozo_hely_uzenete = "A DÉMON DIMENZIÓ nagyon kikészített...";
                    Otthon();
                }
                else
                {
                    Console.WriteLine("Túl részeg voltál és megbotlottál egy igazságtáblában, a démon pedig kiszítta a lelkedet.");
                    Console.ReadKey();
                    
                    //Pokol();
                }

                
            }
            else if(input == 2)
            {
                if (verszomj == 100)
                {
                    Console.WriteLine("A démont megragadtad a farkánál és földhöz vágtad, letépted a szárnyait majd a lehelleteddel megölted.");
                    Console.ReadKey();
                    elozo_hely_uzenete = "A DÉMON DIMENZIÓ kicsit kikészített, de örülsz győzelmednek.";
                    Otthon();
                }
                else
                {
                    Console.WriteLine("Nem voltál elég vérszomjas, hogy megöld a démont, ezért elégetett a pokol tüzével, és elkobozta lelkedet.");
                    Console.ReadKey();

                    //Pokol();
                }
            }
        }
    }
}
