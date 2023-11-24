using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Otthon()
        {
            Console.WriteLine("Felébredsz otthonodban, és rettentően másnapos vagy. Vérre szomjazol...");
            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Összeokádod a WC-t");
            Console.WriteLine("\t2. Tömsz egyet");
            Console.WriteLine("\t3. Kimész a kertbe");
            Console.WriteLine("\t4. Kimész a főútra");
            int input = BekerLehetosegek(4);

            if (input == 1)
            {

                if(wc_osszeokadva == false)
                {
                    eletkedv += 10;
                    jozansag += 10;
                    wc_osszeokadva = true;
                }
               
                Console.WriteLine("Kiadtad magadból, amit ki kellett...");
                Console.ReadKey();
                Console.Clear();
                Otthon();
            }
            else if (input == 2)
            {
                eletkedv += 10;
                jozansag -= 10;
                verszomj += 10;

                Console.WriteLine("A SIBERIA bement az ínyedhez, kicsit beszédültél.");
                Console.ReadKey();
                Console.Clear();
                Otthon();
            }
            else if(input == 3)
            {
                Console.Clear();
                Kert();
            }
            else if (input == 4)
            {
                Console.Clear();
                //Fout();
            }
            else
            {

            }
        }

        static void Kert() 
        {
            eletkedv -= 20;
            Console.WriteLine("Kimentél a kertbe. Megcsípett egy méhe (véleményed szerint a nagyorrú kalapos ogrék miatt van).");
            Console.WriteLine();
            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. Megölöd a méhét [min. 70 vérszomj]");
            Console.WriteLine("\t2. Odamész a virágágyáshoz");
            Console.WriteLine("\t3. Visszamész a házba");




        }
    }
}
