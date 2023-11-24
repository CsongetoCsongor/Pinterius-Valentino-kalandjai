﻿using System;
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
            Console.WriteLine("Bemész a kocsmába és megünnepled, hogy nincs semmilyen ünnep, a szag szomorú gyerekkorodra emlékeztet");
            Console.WriteLine();
            eletkedv -= 5;

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Csapoltatsz magadnak egy sört 5 krajcárért és lehörpinted");
            Console.WriteLine("\t2. - Kéred a speciális italt, 30 krajcárba kerül");
            Console.WriteLine("\t3. - Kocsmai verekedést indítasz [max]");
            Console.WriteLine("\t4. - Kimész az utcára");

            int x;
            do
            {
                 x = Convert.ToInt32(Console.ReadLine());
            } while (x < 1 && x > 4);

            if (x == 1)
            {
                if (penz >= 5)
                {
                    eletkedv += 5;
                    jozansag -= 10;
                    penz -= 5;

                    Console.WriteLine("A sör finom volt, jó nagyot böfögtél");
                }

                else
                {
                    Console.WriteLine("Rettentő csóró vagy, még erre sincs pénzed");
                }

                Console.ReadKey();
                Console.Clear();
                Kocsma();
            }

            else if (x == 2)
            {
                if (penz >= 30)
                {
                    eletkedv = 100;
                    jozansag -= 70;
                    penz -= 30;

                    Console.WriteLine("A speciális ital speciális állapotba helyezett, az amúgy ott egy sárkány mögötted?");
                }

                else
                {
                    Console.WriteLine("Nincs elég pénzed, idióta");
                }

                Console.ReadKey();
                Console.Clear();
                Kocsma();
            }

            else if (x == 3 && volt_e_verekedes_kocsmaban == false)
            {
                if (jozansag <= 40)
                {
                    volt_e_verekedes_kocsmaban = true;

                    Console.ReadKey();
                    Console.Clear();
                    KocsmaiVerekedes();
                }

                else
                {
                    Console.WriteLine("Meggondoltad magad, ehhez nem vagy elég részeg");
                }

                Console.ReadKey();
                Console.Clear();
                Kocsma();
            }

            else
            {
                //TODO utcára menés
            }
        }

        static void KocsmaiVerekedes()
        {
            Console.WriteLine("A kocsmai verekedés nagyon zűrös, a harc mindjárt véget ér");
            Console.WriteLine("Csinos Tomi, aki Zoli utolsó megoldásként májon akar ütni");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Hátrébbugrasz");
            Console.WriteLine("\t2. - Megpróbálod kivédeni az ütést [min. 50 vérszomj]");
            Console.WriteLine("\t3. - Megmondod neki, hogy az erőszak nem megoldás");
            Console.WriteLine("\t4. - Fogsz egy sörösüveget és megölöd vele Rostás Brájent - Rostás Amedeusz fiát [min. 100 vérszomj]");

            int x;
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 1 && x > 4);

            if (x == 1)
            {
                penz -= 20;
                eletkedv -= 40;

                Console.WriteLine("Nekiestél a falusi keménygyereknek, aki agyonvert, elvett némi pénzt és kidobott az utcára");

                Console.ReadKey();
                Console.Clear();
                //TODO utcára menés
            }

            else if (x == 2)
            {
                if (verszomj >= 50)
                {
                    Console.WriteLine("3 kezet láttál, de valamennyire kitérült a keze");
                    Console.ReadKey();
                    Console.WriteLine("A verekedés véget ért");

                    Console.ReadKey();
                    Console.Clear();
                    Kocsma();
                }

                else
                {
                    eletkedv -= 5;

                    Console.WriteLine("Nincs benned annyi harci szellem, az ütés állcsúcson talált");

                    Console.ReadKey();
                    Console.Clear();
                    Kocsma();
                }
            }

            else if (x == 3)
            {
                eletkedv -= 30;

                Console.WriteLine("Az erőszak igenis megoldás, földre kerülsz");

                Console.ReadKey();
                Console.Clear();
                Kocsma();
            }

            else
            {
                if (verszomj == 100)
                {
                    Console.WriteLine("Rostás Brájen holtan");
                }
            }
        }
    }
}
