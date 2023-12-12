using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Kocsma()
        {
            Console.Clear();

            eletkedv -= 5;
            eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

            helyszin = "Csévi Szilva Kocsma";
            IrjaKiAStatokat("Bemész a kocsmába és megünnepled, hogy nincs semmilyen ünnep, a szag szomorú gyerekkorodra emlékeztet");
            Console.WriteLine();
            

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Csapoltatsz magadnak egy sört 5 krajcárért és lehörpinted");
            Console.WriteLine("\t2. - Kéred a speciális italt, 30 krajcárba kerül");
            Console.WriteLine("\t3. - Kocsmai verekedést indítasz [max 40 józanság]");
            Console.WriteLine("\t4. - Kimész az utcára");

            int x = BekerLehetosegek(4);

            if (x == 1)
            {
                if (penz >= 5)
                {
                    eletkedv += 5;
                    jozansag -= 10;
                    penz -= 5;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);

                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Ittál egy sört";

                    Console.WriteLine("A sör finom volt, jó nagyot böfögtél...");
                }

                else
                {
                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Nem volt pénzed sörre";

                    Console.WriteLine("Rettentő csóró vagy, még erre sincs pénzed...");
                }

                Console.ReadKey();
                Kocsma();
            }

            else if (x == 2)
            {
                if (penz >= 30)
                {
                    eletkedv = 100;
                    jozansag -= 70;
                    penz -= 30;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                    jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);

                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Ittál egy \"Börzsönyi Csattogóst\"";


                    Console.WriteLine("A speciális ital speciális állapotba helyezett, az amúgy ott egy sárkány mögötted?");
                }

                else
                {
                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Sajna nem volt pénzed, na majd legközelebb";

                    Console.WriteLine("Nincs elég pénzed, idióta...");
                }

                Console.ReadKey();
                Kocsma();
            }

            else if (x == 3 && volt_e_verekedes_kocsmaban == true)
            {
                elozo_helyszin = "Csévi Szilva Kocsma";
                elozo_hely_uzenete = "Verekedést akartál indítani, de egy külső erő (fejlesztők) megállított";

                Console.WriteLine("Ezt már csináltad és akkor sem lett jó vége...");

                Console.ReadKey();
                Kocsma();
            }

            else if (x == 3 && volt_e_verekedes_kocsmaban == false)
            {
                if (jozansag <= 40)
                {
                    volt_e_verekedes_kocsmaban = true;

                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Kocsmai verekedést indítottál";

                    Console.ReadKey();
                    KocsmaiVerekedes();
                }

                else
                {
                    elozo_helyszin = "Csévi Szilva Kocsma";
                    elozo_hely_uzenete = "Kocsmai verekedést akartál indítani, de megijedtél a következményektől";

                    Console.WriteLine("Meggondoltad magad, ehhez nem vagy elég részeg...");
                }

                Console.ReadKey();
                Kocsma();
            }

            else
            {
                elozo_helyszin = "Csévi Szilva Kocsma";
                elozo_hely_uzenete = "Kibotladoztál a kocsmából";

                Console.WriteLine("Belerúgsz a küszöbbe...");

                Console.ReadKey();
                Fout();
            }
        }

        static void KocsmaiVerekedes()
        {
            Console.Clear();
            helyszin = "Csévi Szilva Kocsma (verekedés)";
            IrjaKiAStatokat("A kocsmai verekedés már lecsengőben van, a harc mindjárt véget ér");
            Console.WriteLine("Verekedés folytatása...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Csinos Tomi, aki Zoli utolsó megoldásként májon akar ütni");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Hátrébbugrasz");
            Console.WriteLine("\t2. - Megpróbálod kivédeni az ütést [min. 50 vérszomj]");
            Console.WriteLine("\t3. - Megmondod neki, hogy az erőszak nem megoldás");

            int x;

            if (verszomj == 100) 
            {
                Console.WriteLine("\t4. - Fogsz egy sörösüveget és megölöd vele Rostás Brájent - Rostás Amedeusz fiát [min. 100 vérszomj]");

                x = BekerLehetosegek(4);
            }

            else
            {
                x = BekerLehetosegek(3);
            }

            if (x == 1)
            {
                penz -= 20;
                eletkedv -= 40;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                elozo_helyszin = "Csévi Szilva Kocsma (verekedés)";
                elozo_hely_uzenete = "Nekiestél a falusi keménygyereknek, aki agyonvert, elvett némi pénzt és kidobott az utcára";


                Console.WriteLine("Nekiesel Magony \"Bagó\" Bencének, aki ideges lesz...");

                Console.ReadKey();
                Fout();
            }

            else if (x == 2)
            {
                if (verszomj >= 50)
                {
                    Console.WriteLine("3 kezet láttál, de valamennyire kitérült a keze...");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Döntetlen");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    elozo_helyszin = "Csévi Szilva Kocsma (verekedés)";
                    elozo_hely_uzenete = "A verekedés döntetlennel zárult";

                    Console.ReadKey();
                    Kocsma();
                }

                else
                {
                    eletkedv -= 5;

                    Console.WriteLine("Nincs benned annyi harci szellem, az ütés állcsúcson talált...");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vereség");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    elozo_helyszin = "Csévi Szilva Kocsma (verekedés)";
                    elozo_hely_uzenete = "Szépen ki lettél ütve a verekedésből";

                    Console.ReadKey();
                    Kocsma();
                }
            }

            else if (x == 3)
            {
                eletkedv -= 30;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);

                Console.WriteLine("Kiröhögött és agyonvert");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Csúfos vereség");
                Console.ForegroundColor = ConsoleColor.Gray;

                elozo_helyszin = "Csévi Szilva Kocsma (verekedés)";
                elozo_hely_uzenete = "Az erőszak volt a megoldás";

                Console.ReadKey();
                Kocsma();
            }

            else
            {
                eletkedv = 100;

                Console.WriteLine("Rostás Brájen holtan fekszik a padlón, te pedig repülsz a böribe...");

                elozo_helyszin = "Csévi Szilva Kocsma (verekedés)";
                elozo_hely_uzenete = "Gyilkosság miatt börtönbe zártak";

                Console.ReadKey();
                //Borton();
            }
        }
    }
}
