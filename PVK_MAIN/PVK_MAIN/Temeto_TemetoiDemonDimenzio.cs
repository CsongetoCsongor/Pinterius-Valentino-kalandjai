using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Temeto()
        {
            Console.Clear();
            helyszin = "Temető (Ingyen Protein Temető)";
            IrjaKiAStatokat("Nekrofil hajlamaid a temetőbe vittek téged; A halottak hívását hallod");
            Console.WriteLine();

            if (jozansag <= 40 && eletkedv <= 50)
            {
                elozo_hely_uzenete = "Életkedved és józanságod alacsony volt, ezért egy más dimenzióba kerültél";
                TemetoiDemonDimenzio();
            }

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Meggyalázol egy sírt");
            Console.WriteLine("\t2. - Megeszel egy koszorút");
            Console.WriteLine("\t3. - Visszamész a főútra");

            int x = BekerLehetosegek(3);

            if (x == 1)
            {
                if (jozansag <= 40)
                {
                    eletkedv += 10;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                    elozo_helyszin = "Temető";
                    elozo_hely_uzenete = "Sírgyalázásért letartóztattak";

                    Console.WriteLine("A sírt meggyalázva nagyot röhögsz, de hátad mögött kék és piros villanásokat látsz...");

                    Console.ReadKey();
                    //Borton();
                }

                else
                {
                    elozo_helyszin = "Temető";
                    elozo_hely_uzenete = "Meggondoltad magad, valami mást akarsz választani";

                    Console.WriteLine("Ehhez még kéne inni, nemde barátom?");

                    Console.ReadKey();
                    Temeto();
                }
            }

            else if (x == 2 && koszoru_elfogyasztva == false)
            {
                koszoru_elfogyasztva = true;

                elozo_helyszin = "Temető";
                elozo_hely_uzenete = "Éhen maradtál";

                Console.WriteLine("Megettél egy koszorút, az íze egy bizonyos teáéra emlékeztet...");

                Console.ReadKey();
                Temeto();
            }

            else if (x == 2 && koszoru_elfogyasztva)
            {
                elozo_helyszin = "Temető";
                elozo_hely_uzenete = "Nem tudtál koszorút enni";

                Console.WriteLine("Elfogytak a koszorúk, valami gyökér megette őket...");

                Console.ReadKey();
                Temeto();
            }

            else
            {
                elozo_helyszin = "Temető";
                elozo_hely_uzenete = "Kimentél a temetőből";

                Console.WriteLine("A kapun kimész a temetőből...");

                Console.ReadKey();
                Fout();
            }
        }

        static void TemetoiDemonDimenzio()
        {
            Console.Clear();
            helyszin = "Temetői Démon Dimenzió";
            IrjaKiAStatokat("Egy francia-szobalányruhában lévő kísértet áll előtted, és azzal fenyeget, hogy elvesz mindent, ami fontos neked");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Mi fontos neked?");

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - A bukszád");
            Console.WriteLine("\t2. - A daliás páncélod");
            Console.WriteLine("\t3. - Az enyhén kellemetlenül balra hajló kardod");
            Console.WriteLine("\t4. - A család (hazudsz)");

            int x = BekerLehetosegek(4);

            if (x == 1)
            {
                penz = 0;

                elozo_helyszin = "Temetői Démon Dimenzió";
                elozo_hely_uzenete = "A kísértet megfosztott minden pénzedtől";

                Console.ReadKey();
                Fout();
            }

            else if (x == 2)
            {
                eletkedv -= 50;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Temetői Démon Dimenzió";
                elozo_hely_uzenete = "A kísértet elvette a sörszagú páncélod és te szomorú lettél";

                Console.ReadKey();
                Fout();
            }

            else if (x == 3)
            {
                verszomj -= 50;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

                elozo_helyszin = "Temetői Démon Dimenzió";
                elozo_hely_uzenete = "A kísértet elvette a kardod és hirtelen nem vagy olyan vérszomjas";

                Console.ReadKey();
                Fout();
            }

            else
            {
                Console.WriteLine("A kísértet nem hisz neked, bizonyítékot kér");

                if (jegygyuru_birtoklasa == true)
                {
                    int y = BekerLehetosegek(2);

                    Console.WriteLine("Lehetőségek:");
                    Console.WriteLine("\t1. - Megmutatod neki a jeggyűrűt, amit találtál");
                    Console.WriteLine("\t2. - Megesküszöl, hogy igazat mondasz");

                    jegygyuru_birtoklasa = false;

                    if (y == 1)
                    {
                        elozo_helyszin = "Temetői Démon Dimenzió";
                        elozo_hely_uzenete = "A hazugság bevált, a főúton ébredtél";

                        Console.WriteLine("A kísértet impotenssé tett...");

                        Console.ReadKey();
                        Fout();
                    }

                    else
                    {
                        elozo_helyszin = "Temetői Démon Dimenzió";
                        elozo_hely_uzenete = "A hazugság nem vált be, meghaltál";

                        Console.WriteLine("Hát testvér, szarul hazudsz...");

                        Console.ReadKey();
                        //Pokol();
                    }
                }

                else
                {
                    Console.WriteLine("A szó nem elég...");

                    elozo_helyszin = "Temetői Démon Dimenzió";
                    elozo_hely_uzenete = "A hazugság nem vált be, meghaltál";

                    Console.ReadKey();
                    //Pokol();
                } 
            }
        }
    }
}
