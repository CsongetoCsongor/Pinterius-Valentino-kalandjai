using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Hajo()
        {

            Console.Clear();

            helyszin = "Pipanic";
            IrjaKiAStatokat("Felszálltál a hajóra teli előkelő utasokkal");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Megijeszted a gyerekeket");
            Console.WriteLine("\t2. Leokádod az utasokat");
            Console.WriteLine("\t3. Bemész a vezérfülkébe");
            Console.WriteLine("\t4. Elhagyod a hajót");

            int input = BekerLehetosegek(4);
            if (input == 1)
            {
                if (verszomj >= 70 && jozansag <= 50)
                {
                    eletkedv += 30;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                    Console.WriteLine("Megijesztetted a kölyköket és jót nevettél rajta");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "A frászt hoztad rájuk";

                    Console.ReadKey();

                    Hajo();
                }
                else
                {
                    Console.WriteLine("Túl sok az előkelő utas, nem mered megtenni");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Majd legközelebb";

                    Console.ReadKey();

                    Hajo();
                }
            }
            else if (input == 2)
            {
                if (jozansag <= 20)
                {
                    eletkedv -= 30;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    Ongyilkossag("Az utasok agyonvertek. A megalázkodás elvette a maradék életkedved.");

                    Console.WriteLine("Leokádtad az előkelő utasokat, akik jól agyonvertek utána");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Pórul jártál";

                    Console.ReadKey();

                    Hajo();
                }
                else
                {
                    Console.WriteLine("Nem kell hánynod, nem ittál még eleget");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Továbbsétáltál";

                    Console.ReadKey();

                    Hajo();
                }
            }
            else if (input == 3)
            {
                if (hajokulcs_birtoklasa == true)
                {
                    Console.WriteLine("Elindultál a vezérfulke felé...");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Bemész a fülkébe";

                    Console.ReadKey();

                    Vezerfulke();
                }
                else
                {
                    Console.WriteLine("Még nincs nálad a hajó kulcsa");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Visszamentél a hajóra, nem látott senki";

                    Console.ReadKey();

                    Hajo();
                }
            }
            else if (input == 4)
            {
                Console.WriteLine("Elhagytad a hajót, elindultál a kikötő felé...");

                elozo_helyszin = "Pipanic";
                elozo_hely_uzenete = "Leszálltál a hajóról";

                Console.ReadKey();

                Kikoto();
            }

        }

        static void Vezerfulke()
        {

            Console.Clear();

            helyszin = "Vezerfülke";
            IrjaKiAStatokat("Bementél a vezérfülkébe és a hajókormány előtt találod magadat a kulccsal a kezedben.");

            Console.WriteLine("");
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elkötöd a hajót");
            Console.WriteLine("\t2. Kisétálsz a vezérfülkéből");

            int input = BekerLehetosegek(2);
            if (input == 1)
            {
                if (jozansag <= 40)
                {
                    Console.WriteLine("Elsüllyesztetted a hajót, mert túl részeg voltál.");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "Elsüllyesztetted a hajót, egy kinccsel teli sziget helyett a pokolban kötöttél ki.";

                    Console.ReadKey();

                    Pokol();
                }
                else
                {
                    Console.WriteLine("Sikeresen elkötötted a hajót. Többszáz kilóméter részeg hajóvezetés után egy szigetre lettél figyelmes a horizonton...");

                    elozo_helyszin = "Pipanic";
                    elozo_hely_uzenete = "";

                    Console.ReadKey();

                    Sziget();
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Úgy döntöttél kihagyod a lehetőséget és kisétálsz onnan");

                elozo_helyszin = "Pipanic";
                elozo_hely_uzenete = "Kisétáltál a vezérfülkéből";

                Console.ReadKey();

                Hajo();
            }

        }

        static void Sziget()
        {

            Console.Clear();

            helyszin = "Bikini fenék";
            IrjaKiAStatokat("Kijutottál a szigetre");

            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
