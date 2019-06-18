using System;
using System.Threading;

namespace Aplikacija
{
    class Program
    {

        public class Zbrajanje
        {
            public static int zbroj = 0;
            public static void Zbrajanje_dretva()
            {
                for (int broj_interacija = 0; broj_interacija < 5; broj_interacija++) {
                    int lokalna_kopija = zbroj;
                    Random random = new Random();
                    int milisekunde = random.Next(1, 1000);
                    Thread.Sleep(milisekunde);
                    lokalna_kopija = lokalna_kopija + 1;
                    zbroj = lokalna_kopija;
                    Console.WriteLine("Stanje variable zbroj: {0}", zbroj);
                }
            }


            static void Main(string[] args)
            {

                Thread dretva_1 = new Thread(new ThreadStart(Zbrajanje_dretva));
                Thread dretva_2 = new Thread(new ThreadStart(Zbrajanje_dretva));
                Thread dretva_3 = new Thread(new ThreadStart(Zbrajanje_dretva));
                Thread dretva_4 = new Thread(new ThreadStart(Zbrajanje_dretva));
                Thread dretva_5 = new Thread(new ThreadStart(Zbrajanje_dretva));

                dretva_1.Start();
                dretva_2.Start();
                dretva_3.Start();
                dretva_4.Start();
                dretva_5.Start();
                
                Console.ReadKey();
            }
        }
    }
}
