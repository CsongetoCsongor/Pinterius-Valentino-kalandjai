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
                Console.WriteLine("Lemész a borospincébe");
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
                else if(input == 2)
                {
                    Console.WriteLine("Kinyitottad a kincseskamara ajtaját...");
                    elozo_hely_uzenete = "";
                    elozo_helyszin = "Világuralom Vár, Borospince";
                    Console.ReadKey();
                    Kincseskamra();
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

            }

            static void Borton()
            {

            }

            static void Kinzokamra()
            {

            }
        }
    }
}
