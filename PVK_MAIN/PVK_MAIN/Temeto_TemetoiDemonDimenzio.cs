using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Temeto()
        {
            Console.Clear();
            helyszin = "Temető (Ingyen Protein Temető)";
            IrjaKiAStatokat("Nekrofil hajlamaid a temetőbe vittek téged; A halottak hívását hallod");
            Console.WriteLine();

            if (jozansag <= 40 && eletkedv <= 50)
            {
                elozo_hely_uzenete = "Életkedved és józanságod alacsony volt, ezért egy más dimenzióba kerültél";
                TemetoiDemonDimenzio();
            }

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Meggyalázol egy sírt");
            Console.WriteLine("\t2. - Megeszel egy koszorút");
            Console.WriteLine("\t3. - Visszamész a főútra");

            int x = BekerLehetosegek(3);

            if (x == 1)
            {
                if (jozansag <= 40)
                {
                    eletkedv += 10;
                    NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                    Console.WriteLine("A sírt meggyalázva nagyot röhögsz, de hátad mögött kék és piros villanásokat látsz");
                    elozo_hely_uzenete = "Sírgyalázásért letartóztattak";
                    //Borton();
                }
            }
        }

        static void TemetoiDemonDimenzio()
        {
            Console.Clear();
            helyszin = "Temetői Démon Dimenzió";
            IrjaKiAStatokat("Egy francia-szobalányruhában lévő kísértet áll előtted, és azzal fenyeget, hogy elvesz mindent, ami fontos neked");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Mi fontos neked?");

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - A bukszád");
            Console.WriteLine("\t2. - A daliás páncélod");
            Console.WriteLine("\t3. - Az enyhén kellemetlenül balra hajló kardod");
            Console.WriteLine("\t4. - A család (hazudsz)");



        }
    }
}
