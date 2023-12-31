﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Osveny()
        {
            Console.Clear();
            SzazasVerszomj();
            helyszin = "Cserkészlány Csodaösvény";
            IrjaKiAStatokat("Kimész a természetbe - sokkolóan hat rád a tapasztalat");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");

            Console.WriteLine("\t1. Elmész a Kárpátokba");
            Console.WriteLine("\t2. Leokádsz egy cserkészlányt [max 50 józanság]");
            Console.WriteLine("\t3. Visszamész a főútra");

            int x = BekerLehetosegek(3);

            if (x == 1 && karpatok_meglatogatva == false)
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "A pirossal jelzett fákat követted és eljutottál a Kárpátokba";

                Console.ReadKey();
                Hegy();
            }

            else if (x == 1 && karpatok_meglatogatva == true)
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "Lusta vagy, ezért inkább az ösvényen maradtál";

                Console.WriteLine("Ezt az utat már egyszer megjártad");

                Console.ReadKey();
                Osveny();
            }

            else if (x == 2 && jozansag <= 50)
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "Ez szerencsés rókázás volt, találtál egy jegygyűrűt";
                jegygyuru_birtoklasa = true;
                Console.WriteLine("A cserkészlány sírva elfutott, hányásodban valami csillog");

                Console.ReadKey();
                Osveny();
            }

            else if (x == 2 && jozansag > 50)
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "Piros lett a pofád";

                eletkedv -= 20;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                Ongyilkossag("Nem sikerült semmit felöklendezni, a cserkészlány felpofozott. Ez a megalázó élmény elvette maradék életkedved.");

                Console.WriteLine("Nem sikerült semmit felöklendezni, a cserkészlány felpofozott.");

                Console.ReadKey();
                Osveny();
            }

            else
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "Na ez aztán hasznos séta volt";

                Console.WriteLine("Elindulsz a főút felé");

                Console.ReadKey();
                Fout();
            }
        }

        static void Hegy()
        {
            Console.Clear();
            SzazasVerszomj();
            eletkedv += 50;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            helyszin = "Kárpátok";
            IrjaKiAStatokat("Megpillantod a Kárpátok szent bércét");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elkezdesz Kárpátiát Dalolni (Pálinka) [max 60 józanság]");
            Console.WriteLine("\t2. Továbbmész a vízeséshez");

            int x = BekerLehetosegek(2);

            if (x == 1 && jozansag <= 60)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Kárpátok";
                elozo_hely_uzenete = "Énekhangod hallatán Árpád hős magzatjai felvirágoztának";

                Console.WriteLine("A jó magyar pálinkának");
                Console.WriteLine("Nincsen párja");
                Console.WriteLine("Nincsen párja");
                Console.WriteLine("Egyedül van mint a magyar");
                Console.WriteLine("A világba");
                Console.WriteLine("A világba");
                Console.WriteLine("Szilva, körte, cseresznye");
                Console.WriteLine("Éljen a haza!");
                Console.WriteLine("Egészségünkre!");
                Console.WriteLine("");
                Console.WriteLine("A jó magyar pálinkának");
                Console.WriteLine("Nincsen párja");
                Console.WriteLine("Nincsen párja");
                Console.WriteLine("");
                Console.WriteLine("Aranyból van, gyémántból van");
                Console.WriteLine("Minden cseppje");
                Console.WriteLine("Minden cseppje");
                Console.WriteLine("Olyan mint a tűzről pattant");
                Console.WriteLine("Kis menyecske");
                Console.WriteLine("Kis menyecske");
                Console.WriteLine("Szilva, körte, cseresznye");
                Console.WriteLine("Éljen a haza!");
                Console.WriteLine("Egészségünkre!");
                Console.WriteLine("");
                Console.WriteLine("Aranyból van, gyémántból van");
                Console.WriteLine("Minden cseppje");
                Console.WriteLine("Minden cseppje");
                Console.WriteLine("");
                Console.WriteLine("Orvosság ez akár milyen");
                Console.WriteLine("Nyavalyára");
                Console.WriteLine("Kikúrálja");
                Console.WriteLine("Ezért jár az magyar ember");
                Console.WriteLine("A csárdába");
                Console.WriteLine("A csárdába");
                Console.WriteLine("Szilva, körte, cseresznye");
                Console.WriteLine("Éljen a haza!");
                Console.WriteLine("Egészségünkre!");
                Console.WriteLine("");
                Console.WriteLine("Orvosság ez akár milyen");
                Console.WriteLine("Nyavalyára");
                Console.WriteLine("Kikúrálja");
                Console.WriteLine("");
                Console.WriteLine("Erős mint a háromszor varrt");
                Console.WriteLine("Csizma szára");
                Console.WriteLine("Csizma szára");
                Console.WriteLine("Amiben bemasírozunk");
                Console.WriteLine("Kolozsvárra");
                Console.WriteLine("Kolozsvárra");
                Console.WriteLine("Szilva, körte, cseresznye");
                Console.WriteLine("Éljen a haza!");
                Console.WriteLine("Egészségünkre!");
                Console.WriteLine("");
                Console.WriteLine("Erős mint a háromszor varrt");
                Console.WriteLine("Csizma szára");
                Console.WriteLine("Csizma szára");
                Console.WriteLine("Szilva, körte, cseresznye");
                Console.WriteLine("Éljen a haza!");
                Console.WriteLine("Egészségünkre!");

                Console.ReadKey();
                Hegy();
            }

            else if (x == 1 && jozansag > 60)
            {
                elozo_helyszin = "Kárpátok";
                elozo_hely_uzenete = "Bendegúz vére szép hazát nyert volna, de te nem ittál elég subidubit";

                Console.WriteLine("Alkohol hiányában nem emlékszel a szövegre");

                Console.ReadKey();
                Hegy();
            }

            else
            {
                elozo_helyszin = "Kárpátok";
                elozo_hely_uzenete = "A Kárpátokban az üldözött honját lelte a hazában";

                Console.WriteLine("A vízeséshez mész, szerinted le tudsz csúszni rajta");

                Console.ReadKey();
                Vizeses();
            }
        }

        static void Vizeses()
        {
            Console.Clear();
            SzazasVerszomj();
            jozansag += 5;
            jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
            helyszin = "Nedves Combok vízesés";
            IrjaKiAStatokat("A vízesés látványa lenyűgöz, nagyon nedvesek lesznek a combjaid, egy kicsi alkohol kimegy belőled");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Belefojtod magad a vízbe");
            Console.WriteLine("\t2. Iszol a tiszta vízből");
            Console.WriteLine("\t3. Lecsúszol a vízesésen");

            int x = BekerLehetosegek(3);

            if (x == 1)
            {
                elozo_helyszin = "Nedves Combok Vízesés";
                elozo_hely_uzenete = "Pinterius Valentino meghalt, halál oka: fulladásos öngyilkosság";

                Console.WriteLine("A víz alá szorítod méretes nyakad és nem jössz fel onnan...");

                Console.ReadKey();
                Pokol();
            }

            else if (x == 2)
            {
                jozansag = 100;

                elozo_helyszin = "Nedves Combok Vízesés";
                elozo_hely_uzenete = "A tiszta víztől kijózanodtál";

                Console.WriteLine("A tiszta víz minden kotnyeles kábultságot kiküszöböl keretrendszeredből...");

                Console.ReadKey();
                Vizeses();
            }

            else if (x == 3 && jozansag >= 90)
            {
                elozo_helyszin = "Nedves Combok Vízesés";
                elozo_hely_uzenete = "Sikeresen lecsúsztál a vízesésen";

                Console.WriteLine("Szerencsére elég józan vagy és tuddod magad kormányozni a sodrásban...");

                Console.ReadKey();
                Volgy();
            }

            else 
            {
                elozo_helyszin = "Nedves Combok Vízesés";
                elozo_hely_uzenete = "Meghaltál és a purgatóriumba kerültél";

                Console.WriteLine("A sok subidubi miatt bevered az értelmes fejedet egy sziklába a vízesésen...");

                Console.ReadKey();
                Purgatorium();
            }
        }

        static void Volgy()
        {
            Console.Clear();
            SzazasVerszomj();
            helyszin = "Nem Nem Soha! Völgy";
            eletkedv -= 5;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            Ongyilkossag("Eszedbe jutott Trianon. Ez levitte a maradék életkedved.");
            IrjaKiAStatokat("Eszedbe jut Trianon");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elüvöltöd magad, hogy \"VESSZEN TRIANON!\" [min 50 vérszomj]");
            Console.WriteLine("\t2. Elkezdesz legelni [min 40 életkedv]");
            Console.WriteLine("\t3. Visszamész az ösvényre");

            int x = BekerLehetosegek(3);

            if (x == 1 && verszomj >= 50)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Nem Nem Soha! Völgy";
                elozo_hely_uzenete = "Az ordibálásod boldoggá tett téged";

                Console.WriteLine("VESSZEN TRIANON!!!");

                Console.ReadKey();
                Volgy();
            }

            else if (x == 1 && verszomj < 50)
            {
                elozo_helyszin = "Nem Nem Soha! Völgy";
                elozo_hely_uzenete = "Nem voltál elég ideges, ezért csak suttogtál";

                Console.WriteLine("vesszen trianon :(");

                Console.ReadKey();
                Volgy();
            }

            else if (x == 2 && eletkedv >= 40)
            {
                elozo_helyszin = "Nem Nem Soha! Völgy";
                elozo_hely_uzenete = "Megettél egy bolondgombát";
                jozansag -= 10;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                DetoxbaKuldes();
                Console.WriteLine("Furcsa ízt érzel a szádban...");

                Console.ReadKey();
                Volgy();
            }

            else if (x == 2 && eletkedv < 40)
            {
                elozo_helyszin = "Nem Nem Soha! Völgy";
                elozo_hely_uzenete = "Nem legeltél";

                Console.WriteLine("Szomorú vagy, nincs kedved legelni...");

                Console.ReadKey();
                Volgy();
            }

            else
            {
                elozo_helyszin = "Nem Nem Soha! Völgy";
                elozo_hely_uzenete = "A túrád véget ért";

                Console.WriteLine("Csodával határos módon visszatalálsz az ösvényre");

                Console.ReadKey();
                Osveny();
            }
        }
    }
}
