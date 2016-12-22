using System;
using System.Collections.Generic;

namespace Vsite.CSharp
{
    public class SmisaoSu�elja
    {
        class UsporedbaPoImenu : IComparer<Osoba>
        {
            public int Compare(Osoba x, Osoba y)
            {
                return x.Ime.CompareTo(y.Ime);
            }
        }
        static void Ispi�i(List<Osoba> list)
        {
            foreach (Osoba o in list)
                Console.WriteLine(o);
        }

        public static void SortiranoPoNe�emu(List<Osoba> osobe)
        {
            osobe.Sort();
        }

        public static void SortiranoPoImenu(List<Osoba> osobe)
        {
            UsporedbaPoImenu upi = new UsporedbaPoImenu();
            osobe.Sort(upi);
                // TODO: Koriste�i preoptere�enu ina�icu metode List<T>.Sort(IComparer(T)) abecedno sortirati osobe prema njihovim imenima.
        }

        public static void SortiranoPoDatumuRo�enja(List<Osoba> osobe)
        {
            osobe.Sort((x, y)=> x.DatumRo�enja.CompareTo(y.DatumRo�enja));
            // TODO: Koriste�i preoptere�enu ina�icu metode List<T>.Sort(Comparison(T)) sortirati osobe prema njihovim datumima ro�enja.
        }

        public static void SortiranoPoMjestuRo�enja(List<Osoba> osobe)
        {
            osobe.Sort((x, y) => x.MjestoRo�enja.CompareTo(y.MjestoRo�enja));
            // TODO: Koriste�i preoptere�enu ina�icu metode List<T>.Sort(Comparison(T)) osobe sortirati prema njihovim mjestima ro�enja.
        }

        static void Main(string[] args)
        {
            List<Osoba> popisOsoba = new List<Osoba>();

            popisOsoba.Add(new Osoba("Ana", "Mari�", new DateTime(1975, 7, 12), "Split"));
            popisOsoba.Add(new Osoba("�arko", "Levi�", new DateTime(1965, 12, 4), "Osijek"));
            popisOsoba.Add(new Osoba("Marko", "Karamati�", new DateTime(1983, 4, 2), "Sinj"));
            popisOsoba.Add(new Osoba("Tomislav", "Kralj", new DateTime(1971, 11, 5), "Beli Manastir"));

            Console.WriteLine("Ispis prije sortiranja:");
            Ispi�i(popisOsoba);
            Console.WriteLine();

            try
            {
                Console.WriteLine("Sortiramo podrazumijevano:");
                SortiranoPoNe�emu(popisOsoba);
                Ispi�i(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po imenu:");
                SortiranoPoImenu(popisOsoba);
                Ispi�i(popisOsoba);
                Console.WriteLine();

                Console.WriteLine("Sortiramo po datumu ro�enja:");
                SortiranoPoDatumuRo�enja(popisOsoba);
                Ispi�i(popisOsoba);

                Console.WriteLine("Sortiramo po mjestu ro�enja:");
                SortiranoPoMjestuRo�enja(popisOsoba);
                Ispi�i(popisOsoba);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
