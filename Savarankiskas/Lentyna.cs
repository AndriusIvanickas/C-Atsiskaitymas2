namespace Savarankiskas
{
    internal class Lentyna
    {
        private double lentynosAukstis;
        private double lentynosIlgis;

        /// <summary>
        /// Konstruktorius
        /// </summary>
        /// <param name="aukstis">lentynos aukstis Centimetrais</param>
        /// <param name="ilgis">lentynos ilgis Centimetrais</param>
        /// 
        
        public Lentyna(double aukstis, double ilgis)
        {
            lentynosAukstis = aukstis;
            lentynosIlgis = ilgis;


        }
        /// <summary>
        /// paema lentynos auksti
        /// </summary>
        public double ImtiLentynosAuksti
        {
            get { return lentynosAukstis; }
            set
            {
                if ((value > 10000) && (value < 0))
                    System.Console.WriteLine("Aukstis netinkamas");

                else lentynosAukstis = value;
            }
        }
        /// <summary>
        /// paema lentynosilgi
        /// </summary>
        public double ImtiLentynosIlgi
        {
            get { return lentynosIlgis; }
            set
            {
                if ((value > 10000) && (value < 0))
                    System.Console.WriteLine("ilgis netinkamas");

                else lentynosIlgis = value;
            }

        }
    }
}
