using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Detox()
        {
            Console.Clear();
            helyszin = "Második Esély Klinika, Detoxikáló részleg";
            IrjaKiAStatokat("A véralkoholszinted túl magas volt, kiütötted magad. Szerencsédre rádtaláltak, és bevittek a detoxba.");

            

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
        }
    }
}
