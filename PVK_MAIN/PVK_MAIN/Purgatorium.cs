using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVK_MAIN
{
    internal partial class Program
    {
        static void Purgatorium()
        {
            Console.Clear();
            helyszin = "Purgatórium";
            IrjaKiAStatokat("A tisztítótűzben találod magad, ahol ítéletet kérhetsz az Úrtól");
            Console.WriteLine();

            Console.WriteLine("Lehetőségek:");
            Console.WriteLine("\t1. - Beszélsz Harangozó Csongárddal");
            Console.WriteLine("\t2. - Beszélsz Pogány Lezlitóval");
            Console.WriteLine("\t3. - Beszélsz Barthalón Bendegúzzal");
            Console.WriteLine("\t4. - Beülsz az ítélőszékbe");

            int x = BekerLehetosegek(4);

            if (x == 1)
            {
                elozo_helyszin = "Purgatórium";
                elozo_hely_uzenete = "Beszéltél Barthalón Bendegúzzal, aki rendesen beoltott";

                Console.WriteLine("\"Ki ez?\"");
                Console.ReadKey();
                Console.WriteLine("\"Egy iszákos senki\"");
                Console.ReadKey();
                Console.WriteLine("\"Hordd innen el magad\"");
                Console.ReadKey();
                Console.WriteLine("\"Rád csak a Pokol tüze vár\"");

                Console.ReadKey();
                Purgatorium();
            }

            else if (x == 2)
            {
                elozo_helyszin = "Purgatórium";
                elozo_hely_uzenete = "Megismerted Lezlitót, a pokol tüzének megivóját";

                Console.WriteLine("\"Csak egy Hellt akarok...\"");
                Console.ReadKey();
                Console.WriteLine("\"csak egy Hellt akarok...\"");
                Console.ReadKey();
                Console.WriteLine("\"csak... egy... Hellt... akarok...\"");
                Console.ReadKey();
                Console.WriteLine("\"C̴̖̻͕͐̓̈́̾͌̄s̵̡̘̲̫͌̃̈́̑̋á̷̗̤̤̇̅͊̈́̒͘͜k̷̨̢̖̦̺̱̍ ̶̟̪̩́͘ḙ̷̢͔̗̊͗g̵͇̦͉̭̟͌́̂̕ỹ̵̢̂ ̸͙̑̊͋̅̀͛̚͝ͅḢ̸̜͎͑̃̉̅̉͛͝e̵̹̼̥̽̈́̉͘ĺ̷͎̰͕̥͐l̶̢̢̩͖̲̪͕̃͜t̶͚̺̱͙̐͛̓̓ ̴͍̲͙̘͕͓̪̍̎̍́͠a̵̼̩͒͆̓̿̀̀̂k̴͖̥̙͓̫͚͑a̶̧͙̬̾̐̌̕͜͝r̸̯̹̈́́̕ǫ̴̧͕͑̉̇̿͘̚͠k̷̲̿̊́̈.̷̡̢̝̥̬̳͊́͜.̵̨̡̥̘̥̼̱͖̈́.̷̟̗͊\"");

                Console.ReadKey();
                Purgatorium();
            }

            else if (x == 3)
            {
                elozo_helyszin = "Purgatórium";
                elozo_hely_uzenete = "Harangozó Csongárd valami péntek estéről beszélt neked, vajon ez mit jelent?";

                Console.WriteLine("\"Péntek estéjén másnaposan felébredsz\"");
                Console.ReadKey();
                Console.WriteLine("\"Meg fogod látogatni a dorozsmai faluközpontot\"");
                Console.ReadKey();
                Console.WriteLine("\"Az éjféli misén meg fogod botránkoztatni a honfitársakat\"");
                Console.ReadKey();
                Console.WriteLine("\"Süke Bíborka majd ápol téged\"");

                Console.ReadKey();
                Purgatorium();
            }

            else
            {
                if (szent_korona_birtoklasa || (!bankrablas_megtortent && !rab_megrugva && !volt_e_verekedes_kocsmaban && !mehe_megolve && !ogrek_megolve))
                {
                    elozo_helyszin = "Purgatórium";
                    if (szent_korona_birtoklasa && (bankrablas_megtortent || rab_megrugva || volt_e_verekedes_kocsmaban || mehe_megolve || ogrek_megolve))
                    {
                        Console.WriteLine("Az Úr megszólal: \"Visszahoztad a koronám, elnézem bűneidet és átengedlek Mennyország kapuin\"");
                    }
                    if (szent_korona_birtoklasa && !bankrablas_megtortent && !rab_megrugva && !volt_e_verekedes_kocsmaban && !mehe_megolve && !ogrek_megolve)
                    {
                        Console.WriteLine("Az Úr ítélete: \"Összességében jó ember voltál és el is hoztad a koronám, egyenes utat kapsz a Mennyországba\"");
                    }
                    else
                    {
                        Console.WriteLine("Az Úr hozzád szól: \"Nagyjából jó életet éltél, egy kis szauna után mehetsz a Mennyországba\"");
                    }

                    Console.ReadKey();
                    //Mennyorszag();
                }

                else
                {
                    elozo_helyszin = "Purgatórium";
                    Console.WriteLine("Az Úr rádförmed: \"Bűnös lélek vagy, örök szenvedést érdemelsz, mondjuk ha elhoztad volna a koronám... Na mindegy, takarodj a szemem elől\"");

                    Console.ReadKey();
                    //Pokol();
                }
            }
        }
    }
}
