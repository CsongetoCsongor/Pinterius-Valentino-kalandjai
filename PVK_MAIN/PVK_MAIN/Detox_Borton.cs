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
            elozo_helyszin = "Nem emlékszel";
            helyszin = "Második Esély Klinika, Detoxikáló részleg";
            Console.ForegroundColor = ConsoleColor.Red;
            IrjaKiAStatokat("A véralkoholszinted túl magas volt, kiütötted magad. Szerencsédre rádtaláltak, és bevittek a detoxba. Másnap reggel van.");
            
            Console.WriteLine();
            Console.WriteLine("Kérdésekre kell válaszolnod, hogy leteszteljék, hogy elég józan vagy-e.");
            Console.WriteLine();
            Console.WriteLine("Vigyázz! Ha 2-nél többet hibázol megölnek, mert úgy ítélik, nem vagy hasznos tagja a társadalomnak.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey();

            Random esely = new Random();

            int mistakes = 0;

            int rounds = 0;

            void feladat1()
            {
                Console.Clear();
                int a = esely.Next(1, 16);
                int b = esely.Next(1, 16);

                Console.WriteLine($"Mennyi {a} + {b}?");
                int valasz;

                do
                {
                    Console.Write("Válasz: ");

                }
                while (!int.TryParse(Console.ReadLine(), out valasz));

                if (valasz == a + b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Helyes válasz!");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    rounds++;
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hibát vétettünk!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    rounds++;
                    mistakes++;
                    Console.ReadKey();
                }
                
            }

            void feladat2()
            {
                Console.Clear();
                int a = esely.Next(1, 16);
                int b = esely.Next(1, 16);

                Console.WriteLine($"Mennyi {a} - {b}?");
                int valasz;

                do
                {
                    Console.Write("Válasz: ");

                }
                while (!int.TryParse(Console.ReadLine(), out valasz));

                if (valasz == a - b)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Helyes válasz!");
                    Console.ForegroundColor = ConsoleColor.Gray; ;
                    rounds++;
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hibát vétettünk!!!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    rounds++;
                    mistakes++;
                    Console.ReadKey();
                }

            }

            while (rounds < 5 && mistakes < 3)
            {
                if (rounds % 2 == 0)
                {
                    feladat1();
                }
                else
                {
                    feladat2();
                }
            }
            if(mistakes == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elbuktál a teszten...");
                Console.ForegroundColor = ConsoleColor.Gray;


                elozo_hely_uzenete = "Megöltek, mert túl részeg voltál és idegesítetted őket. Isten ezt persze nem nézte jó szemmel és pokolra küldött.";
                elozo_helyszin = "Második Esély Klinika, Detoxikáló részleg";
                Console.ReadKey();
                //Pokol();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Józannak bizonyultál! Kiengedtek.");
                Console.ForegroundColor = ConsoleColor.Gray;

                jozansag = 50;

                elozo_hely_uzenete = "Azt mondták, hogy legközelebb igyak kevesebbet. Na persze! Majd haklgatni fogok ezekre a tökfejekre! - mondtad gúnyosan.";
                elozo_helyszin = "Második Esély Klinika, Detoxikáló részleg";
                Console.ReadKey();
                Fout();
            }
            

            
        }
    
        static void Mech_Borton()
        {
            Console.Clear();
            elozo_helyszin = "Már nem emlékszel, összefolynak a napok";
            helyszin = "Várbörtön";
            Console.ForegroundColor = ConsoleColor.Red;
            IrjaKiAStatokat("Börtönbe kerültél");

            Console.WriteLine();
            Console.WriteLine("Ki kell töltened egy tesztet, hogy bebizonyítsd, hogy tisztában vagy a törvényekkel");
            Console.WriteLine();
            Console.WriteLine("Vigyázz! Ha 1-nél többet hibázol akasztófára kerülsz.");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadKey();

            Console.Clear();

            int mistakes = 0;


            #region kerdes_1
            Console.WriteLine("1. kérdés:");
            Console.WriteLine();
            Console.WriteLine("Szabad-e részegen szekeret vezetni?");
            Console.WriteLine("1. - Igen");
            Console.WriteLine("2. - Nem");
            Console.WriteLine();
            int input = BekerLehetosegek(2);

            if (input == 1)
            {
                mistakes++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HIBÁS!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }
            else if(input == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HELYES!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }

            #endregion


            #region kerdes_2
            Console.WriteLine("2. kérdés:");
            Console.WriteLine();
            Console.WriteLine("Szabad-e sírt meggíyalázni?");
            Console.WriteLine("1. - Igen");
            Console.WriteLine("2. - Nem");
            Console.WriteLine();
            input = BekerLehetosegek(2);

            if (input == 1)
            {
                mistakes++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HIBÁS!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();

            }
            else if (input == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HELYES!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }

            if(mistakes == 2)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MEgbuktál a teszten. AKASZTÓFÁRA KERÜLTÉL!");
                Console.ForegroundColor = ConsoleColor.Gray;

                jozansag = 50;

                elozo_hely_uzenete = "Felakasztottak és a pokolra jutottál.";
                elozo_helyszin = "Várbörtön";
                Console.ReadKey();
                //Pokol();
            }

            #endregion

            #region kerdes_3
            Console.WriteLine("3. kérdés:");
            Console.WriteLine();
            Console.WriteLine("Szabad-e szeretni embertársaidat?");
            Console.WriteLine("1. - Igen");
            Console.WriteLine("2. - Nem");
            Console.WriteLine();
            input = BekerLehetosegek(2);

            if (input == 1)
            {
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("HELYES!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();

            }
            else if (input == 2)
            {
                mistakes++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HIBÁS!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }

            if (mistakes == 2)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("JMEgbuktál a teszten. AKASZTÓFÁRA KERÜLTÉL!");
                Console.ForegroundColor = ConsoleColor.Gray;

                jozansag = 50;

                elozo_hely_uzenete = "Felakasztottak és a pokolra jutottál.";
                elozo_helyszin = "Várbörtön";
                Console.ReadKey();
                //Pokol();
            }
            #endregion

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kiengedtek a börtönből.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Fout();
        }







    }
}
