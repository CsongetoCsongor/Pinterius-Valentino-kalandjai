namespace PVK_MAIN
{
    internal partial class Program
    {


        public static string helyszin = "";
        
        public static string elozo_helyszin = "";

        public static string elozo_hely_uzenete = "";

        public static string szituacio = "";

        public static int jozansag = 100;

        public static int eletkedv = 50;

        public static int verszomj = 50;

        public static int penz = 0;

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

        public static bool rab_megrugva = false;


        static void Main(string[] args)
        {

            Console.WriteLine("Pinterius Valentino kalandjai, avagy az örök alkoholizmus útja");

            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine($"Előző helyszín: {elozo_helyszin}");
            Console.WriteLine();
            Console.WriteLine($"Helyszín: {helyszin}");
            Console.WriteLine();
            Console.WriteLine($"Életkedv: {eletkedv}\t Józanság: {jozansag}\t Vérszomj: {verszomj}");
            Console.WriteLine($"Személyes vagyon: {penz} krajcár");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(elozo_hely_uzenete);
            Console.WriteLine();
            Console.WriteLine(szituacio);



        }
    }
}