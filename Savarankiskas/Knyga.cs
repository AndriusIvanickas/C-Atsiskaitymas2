namespace Savarankiskas
{
    /// <summary>
    /// Knygos duomenims saugoti
    /// </summary>
    internal class Knyga
    {
        private int puslapiuSkaicius;
        private double puslapiuStoris;
        private double knygosAukstis;
        /// <summary>
        /// Konstruktorius
        /// </summary>
        /// <param name="skaicius">puslapiu skaicius</param>
        /// <param name="storis">puslapiu storis</param>
        /// <param name="aukstis">knygos aukstis Centimetrais</param>
        /// 

        public Knyga(int skaicius, double storis, double aukstis)
        {
            puslapiuSkaicius = skaicius;
            puslapiuStoris = storis;
            knygosAukstis = aukstis;

        }
        /// <summary>
        /// paema puslapiu skaiciu
        /// </summary>
        /// <returns></returns>
        public int ImtiPuslapiuSkaiciu()
        {
            return puslapiuSkaicius;
        }
        /// <summary>
        /// paema puslapiu stori
        /// </summary>
        /// <returns></returns>
        public double ImtiPuslapiuStori()
        {
            return puslapiuStoris;
        }
        /// <summary>
        /// paema knygos auksti
        /// </summary>
        /// <returns></returns>
        public double ImtiKnygosAuksti()
        {
            return knygosAukstis;
        }
        /// <summary>
        /// paema knygod ilgi
        /// </summary>
        /// <param name="skaicius">puslapiu skaicius</param>
        /// <param name="storis">puslapiu storis</param>
        /// <returns></returns>
        public double KnygosIlgis(int skaicius, double storis)
        {
            return puslapiuSkaicius * puslapiuStoris;
        }
    }


}
