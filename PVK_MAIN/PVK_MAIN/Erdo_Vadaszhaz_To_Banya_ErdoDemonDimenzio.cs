using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Erdo()
        {
            Console.Clear();
            helyszin = "Sárguló Sörerdő";
            IrjaKiAStatokat("Az erdőbe érve gonosz démonok hívását hallod. Mintha a pokolból millió ember sikolya szólna hozzád...");

            if (jozansag <= 30)
            {
                elozo_hely_uzenete = "";
                ErdoDemonDimenzio();
            }

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Megeszel egy furcsa gombát");
            Console.WriteLine("\t2. Megiszod egy sárga fa gyantáját");
            Console.WriteLine("\t3. Lemész a bányába");
            Console.WriteLine("\t4. Elmész a tóhoz");
            Console.WriteLine("\t5. Bemész a vadászházba");
            Console.WriteLine("\t6. Visszamész a főútra");
            int input = BekerLehetosegek(6);

            if (input == 1)
            {

                eletkedv += 5;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                jozansag -= 5;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                verszomj += 10;
                verszomj = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(verszomj);

                Console.WriteLine("Bolondgombát ettél. Szerencsére az immunrendszered már megszokta a terhelést, szóval nem kerültél detoxba.");
                Console.ReadKey();
                Console.Clear();
                Erdo();
            }
            else if (input == 2)
            {
                eletkedv += 10;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                jozansag -= 10;
                jozansag = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(jozansag);
                

                Console.WriteLine("A gyanta Rákóczi Sör volt. Nem véletlenül nevezik ezt a helyet SÖRerdőnek...");
                Console.ReadKey();
                Console.Clear();
                Erdo();
            }
            else if (input == 3)
            {
                Console.WriteLine("Elindulsz a bánya felé...");
                elozo_helyszin = "Sárguló Sörerdő";
                Console.ReadKey();
                elozo_hely_uzenete = "";
                //Banya();
            }
            else if (input == 4)
            {

                Console.WriteLine("Elindulsz a tó felé...");
                elozo_helyszin = "Sárguló Sörerdő";
                Console.ReadKey();
                elozo_hely_uzenete = "";
                To();
            }
            else if(input == 5)
            {
                if (vadaszhaz_meglatogatva == true)
                {
                    Console.WriteLine("Már voltál a vadászházban, nincs ott számodra semmi.");
                    Console.ReadKey();
                    elozo_hely_uzenete = "";
                    Erdo();
                }
                else
                {
                    Console.WriteLine("Elindulsz a vadaszhaz felé...");
                    elozo_helyszin = "Sárguló Sörerdő";
                    Console.ReadKey();
                    elozo_hely_uzenete = "";
                    Vadaszhaz();
                }
                
            }
            else if(input == 6)
            {
                elozo_helyszin = "Sárguló Sörerdő";
                Fout();
            }
        }

        static void ErdoDemonDimenzio()
        {
            Console.Clear();
            helyszin = "DÉMON DIMENZIÓ";
            IrjaKiAStatokat("A démonok hívásának nem tudtál ellen állni, egy alternatív valóságba estél és megtámadott egy démon.");

            Console.WriteLine("BOGNÁR EXAEL VAGYOK, DÉMONOK URA, VILÁGOK PUSZTÍTÓJA ÉS C# PROGRAMOZÓ TANÁR!");
            Console.WriteLine("MINDEM ÓRÁMAT MEGKESERÍTETTE, EZÉRT MOST BOSSZÚT ÁLLOK!");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elfutsz a démon elől...");
            Console.WriteLine("\t2. Rátámadsz a démonra...");
            int input = BekerLehetosegek(2);

            if (input == 1)
            {

                if (jozansag >= 20)
                {
                    Console.WriteLine("Szerencséd volt, elég józan voltál, hogy elfuss...");
                    elozo_helyszin = "DÉMON DIMENZIÓ";
                    Console.ReadKey();
                    elozo_hely_uzenete = "A DÉMON DIMENZIÓ nagyon kikészített...";
                    Otthon();
                }
                else
                {
                    Console.WriteLine("Túl részeg voltál és megbotlottál egy igazságtáblában, a démon pedig kiszítta a lelkedet.");
                    elozo_helyszin = "DÉMON DIMENZIÓ";
                    Console.ReadKey();
                    
                    //Pokol();
                }

                
            }
            else if(input == 2)
            {
                if (verszomj == 100)
                {
                    Console.WriteLine("A démont megragadtad a farkánál és földhöz vágtad, letépted a szárnyait majd a lehelletedtől alkoholmérgezést kapott..");
                    verszomj = 0;
                    elozo_helyszin = "DÉMON DIMENZIÓ";
                    Console.ReadKey();
                    elozo_hely_uzenete = "A DÉMON DIMENZIÓ kicsit kikészített, de örülsz győzelmednek.";
                    Otthon();
                }
                else
                {
                    Console.WriteLine("Nem voltál elég vérszomjas, hogy megöld a démont, ezért elégetett a pokol tüzével, és elkobozta lelkedet.");
                    elozo_helyszin = "DÉMON DIMENZIÓ";
                    Console.ReadKey();

                    //Pokol();
                }
            }
        }

        static void To()
        {
            Console.Clear();
            helyszin = "Tó(Falvi Zalán)";
            IrjaKiAStatokat("Egy békés kis erdei tóhoz érkeztél. Megláttál egy nagyon szexi tündérlányt, akit Szerencsés Edíníának hívnak");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Titokban kukkolod");
            Console.WriteLine("\t2. Odamész és flörtölsz vele [max 50 józanság]");
            Console.WriteLine("\t3. Visszamész az erdőbe");
            int input = BekerLehetosegek(3);

            if (input == 1)
            {

                eletkedv += 30;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                

                Console.WriteLine("Ejha, de takaros tündérlányka ez! Nagyon látszanak a formák ebben a fürdőruhában, így a feminista forradalom után...");
                Console.ReadKey();
                Console.Clear();
                To();
            }
            else if(input == 2)
            {
                if (jozansag <= 50 && tengeri_gyongy_birtoklasa == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pinterius Valentino: Szépséged olyan fényesen csillan meg a tó vizén, mint a reggeli harmat a 2 literes Kőbányai flakonján. - szólt Pinterius.");
                    Console.WriteLine("Tündérlány: Wow! - mondta, mintha egy nyelvvizsgabiztos lett volna - milyen magas, sármos és jóképű legény vagy!");
                    Console.WriteLine("Pinterius Valentino: Igyekszem. Megkaphatom az Instádat? - mondta főhősünk, ragyogó magabiztossággal.");
                    Console.WriteLine("Tündérlány: I-IGEEN! - szólt a nőstény, izgatottan - szerencses.edina_6969");
                    Console.WriteLine("Pinterius Valentino bejelölte és elolvasta a bioját...");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("628 years, she/her");
                    Console.WriteLine("SLAAAAAY GURLLLL");
                    Console.WriteLine("Manuel <3");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();
                    Console.WriteLine("Tündérlány: SZERELMES LETTEM BELÉD! Itt egy tengeri gyöngy, hogy emlékezz szerelmünkre!");
                    Console.WriteLine();
                    Console.WriteLine("Felszerelve: Tengeri Gyöngy");
                    tengeri_gyongy_birtoklasa = true;
                    eletkedv += 10;
                    eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);


                    Console.ReadKey();
                    elozo_hely_uzenete = "";
                    To();
                }
                else if(tengeri_gyongy_birtoklasa == true)
                {
                    Console.WriteLine("Már felszedted a tündérlányt.");

                    Console.ReadKey();
                    elozo_hely_uzenete = "";
                    To();
                }
                else
                {
                    Console.WriteLine("Nincs elég bátorságod, hogy odamenj hozzá, mert túl józan vagy.");

                    Console.ReadKey();
                    elozo_hely_uzenete = "";
                    To();
                }
            }
            else if(input == 3)
            {
                elozo_helyszin = "Tó(Falvi Zalán)";
                Console.ReadKey();
                elozo_hely_uzenete = "";

                Erdo();
            }

        }

        static void Vadaszhaz()
        {
            Console.Clear();
            vadaszhaz_meglatogatva = true;
            helyszin = "Gyulakolbász lakhely";
            IrjaKiAStatokat("Hívatlan vendég vagy, vigyázz nehogy észrevegyen a vadász");

            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Elbújsz a szekrényben, ha tiszta a terep elmész {találsz egy fura kulcsot}");
            Console.WriteLine("\t2. Elhiteted a vadásszal, hogy eltévedtél, és elhagyod a területet");
            int input = BekerLehetosegek(2);

            if (input == 1)
            {
                
                Console.WriteLine("Találtál egy fura kulcsot. Elraktad zsebre, majd mikor a vadász elment logikai függvényeket egyszerűsíteni kiosontál.");
                fura_kulcs_birtoklasa = true;
                elozo_helyszin = "Gyulakolbász lakhely";
                Console.ReadKey();
                
                Erdo();

            }
            else if(input == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Vadász: Mit csinál maga az ingatlanomban?");
                Console.WriteLine("Pinterius Valentino: Szíves elnézését kérem, de eltévedtem és azt hittem ez egy elhagyatott ház, mert rohadnak a falak.");
                Console.WriteLine("Vadász: Rendben köszönöm! Tessék, itt egy térkép és egy matematikai inga, most pedig menjen útjára!");
                Console.WriteLine("Pinterius Valentino: Tiszteletem, viszontlátásra! (Milyen tudatlan, elhitte - gondoltad magadban.)");

                fura_kulcs_birtoklasa = true;
                elozo_helyszin = "Gyulakolbász lakhely";
                Console.ReadKey();

                Erdo();
            }
        }
    }
}
