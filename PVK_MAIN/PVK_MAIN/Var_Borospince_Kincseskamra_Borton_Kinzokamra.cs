using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Var()
        {
            Console.Clear();
            helyszin = "Világuralom Vár";
            IrjaKiAStatokat("Engedély nélkül bementél a várba, de az őrök nem mertek szólni, mert úgy néztél ki, mint az Antikrisztus.");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Lemész a borospincébe");
            Console.WriteLine("\t2. Bemész a börtönbe");
            Console.WriteLine("\t3. Kimész a főútra");
            int input = BekerLehetosegek(3);

            if (input == 1)
            {
                Console.WriteLine("Lemész a borospincébe...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár";
                Console.ReadKey();
                Borospince();
            }
            else if (input == 2)
            {
                Console.WriteLine("Bemész a börtönbe...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár";
                Console.ReadKey();
                Borton();
            }
            else if (input == 3)
            {
                Console.WriteLine("Kimész a főútra...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár";
                Console.ReadKey();
                Fout();
            }

            

            
        }

        static void Borospince()
        {
            Console.Clear();
            if (borospince_meglatogatva == false)
            {
                eletkedv += 15;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                borospince_meglatogatva = true;
            }


            helyszin = "Világuralom Vár, Borospince";
            IrjaKiAStatokat("Bent vagy a borospincében, megcsapott a borszag. Egyből jobb kedved lett.");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Nekiállsz fékezetlenül vedelni");
            Console.WriteLine("\t2. Bemész a kincseskamarába");
            Console.WriteLine("\t3. Visszamész a várba");

            int input = BekerLehetosegek(3);

            if (input == 1)
            {
                Console.WriteLine("Kihúztál egy dugót egy hordóból, aláhajoltás és megállás nélkül folyt a szádba a bor.");
                elozo_hely_uzenete = "Túl sok bort ittál, ezért a detoxban kötöttél ki";
                elozo_helyszin = "Világuralom Vár, Borospince";
                jozansag = 0;
                Console.ReadKey();
                DetoxbaKuldes();
            }
            else if (input == 2)
            {
                
                if (aranykulcs_birtoklasa)
                {
                    Console.WriteLine("Kinyitottad a kincseskamara ajtaját...");
                    elozo_hely_uzenete = "";
                    elozo_helyszin = "Világuralom Vár, Borospince";
                    Console.ReadKey();
                    Kincseskamra();
                }
                else
                {
                    Console.WriteLine("Nincs nálad a kulcs");
                    elozo_hely_uzenete = "";
                    
                    Console.ReadKey();
                    Borospince();
                }
                
            }
            else if (input == 3)
            {
                Console.WriteLine("Elkezdtél felmenni a pincéből...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár, Borospince";
                Console.ReadKey();
                Var();
            }
        }
        
        static void Kincseskamra()
        {
            Console.Clear();
            if (kincsek_meglatva == false)
            {
                eletkedv += 5;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                kincsek_meglatva = true;
            }
            
            


            helyszin = "Világuralom Vár, Kincseskamara";
            IrjaKiAStatokat("Megláttad a kincseket, és majdnem annyira örültél nekik, mint az alkoholnak");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elkezdessz kutakodni");
            Console.WriteLine("\t2. Elraksz annyi pénzt, amennyi elfér a zsebeidben");
            Console.WriteLine("\t3. Visszamész a borospincébe");

            int input = BekerLehetosegek(3);

            if (input == 1)
            {

                if(szent_korona_birtoklasa)
                {
                    Console.WriteLine("Nem találtál semmi érdekeset, az aranyon kívül...");
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kincseskamra();
                }
                else
                {
                    Console.WriteLine("Megtaláltad a Szent Koronát. Mindeni azt hitte, hogy már rég elveszett, de csak eltakarta a sok kincs, mely az emberi kapzsiságot jellemzi.");
                    szent_korona_birtoklasa = true;
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kincseskamra();
                }


            }
            else if(input == 2)
            {
                if(otszaz_krajcar_elrakva)
                {
                    Console.WriteLine("Több pénzt nem tudsz elrakni.");
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kincseskamra();
                }
                else
                {
                    Console.WriteLine("Elraktál 500 krajcárt. Még sohasem láttál ennyi pénzt...");
                    penz += 500;
                    otszaz_krajcar_elrakva = true;
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kincseskamra();
                }
            }
            else if(input == 3)
            {
                Console.WriteLine("Visszamész a borospincébe...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár, Kincsesekamara";
                Console.ReadKey();
                Borospince();
            }
        }

        static void Borton()
        {
            Console.Clear();
            if (!sikolyok_meghallva)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                sikolyok_meghallva = true;
            }
            


            helyszin = "Világuralom Vár, Várbörtön";
            IrjaKiAStatokat("Meghallottad az elveszett lelkek jajveszékelését. Zene volt füleidnek.");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Belerúgsz egy rabba [min. 60 vérszomj]");
            Console.WriteLine("\t2. Bemész a kínzókamrába");
            Console.WriteLine("\t3. Visszamész a várba");

            int input = BekerLehetosegek(3);

            if (input == 1)
            {

                if (rab_megrugva)
                {
                    Console.WriteLine("Már megrugtad a rabot és elment a rácstól...");
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Borton();
                }
                else
                {
                    if (verszomj >= 60)
                    {
                        Console.WriteLine("Szadista vágyaidat enyhén kielégítette ezen cselekedet.");
                        rab_megrugva = true;
                        verszomj -= 40;
                        verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);
                        elozo_hely_uzenete = "";
                        Console.ReadKey();
                        Borton();
                    }
                    else
                    {
                        Console.WriteLine("Jelen pillanatban nem érzed úgy, hogy erőszakosnak kellene lenned.");
                        elozo_hely_uzenete = "";
                        Console.ReadKey();
                        Borton();
                    }
                    
                }


            }
            else if(input == 2)
            {
                Console.WriteLine("Bemész a kinzókamrába...");
                elozo_helyszin = "Világuralom Vár, Várbörtön";
                elozo_hely_uzenete = "";
                Console.ReadKey();
                Kinzokamra();
            }
            else if(input == 3)
            {
                Console.WriteLine("Visszamész a várba...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár, Várbörtön";
                Console.ReadKey();
                Var();
            }
        }

        static void Kinzokamra()
        {
            Console.Clear();
            if (!ver_meglatva)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                ver_meglatva = true;
            }



            helyszin = "Világuralom Vár, Kínzókamra";
            IrjaKiAStatokat("Minden tiszta vér, és levágott végtagok vannak elszórva mindenfele. Ez nagyon tetszik neked.");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Kihúzod egy rab fogát [min 80 vérszomj]");
            Console.WriteLine("\t2. Visszamész a Börtönbe");

            int input = BekerLehetosegek(2);

            if (input == 1)
            {
                if (verszomj >= 80)
                {
                    Console.WriteLine("A fogászati művelet enyhített vérszomjadon...");
                    rab_megrugva = true;
                    verszomj -= 50;
                    verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kinzokamra();
                }
                else{
                    Console.WriteLine("Jelen pillanatban nem érzed úgy, hogy erőszakosnak kellene lenned.");
                    elozo_hely_uzenete = "";
                    Console.ReadKey();
                    Kinzokamra();
                }
                


            }
            else if (input == 2)
            {
                Console.WriteLine("Visszamész a várbörtönbe...");
                elozo_helyszin = "Világuralom Vár, Kínzókamra";
                elozo_hely_uzenete = "";
                Console.ReadKey();
                Borton();
            }
            else if (input == 3)
            {
                Console.WriteLine("Visszamész a várba...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Világuralom Vár, Várbörtön";
                Console.ReadKey();
                Var();
            }
        }
    }
}
