using System;

namespace Savarankiskas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eilute = new string('-', 60);
            Knyga knyga1, knyga2, knyga3;
            knyga1 = new Knyga(100, 0.05, 55);
            knyga2 = new Knyga(185, 0.02, 50);
            knyga3 = new Knyga(185, 0.02, 40);
            Lentyna lentyna1;
            lentyna1 = new Lentyna(50, 130);
            lentyna1.ImtiLentynosAuksti = 1;
            lentyna1.ImtiLentynosIlgi = 1;
            Console.WriteLine("TIKRINIMAS LENTYNA: ");
            Console.WriteLine(lentyna1.ImtiLentynosAuksti);// patikrinti lenytnos auksti ar pasikeite
            Console.WriteLine(lentyna1.ImtiLentynosIlgi);// patikrinti lenytnos ilgi ar pasikeite
            double knygos1Ilgis = knyga1.KnygosIlgis(185, 0.5);
            double knygos2Ilgis = knyga2.KnygosIlgis(185, 0.2);
            double knygos3Ilgis = knyga3.KnygosIlgis(200, 0.02);
            double knyguIlgiuSuma = (knygos1Ilgis + knygos2Ilgis + knygos3Ilgis) * 10;
            double visosKnygosAukstis = VisosKnygosAukstis(knyga1, knyga2, knyga3);
            Console.WriteLine("TIKRINIMAS KNYGOS: ");
            Console.WriteLine("visu aukstis: " + VisosKnygosAukstis(knyga1, knyga2, knyga3)); //knygu auktis sudetas pasitikrinimui
            Console.WriteLine("visu ilgis: " + knyguIlgiuSuma);// visu knygu ilgis pasitikrinimui 
            Console.WriteLine(eilute);
            Console.WriteLine("  Puslapiu skaicius \t Puslapiu storis \t Knygos Aukstis");
            SpausdintiKnygas(knyga1);
            SpausdintiKnygas(knyga2);
            SpausdintiKnygas(knyga3);
            Console.WriteLine();
            Console.WriteLine(" Lentynos Aukstis \t Lentynos ilgis");
            SpausdintiLentyna(lentyna1);
            Console.WriteLine(eilute);
            Console.WriteLine("1 uzduotis");
            Console.WriteLine();
            MaziausiuPuslapiuStorisSpausdinimas(knyga1, knyga2, knyga3);
            StoriausiaKnygaSpausdinimas(knyga1, knyga2, knyga3);
            Console.WriteLine(eilute);
            Console.WriteLine("2 uzduotis");
            Console.WriteLine();
            Console.WriteLine("Ar tos trys knygos visos tilps lentynoje? ");
            ArTelpaSpausdinimas(knyguIlgiuSuma, visosKnygosAukstis, lentyna1);
            Console.WriteLine(eilute);
            Console.WriteLine("3 uzduotis");
            Console.WriteLine("Ar tilps visos tos knygos lentynoje, jeigu lentynos aukštis bus padidintas du kartus?");
            LentynosAukstisDuKartus(visosKnygosAukstis, lentyna1);
            Console.WriteLine("Ar tilps visos tos knygos lentynoje, jeigu lentynos ilgis bus padidintas du kartus?");
            LentynosIlgisDuKartus(knyguIlgiuSuma, lentyna1);
            Console.WriteLine(eilute);

            Console.ReadKey();
        }
        /// <summary>
        /// suranda maziausius puslapiu sotrius
        /// </summary>
        /// <param name="knyga1"></param>
        /// <param name="knyga2"></param>
        /// <param name="knyga3"></param>
        /// <returns></returns>
        static private double MaziausiasPuslapiuStoris(Knyga knyga1, Knyga knyga2, Knyga knyga3)
        {
            return Math.Min(Math.Min(knyga1.ImtiPuslapiuStori(), knyga2.ImtiPuslapiuStori()), knyga1.ImtiPuslapiuStori());
        }
        /// <summary>
        /// atspausdina maziausius puslapiu storius
        /// </summary>
        /// <param name="knyga1"></param>
        /// <param name="knyga2"></param>
        /// <param name="knyga3"></param>
        static public void MaziausiuPuslapiuStorisSpausdinimas(Knyga knyga1, Knyga knyga2, Knyga knyga3)
        {
            double maziausias = MaziausiasPuslapiuStoris(knyga1, knyga2, knyga3);
            if (maziausias == knyga1.ImtiPuslapiuStori())
                Console.WriteLine($"Maziausias puslapio storis: {knyga1.ImtiPuslapiuStori(),5:f2}  1 knyga");
            if (maziausias == knyga2.ImtiPuslapiuStori())
                Console.WriteLine($"Maziausias puslapio storis: {knyga2.ImtiPuslapiuStori(),5:f2}  2 knyga");
            if (maziausias == knyga3.ImtiPuslapiuStori())
                Console.WriteLine($"Maziausias puslapio storis: {knyga3.ImtiPuslapiuStori(),5:f2}  3 knyga");
        }
        /// <summary>
        /// randa storiausia knyga
        /// </summary>
        /// <param name="knyga1"></param>
        /// <param name="knyga2"></param>
        /// <param name="knyga3"></param>
        /// <returns></returns>
        static private double StoriausiaKnyga(Knyga knyga1, Knyga knyga2, Knyga knyga3)
        {
            return Math.Max(Math.Max(knyga1.ImtiPuslapiuSkaiciu(), knyga2.ImtiPuslapiuSkaiciu()), knyga1.ImtiPuslapiuSkaiciu());
        }
        /// <summary>
        /// atspausdina storiausia knyga
        /// </summary>
        /// <param name="knyga1">1 knyga</param>
        /// <param name="knyga2">2 knyga</param>
        /// <param name="knyga3">3 knyga</param>
        static public void StoriausiaKnygaSpausdinimas(Knyga knyga1, Knyga knyga2, Knyga knyga3)
        {
            double storiausias = StoriausiaKnyga(knyga1, knyga2, knyga3);
            if (storiausias == knyga1.ImtiPuslapiuSkaiciu())
                Console.WriteLine($"Storiausia knyga: {knyga1.ImtiPuslapiuSkaiciu(),5:f2}  1 knyga");
            if (storiausias == knyga2.ImtiPuslapiuSkaiciu())
                Console.WriteLine($"Storiausia knyga: {knyga2.ImtiPuslapiuSkaiciu(),5:f2}  2 knyga");
            if (storiausias == knyga3.ImtiPuslapiuSkaiciu())
                Console.WriteLine($"Storiausia knyga: {knyga3.ImtiPuslapiuSkaiciu(),5:f2}  3 knyga");
        }

        /// <summary>
        /// sudedu visu knygu aukscius
        /// </summary>
        /// <param name="knyga1">1 knyga</param>
        /// <param name="knyga2">2 knyga</param>
        /// <param name="knyga3">3 knyga</param>
        /// <returns></returns>
        static double VisosKnygosAukstis(Knyga knyga1, Knyga knyga2, Knyga knyga3)
        {
            return Math.Max(Math.Max(knyga1.ImtiKnygosAuksti(), knyga2.ImtiKnygosAuksti()), knyga1.ImtiKnygosAuksti());

        }
        /// <summary>
        /// atspausdina ar telpa 3 knygos lentynoje
        /// </summary>
        /// <param name="knyguIlgiuSuma">sudeti knygu ilgiai</param>
        /// <param name="visosKnygosAukstis">sudeti knygu auksciai</param>
        /// <param name="lentyna">lentyna ir jos matmenys</param>
        static void ArTelpaSpausdinimas(double knyguIlgiuSuma, double visosKnygosAukstis, Lentyna lentyna)
        {
            double tempLentynosAukstis = lentyna.ImtiLentynosAuksti;
            double tempLentynosIlgis = lentyna.ImtiLentynosIlgi;
            if ((tempLentynosAukstis >= visosKnygosAukstis) && (tempLentynosIlgis >= knyguIlgiuSuma))
            {
                Console.WriteLine("Tilps visos knygos");
            }
            else
                Console.WriteLine("Netilps visos knygos");


        }
        /// <summary>
        /// dauginu auksti du kartus, ir ziuriu ar tai bus daugiau ar maziau uz knygu auksciu suma
        /// </summary>
        /// <param name="visosKnygosAukstis">sudeti knygu auksciai</param>
        /// <param name="lentyna">lentyna, per ja pasilyginu</param>
        static void LentynosAukstisDuKartus(double visosKnygosAukstis, Lentyna lentyna)
        {
            double tempAukstis = lentyna.ImtiLentynosAuksti;
            if (tempAukstis * 2 > visosKnygosAukstis)
                Console.WriteLine("Taip");
            else
                Console.WriteLine("Ne");
        }
        /// <summary>
        /// dauginu ilgi du kartus, ir ziuriu ar tai bus daugiau ar maziau uz knygu ilgiu suma
        /// </summary>
        /// <param name="knyguIlgiuSuma">sudetos knygu sumos</param>
        /// <param name="lentyna"> lentyna, per ja pasilyginu</param>
        static void LentynosIlgisDuKartus(double knyguIlgiuSuma, Lentyna lentyna)
        {
            double tempAukstis = lentyna.ImtiLentynosIlgi;
            if (tempAukstis * 2 > knyguIlgiuSuma)
                Console.WriteLine("Taip");
            else
                Console.WriteLine("Ne");
        }
        /// <summary>
        /// Atspausdina knygu duomenis
        /// </summary>
        /// <param name="knyga">knygos</param>
        static public void SpausdintiKnygas(Knyga knyga)
        {
            Console.WriteLine($" {knyga.ImtiPuslapiuSkaiciu(),10} {knyga.ImtiPuslapiuStori(),20}{knyga.ImtiKnygosAuksti(),25}");
        }
        static public void SpausdintiLentyna(Lentyna lentyna)
        {
            Console.WriteLine($" {lentyna.ImtiLentynosAuksti,10} {lentyna.ImtiLentynosIlgi,20}");
        }
    }
}
