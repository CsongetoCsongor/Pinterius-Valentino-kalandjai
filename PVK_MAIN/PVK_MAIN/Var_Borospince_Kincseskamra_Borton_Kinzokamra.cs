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
                Console.ReadKey();
                //Detox();
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
            eletkedv += 5;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);


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

        }

        static void Kinzokamra()
        {

        }
    }
}
