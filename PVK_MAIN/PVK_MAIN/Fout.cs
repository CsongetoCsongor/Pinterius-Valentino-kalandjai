using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Fout()
        {

            Console.Clear();
            Random esely = new Random();
            int eredmeny = esely.Next(1, 11);
            if (eredmeny == 1 || eredmeny == 2)
            {
                Console.WriteLine("Meghallottad, ahogyan a goblinok hangosan zenét hallgatnak, ezért kicsit elment az életkedved. ");
                Console.WriteLine();
            }

            helyszin = "Főút";

            IrjaKiAStatokat("Kiléptél az utcára, megcsapott a pestis szaga, és meghallottad az emberek nyüzsögését.");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Bemész a kocsmába");
            Console.WriteLine("\t2. Bemész a kovácshoz");
            Console.WriteLine("\t3. Bemész a temetőbe");
            Console.WriteLine("\t4. Bemész az étterembe");
            Console.WriteLine("\t5. Bemész az erdőbe");
            Console.WriteLine("\t6. Bemész az ösvényre");
            Console.WriteLine("\t7. Bemész az bankba");
            Console.WriteLine("\t8. Bemész az várba");
            Console.WriteLine("\t9. Bemész az kikötőbe");
            int input = BekerLehetosegek(9);

            if (input == 1) 
            {
                Console.WriteLine("Elindulsz a kocsma felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                
                Kocsma();
            }
            else if(input == 2)
            {
                Console.WriteLine("Elindulsz a kovács felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Kovacs();
            }
            else if(input == 3)
            {
                Console.WriteLine("Elindulsz a temető felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                Temeto();
            }
            else if (input == 4)
            {
                Console.WriteLine("Elindulsz az étterem felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Etterem();
            }
            else if(input == 5)
            {
                Console.WriteLine("Elindulsz az erdő felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                Erdo();
            }
            else if(input == 6)
            {
                Console.WriteLine("Elindulsz az ösvény felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Osveny();
            }
            else if(input == 7)
            {
                Console.WriteLine("Elindulsz a bank felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Bank();
            }
            else if(input == 8)
            {
                Console.WriteLine("Elindulsz a vár felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Var();
            }
            else if(input == 9)
            {
                Console.WriteLine("Elindulsz a kikötő felé...");
                elozo_helyszin = "Főút";
                Console.ReadKey();
                //Kikoto();
            }
        }
    }
}
