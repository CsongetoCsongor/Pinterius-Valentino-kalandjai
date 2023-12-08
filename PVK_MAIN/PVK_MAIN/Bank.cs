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
            helyszin = "Zsebtolvajok Világuralma Bank";
            if (jozansag <= 50)
            {
                Bankrablas();
            }
            eletkedv -= 10;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
            IrjaKiAStatokat("Bemész a bankba és megpillantassz egy csomó nagyorrú kalapos ogrét");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");

            Console.WriteLine("\t1. - Leveszel a számládról pénzt");
            Console.WriteLine("\t2. - Antiogreista megjegyzéseket teszel");
            Console.WriteLine("\t3. - Kizsebelsz egy kapzsi ogrét");
            Console.WriteLine("\t4. - Kimész a főútra");

            int x = BekerLehetosegek(4);

            if (x == 1)

        }
    }
}
