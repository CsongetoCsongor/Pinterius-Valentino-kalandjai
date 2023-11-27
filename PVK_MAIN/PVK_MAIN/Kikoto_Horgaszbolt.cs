using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Kikoto()
        {
            

            Console.WriteLine("Kimész a kikötőbe, megcsap a döglött halszag");
            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Belevizelsz a tengerbe");
            Console.WriteLine("\t2. Bemész a Horgászboltba");
            Console.WriteLine("\t3. Felszállsz a hajóra");
            Console.WriteLine("\t4. Visszamész a főútra");
            int input = BekerLehetosegek(4);
            if (input == 1)
            {
                Random rand = new Random();
                int szam = (rand.Next(1, 101));

                if (szam <= 20) 
                {
                    Console.WriteLine("Vizelés közben elkaptak a rendőrök");
                    //Borton();
                }
                else
                {
                    eletkedv += 10;
                    jozansag += 5;
                }
                Kikoto();
            }
            else if (input == 2)
            {
                Console.Clear();
                Horgaszbolt();
            }
            else if (input == 3)
            {
                Console.Clear();
                //Hajo();
            }
            else if (input == 4)
            {
                Console.Clear();
                //Fout();
            }
        }

        static void Horgaszbolt()
        {
            Console.WriteLine("Bemész a horgászboltba, ahol egy szakállas alkoholista üdvözöl; Szájszaga még a tiédnél is rosszabb");
            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Veszel egy horgászbotot, ami 20 krajcárba kerül");
            Console.WriteLine("\t2. Ha van, eladod neki a tengeri gyöngyöt, amiért 50 krajcárt fizet");
            Console.WriteLine("\t3. Köszönés nélkül elhagyod a horgászboltot");
            int input = BekerLehetosegek(3);
            if (input == 1)
            {
                penz -= 20;
                Horgaszbolt();
            }
            else if (input == 2)
            {
                if (tengeri_gyongy_birtoklasa == true)
                {
                    penz += 50;
                    tengeri_gyongy_birtoklasa = false;
                }
                else
                {
                    Console.WriteLine("Még nincsen nálad a tengeri gyöngy");
                }
                Horgaszbolt();
            }
            else if (input == 3)
            {
                Console.Clear();
                Kikoto();

            }
            
        }
    }
}
