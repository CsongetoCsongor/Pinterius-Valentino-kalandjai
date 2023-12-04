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
                elozo_helyszin = "Vár";
                Console.ReadKey();
                Borospince();
            }
            else if(input == 2)
            {
                Console.WriteLine("Bemész a börtönbe...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Vár";
                Console.ReadKey();
                Borton();
            }
            else if(input == 3)
            {
                Console.WriteLine("Kimész a főútra...");
                elozo_hely_uzenete = "";
                elozo_helyszin = "Vár";
                Console.ReadKey();
                Fout();
            }

        static void Borospince()
        {

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
