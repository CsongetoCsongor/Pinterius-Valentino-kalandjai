﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Otthon()
        {
            helyszin = "Otthon";
            IrjaKiAStatokat("Felébredsz otthonodban, és rettentően másnapos vagy. Vérre szomjazol...");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Összeokádod a WC-t");
            Console.WriteLine("\t2. Tömsz egyet");
            Console.WriteLine("\t3. Kimész a kertbe");
            Console.WriteLine("\t4. Kimész a főútra");
            int input = BekerLehetosegek(4);

            if (input == 1)
            {

                if (wc_osszeokadva == false)
                {
                    eletkedv += 10;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    jozansag += 10;
                    jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                    wc_osszeokadva = true;
                }

                Console.WriteLine("Kiadtad magadból, amit ki kellett...");
                Console.ReadKey();
                Console.Clear();
                Otthon();
            }
            else if (input == 2)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                jozansag -= 10;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                verszomj += 10;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

                Console.WriteLine("A SIBERIA bement az ínyedhez, kicsit beszédültél.");
                Console.ReadKey();
                Console.Clear();
                Otthon();
            }
            else if (input == 3)
            {
                Console.Clear();
                elozo_helyszin = "Otthon";
                elozo_hely_uzenete = "Elhagytad a házat.";
                Kert();
            }
            else if (input == 4)
            {
                Console.Clear();
                //Fout();
            }

        }

        static void Kert()
        {
            eletkedv -= 20;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

            helyszin = "Kert";
            IrjaKiAStatokat("Kimentél a kertbe. Megcsípett egy méhe (véleményed szerint a nagyorrú kalapos ogrék miatt van).");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Megölöd a méhét [min. 60 vérszomj]");
            Console.WriteLine("\t2. Odamész a virágágyáshoz");
            Console.WriteLine("\t3. Visszamész a házba");

            int input = BekerLehetosegek(3);

            if (input == 1)
            {

                if(mehe_megolve == false)
                {
                    eletkedv += 20;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                    Console.WriteLine("Megölted azt a fránya méhet, ami megcsípett. Ez melegséggel tölt el...");
                    mehe_megolve = true;
                }
                else
                {
                    Console.WriteLine("Rátapostál mégegyszer...");
                }
                

                Console.ReadKey();
                Console.Clear();
                Kert();
            }
            else if (input == 2)
            {


                penz += 30;
                Console.WriteLine("Megtaláltad a bukszádat. Volt benne 30 krajcár és egy hamisított személyi is, Gipsz jakab névvel.");

                Console.ReadKey();
                Console.Clear();
                Kert();
            }
            else if (input == 3)
            {

                
                Console.Clear();
                elozo_helyszin = "Kert";
                elozo_hely_uzenete = "Bementél a házba, majdnem megbotlottál a küszöbben.";
                Otthon();
            }


        }


    }
}