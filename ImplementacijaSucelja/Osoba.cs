using System;

namespace Vsite.CSharp
{
    public class Osoba : IComparable<Osoba>
    {
        public Osoba(string ime, string prezime, DateTime datumRo�enja, string mjestoRo�enja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRo�enja = datumRo�enja;
            MjestoRo�enja = mjestoRo�enja;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}, {3}", Ime, Prezime, DatumRo�enja.ToShortDateString(), MjestoRo�enja);
        }
        public int CompareTo(Osoba other)
        {
            int 
        }

        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRo�enja;
        public readonly string MjestoRo�enja;
    }
}
