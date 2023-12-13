using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Bank()
        {

            Console.Clear();
            if (ogrek_megolve)
            {

                helyszin = "Bank előtt";
                elozo_helyszin = "Főút";
                elozo_hely_uzenete = "Nem tudtál bemenni a bankba";

                Console.WriteLine("A bank bezárt egy merénylő miatt...");

                Console.ReadKey();
                Fout();
            }
            helyszin = "Zsebtolvajok Világuralma Bank";
            if (jozansag <= 50)
            {
                Bankrablas();
            }
            eletkedv -= 10;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            Ongyilkossag("A sok kalapos ogre elvette a maradék életkedvedet.");
            IrjaKiAStatokat("Bemész a bankba és megpillantassz egy csomó nagyorrú kalapos ogrét.");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");

            Console.WriteLine("\t1. - Leveszel a számládról pénzt");
            Console.WriteLine("\t2. - Antiogreista megjegyzéseket teszel");
            Console.WriteLine("\t3. - Kizsebelsz egy kapzsi ogrét");
            Console.WriteLine("\t4. - Kimész a főútra");

            int x = BekerLehetosegek(4);

            if (x == 1 && penz_szamlarol_leveve == false)
            {
                penz += 100;

                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "A számlád nullázódott, többet nem tudsz levenni";

                Console.WriteLine("100 krajcárt szereztél...");

                Console.ReadKey();
                Bank();
            }

            else if (x == 1 && penz_szamlarol_leveve)
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "El lett már egyszer mondva, hogy a számládon van kereken NULLA krajcár";

                Console.WriteLine("Érdekes módon nincs semmi a számládon...");

                Console.ReadKey();
                Bank();
            }

            else if (x == 2 && ogrek_szidva == false)
            {
                ogrek_szidva = true;

                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "Az ogrék megsértődtek, te pedig a szemükbe röhögtél";

                Console.WriteLine("Alsóbbrendűnek nevezted az ogrékat...");

                Console.ReadKey();
                Bank();
            }

            else if (x == 2 && ogrek_szidva)
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "Már nem fordítottak rád figyelmet az ogrék";

                Console.WriteLine("Ismét azt kiabálod, hogy te életrevalóbb fajhoz tartozol...");

                Console.ReadKey();
                Bank();
            }

            else if (x == 3 && aranykulcs_birtoklasa == false)
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "Találtál egy aranykulcsot";

                Console.WriteLine("Sikeresen kizsebeled azt a fránya ogrét...");

                Console.ReadKey();
                Bank();
            }

            else if (x == 3 && aranykulcs_birtoklasa)
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "Már semmit sem találtál";

                Console.WriteLine("Az ogre zsebe csodával határos módon üres...");

                Console.ReadKey();
                Bank();
            }

            else
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank";
                elozo_hely_uzenete = "Elhagytad a bankot";

                Console.WriteLine("Az ajtón kifele menet még fingasz egy nagyot...");

                Console.ReadKey();
                Fout();
            }
        }

        static void Bankrablas()
        {
            Console.Clear();
            helyszin = "Zsebtolvajok Világuralma Bank Rablása";
            IrjaKiAStatokat("Az alkoholtól kedved támad megdönteni az ismert világrendet és kárt tenni az ogrék vagyonában, szóval úgy döntessz, hogy kirabolod a bankot");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Túszokat ejtesz");
            Console.WriteLine("\t2. - Megőlsz mindenkit");

            int x = BekerLehetosegek(2);

            if (x == 1)
            {
                elozo_helyszin = "Zsebtolvajok Világuralma Bank Rablása";
                elozo_hely_uzenete = "Börtönbe kerültél bankrablásért";

                Console.WriteLine("A túszokat nem kötözted le rendesen és agyonvertek...");

                Console.ReadKey();
                //Borton();
            }

            else if (x == 2 && verszomj == 100)
            {
                ogrek_megolve = true;
                aranykulcs_birtoklasa = true;

                eletkedv = 100;
                penz += 300;

                elozo_helyszin = "Zsebtolvajok Világuralma Bank Rablása";
                elozo_hely_uzenete = "Egyik holttesten találtál egy aranykulcsot";

                Console.WriteLine("Senki sem tudta megvédeni magát...");

                Console.ReadKey();
                Fout();
            }

            else
            {
                elozo_helyszin = "BankZsebtolvajok Világuralma Bank Rablásarablás";
                elozo_hely_uzenete = "A rendőrök lelőttek";

                Console.WriteLine("Az ogrék időben értesítik a hatóságokat...");

                Console.ReadKey();
                //Pokol();
            }
        }
    }
}
