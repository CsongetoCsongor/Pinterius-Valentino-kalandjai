using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Kikoto()
        {

            Console.Clear();
            if (kikoto_meglatogatva == false)
            {
                eletkedv -= 5;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                Ongyilkossag("A kikötőben megcsapott a halszag, ez elvette a maradék életkedved.");
                kikoto_meglatogatva = true;
            }

            helyszin = "Tenger hangja kikötő";
            IrjaKiAStatokat("Kimész a kikötőbe, megcsap a döglött halszag");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Belevizelsz a tengerbe");
            Console.WriteLine("\t2. Bemész a Horgászboltba");
            Console.WriteLine("\t3. Felszállsz a hajóra");
            Console.WriteLine("\t4. Visszamész a főútra");

            int input = BekerLehetosegek(4);
            if (input == 1)
            {
                Random rand = new Random();
                int szam = (rand.Next(1, 101));

                if (szam <= 20) 
                {
                    eletkedv += 10;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    jozansag += 5;
                    jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                    DetoxbaKuldes();

                    Console.WriteLine("Vizelés közben elkaptak a rendőrök és bevittek a börtönbe");

                    elozo_helyszin = "Tenger hangja kikötő";
                    elozo_hely_uzenete = "Bajba kerültél";

                    Console.ReadKey();

                    Mech_Borton();
                }
                else
                {
                    eletkedv += 10;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    jozansag += 5;
                    jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                    DetoxbaKuldes();

                    Console.WriteLine("Megúsztad a vizelést, a rendőrök pont kávézgattak");

                    elozo_helyszin = "Tenger hangja kikötő";
                    elozo_hely_uzenete = "Megkönnyebbültél";

                    Console.ReadKey();

                    Kikoto();
                }
                
            }
            else if (input == 2)
            {
                Console.WriteLine("Elindulsz a horgászbolt felé...");

                elozo_helyszin = "Tenger hangja kikötő";
                elozo_hely_uzenete = "Bementél a horgászboltba";

                Console.ReadKey();

                Horgaszbolt();
            }
            else if (input == 3)
            {
                Console.WriteLine("Elindulsz a hajó felé...");

                elozo_helyszin = "Tenger hangja kikötő";
                elozo_hely_uzenete = "Felszálltál a hajóra";

                Console.ReadKey();

                Hajo();
            }
            else if (input == 4)
            {
                elozo_helyszin = "Tenger hangja kikötő";
                elozo_hely_uzenete = "Visszamentél a főútra";

                Console.ReadKey();

                Fout();
            }
        }

        static void Horgaszbolt()
        {
            
            Console.Clear();
            if (horgaszbolt_meglatogatva == false)
            {
                eletkedv -= 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                Ongyilkossag("A boltban megérezted, az alkesz eladó szájszagát. Ez elvette maradék életkedved.");
                horgaszbolt_meglatogatva = true;
            }

            helyszin = "Down-kóros Delfin horgászbolt";
            IrjaKiAStatokat("Bemész a horgászboltba, ahol egy szakállas alkoholista üdvözöl; Szájszaga még a tiédnél is rosszabb");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Veszel egy horgászbotot, ami 20 krajcárba kerül");
            Console.WriteLine("\t2. Ha van, eladod neki a tengeri gyöngyöt, amiért 50 krajcárt fizet");
            Console.WriteLine("\t3. Köszönés nélkül elhagyod a horgászboltot");

            int input = BekerLehetosegek(3);
            if (input == 1)
            {
                if (penz >= 20)
                {
                    penz -= 20;
                    verszomj = 100;
                    Console.WriteLine("Vettél egy horgászbotot.");

                    Console.ReadKey();

                    Horgaszbolt();
                }
                else
                {
                    Console.WriteLine("Lelehelt a büdös szájszagával, mert nincs elég pénzed.");

                    Console.ReadKey();

                    Horgaszbolt();
                }

                elozo_helyszin = "Down-kóros Delfin horgászbolt";
                elozo_hely_uzenete = "Vettél egy profi horgászbotod, megjött a kedved horgászni menni.";

            }

            else if (input == 2)
            {
                if (tengeri_gyongy_birtoklasa == true)
                {
                    penz += 50;
                    tengeri_gyongy_birtoklasa = false;

                    Console.WriteLine("Rettentően jó üzlet volt, kitömöttek lettek a zsebeid.");

                    elozo_helyszin = "Down-kóros Delfin horgászbolt";
                    elozo_hely_uzenete = "Eladtad a gyöngyöt, meggazdagodtál.";

                    Console.ReadKey();

                    Horgaszbolt();
                }
                else
                {
                    Console.WriteLine("Csúnyán nézett rád mert nincs is nálad a gyöngy");

                    elozo_helyszin = "Down-kóros Delfin horgászbolt";
                    elozo_hely_uzenete = "Még nincsen nálad a tengeri gyöngy";

                    Console.ReadKey();

                    Horgaszbolt();
                }
                
            }
            else if (input == 3)
            {
                elozo_helyszin = "Down-kóros Delfin horgászbolt";
                elozo_hely_uzenete = "Köszönés nélkül kimentél a boltból, az eladó csúnyán nézett utánad";

                Console.ReadKey();

                Kikoto();

            }
            
        }
    }
}
