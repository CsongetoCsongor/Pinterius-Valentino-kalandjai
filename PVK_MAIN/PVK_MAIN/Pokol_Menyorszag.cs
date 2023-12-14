using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Menyorszag()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Helyszín:");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (" _______  _______  _                 _______  _______  _______  _______  _______  _______ ".Length / 2)) + "}", " _______  _______  _                 _______  _______  _______  _______  _______  _______ "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("(       )(  ____ \\( (    /||\\     /|(  ___  )(  ____ )(  ____ \\/ ___   )(  ___  )(  ____ \\".Length / 2)) + "}", "(       )(  ____ \\( (    /||\\     /|(  ___  )(  ____ )(  ____ \\/ ___   )(  ___  )(  ____ \\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| () () || (    \\/|  \\  ( |( \\   / )| (   ) || (    )|| (    \\/\\/   )  || (   ) || (    \\/".Length / 2)) + "}", "| () () || (    \\/|  \\  ( |( \\   / )| (   ) || (    )|| (    \\/\\/   )  || (   ) || (    \\/"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| || || || (__    |   \\ | | \\ (_) / | |   | || (____)|| (_____     /   )| (___) || |      ".Length / 2)) + "}", "| || || || (__    |   \\ | | \\ (_) / | |   | || (____)|| (_____     /   )| (___) || |      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| |(_)| ||  __)   | (\\ \\) |  \\   /  | |   | ||     __)(_____  )   /   / |  ___  || | ____ ".Length / 2)) + "}", "| |(_)| ||  __)   | (\\ \\) |  \\   /  | |   | ||     __)(_____  )   /   / |  ___  || | ____ "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| )   ( || (____/\\| )  \\  |   | |   | (___) || ) \\ \\__/\\____) | /   (_/\\| )   ( || (___) |".Length / 2)) + "}", "| )   ( || (____/\\| )  \\  |   | |   | (___) || ) \\ \\__/\\____) | /   (_/\\| )   ( || (___) |"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("|/     \\|(_______/|/    )_)   \\_/   (_______)|/   \\__/\\_______)(_______/|/     \\|(_______)".Length / 2)) + "}", "|/     \\|(_______/|/    )_)   \\_/   (_______)|/   \\__/\\_______)(_______/|/     \\|(_______)"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("Bejutottál Isten országába!".Length / 2)) + "}", "Bejutottál Isten országába!"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("JÓ BEFEJEZÉS".Length / 2)) + "}", "JÓ BEFEJEZÉS"));
            Console.ReadKey();
            System.Environment.Exit(1);
        }

        static void Pokol()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Helyszín:");
            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("_______  _______  _        _______  _       ".Length / 2)) + "}", "_______  _______  _        _______  _       "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("(  ____ )(  ___  )| \\    /\\(  ___  )( \\      ".Length / 2)) + "}", "(  ____ )(  ___  )| \\    /\\(  ___  )( \\      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| (    )|| (   ) ||  \\  / /| (   ) || (      ".Length / 2)) + "}", "| (    )|| (   ) ||  \\  / /| (   ) || (      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| (____)|| |   | ||  (_/ / | |   | || |      ".Length / 2)) + "}", "| (____)|| |   | ||  (_/ / | |   | || |      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("|  _____)| |   | ||   _ (  | |   | || |      ".Length / 2)) + "}", "|  _____)| |   | ||   _ (  | |   | || |      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| (      | |   | ||  ( \\ \\ | |   | || |      ".Length / 2)) + "}", "| (      | |   | ||  ( \\ \\ | |   | || |      "));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("| )      | (___) ||  /  \\ \\| (___) || (____/\\".Length / 2)) + "}", "| )      | (___) ||  /  \\ \\| (___) || (____/\\"));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("|/       (_______)|_/    \\/(_______)(_______/".Length / 2)) + "}", "|/       (_______)|_/    \\/(_______)(_______/"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (elozo_hely_uzenete.Length / 2)) + "}", elozo_hely_uzenete));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ("ROSSZ BEFEJEZÉS".Length / 2)) + "}", "ROSSZ BEFEJEZÉS"));

            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
