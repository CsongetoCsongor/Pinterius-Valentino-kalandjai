using System;
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
            helyszin = "Cserkészlány Csodaösvény";
            IrjaKiAStatokat("Kimész a természetbe - sokkolóan hat rád a tapasztalat");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");

            Console.WriteLine("\t1. - Elmész a Kárpátokba");
            Console.WriteLine("\t2. - Visszamész a főútra");

            int x = BekerLehetosegek(2);

            if (x == 1 && karpatok_meglatogatva == false)
            {
                elozo_helyszin = "Cserkészlány Csodaösvény";
                elozo_hely_uzenete = "A pirossal jelzett fákat követted és eljutottál a Kárpátokba";

                Console.ReadKey();
                //Hegy();
            }

            else if (x == 1 && karpatok_meglatogatva == true)
            {
                Console.WriteLine("Ezt az utat már egyszer megjártad");

                elozo_helyszin = "Cserkészlány Tanösvény";
                elozo_hely_uzenete = "Lusta vagy, ezért inkább az ösvényen maradsz";

                Console.ReadKey();
                Osveny();
            }

            else
            {
                elozo_helyszin = "Cserkészlány Tanösvény";
                elozo_hely_uzenete = "Na ez azán hasznos séta volt";

                Console.ReadKey();
                Fout();
            }
        }

        static void Hegy()
        {
            Console.Clear();
            eletkedv += 50;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            helyszin = "Kárpátok";
            IrjaKiAStatokat("Megpillantod a Kárpátok szent bérceit");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Elkezdesz Kárpátiát Dalolni (Pálinka) [max 60 józanság]");
            Console.WriteLine("\t2. - Továbbmész a vízeséshez");

            int x = BekerLehetosegek(2);

            if (x == 1 && jozansag <= 60)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

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
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}
