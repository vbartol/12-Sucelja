using System;

namespace Vsite.CSharp
{
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRođenja, string mjestoRođenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRođenja = datumRođenja;
            MjestoRođenja = mjestoRođenja;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, {3}", Ime, Prezime, DatumRođenja.ToShortDateString(), MjestoRođenja);
        }
        public int CompareTo(Osoba other)
        {
            int 
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public readonly string MjestoRođenja;
    }
}
