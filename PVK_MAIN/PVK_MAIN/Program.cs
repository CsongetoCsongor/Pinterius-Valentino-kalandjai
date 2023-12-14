using System.Diagnostics.Metrics;

namespace PVK_MAIN
{
    internal partial class Program
    {

        #region MainVariables
        public static string helyszin = "";

        public static string elozo_helyszin = "";

        public static string elozo_hely_uzenete = "";

        public static string szituacio = "";

        public static int jozansag = 100;

        public static int eletkedv = 50;

        public static int verszomj = 50;

        public static int penz = 0;

        public static bool kert_meglatogatva = false;

        public static bool buksza_birtoklasa = false;

        public static bool hajokulcs_birtoklasa = false;

        public static bool tengeri_gyongy_birtoklasa = false;

        public static bool volt_e_verekedes_kocsmaban = false;

        public static bool vadaszhaz_meglatogatva = false;

        public static bool fura_kulcs_birtoklasa = false;

        public static bool tarto_oszlop_eltova = false;

        public static bool jegygyuru_birtoklasa = false;

        public static bool karpatok_meglatogatva = false;

        public static bool aranykulcs_birtoklasa = false;

        public static bool bankrablas_megtortent = false;

        public static bool szent_korona_birtoklasa = false;

        public static bool wc_osszeokadva = false;

        public static bool rab_megrugva = false;

        public static bool mehe_megolve = false;

        public static bool temto_demon_atverve = false;

        public static bool koszoru_elfogyasztva = false;

        public static bool borospince_meglatogatva = false;

        public static bool otszaz_krajcar_elrakva = false;

        public static bool penz_szamlarol_leveve = false;

        public static bool kincsek_meglatva = false;

        public static bool sikolyok_meghallva = false;

        public static bool ogrek_szidva = false;

        public static bool ogrek_megolve = false;

        public static bool ver_meglatva = false;

        public static bool kikoto_meglatogatva = false;

        public static bool horgaszbolt_meglatogatva = false;

        public static bool etterem_meglatogatva = false;

        public static bool felebredve_start = false;





        #endregion
        public static int BekerLehetosegek(int max_szam)
        {
            int input;


            do
            {
                do
                {
                    Console.Write("Választás: ");

                }
                while (!int.TryParse(Console.ReadLine(), out input));
            } while (input > max_szam || input < 1);

            return input;
        }

        public static int NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(int szam)
        {
            if (szam >= 0 && szam <= 100)
            {
                return szam;
            }
            else if (szam < 0)
            {
                return 0;
            }
            else
            {
                return 100;
            }
        }


        public static void SzazasVerszomj()
        {
            if (verszomj == 100)
            {
                eletkedv -= 5;
                eletkedv = NagyobbVagyEgyenloNullaKisebbVagyEgyenloSzaz(eletkedv);
                Ongyilkossag("A hatalmas vérszomjadat nem sikerült kielégítened más vérével, ezért a sajátoddal kellett...");
            }
        }


        public static void IrjaKiAStatokat(string szituacio)
        {

            Console.WriteLine("Pinterius Valentino kalandjai, avagy az örök alkoholizmus útja");
            Console.WriteLine("---------------------------------------------------------------");

            if(verszomj == 100)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FIGYELEM!!! A vérszomjad túl magas. Minden választásnál csökken az életkedved!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }

            Console.WriteLine($"Előző helyszín: {elozo_helyszin}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Helyszín: {helyszin}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            //Console.WriteLine($"Életkedv: {eletkedv}\t Józanság: {jozansag}\t Vérszomj: {verszomj}");
            Console.Write("Életkedv: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(eletkedv + "%\t");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Józanság: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(jozansag+"%\t");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Vérszomj: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(verszomj + "%");
            Console.ForegroundColor = ConsoleColor.Gray;


            //Console.WriteLine($"Személyes vagyon: {penz} krajcár");
            Console.Write("Személyes vagyon: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(penz);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" krajcár");


            Console.WriteLine("---------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(elozo_hely_uzenete);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(szituacio);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void DetoxbaKuldes()
        {
            if(jozansag <= 0)
            {
                Detox();
            }
        }

        public static void Ongyilkossag(string reason)
        {
            if (eletkedv <= 0)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(reason);
                Console.ForegroundColor = ConsoleColor.Gray;
                elozo_hely_uzenete = "Túl kevés volt az életkedved, ezért megölted magad, az öngyilkosság pedig bűn.";
                Console.ReadKey();
                Pokol();
            }
        }


        static void Main(string[] args)
        {



            Otthon();

            //Pokol();

            //Menyorszag();



        }
    }
}