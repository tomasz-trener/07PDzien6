using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01SkladniaLINQ
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie { get; set; }
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUr;
        public int Wzrost;
        public int Waga;

        public string ImieNazwisko
        {
            get
            {
                return Imie + " " + Nazwisko;
            }
        }

        public string Wiersz
        {
            get
            {
                return $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUr.ToString("yyyy-MM-dd")};{Wzrost};{Waga}";
            }
        }

        // private int kolorWolsow;

        public Zawodnik()
        {

        }
        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            string napis = $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
            return napis;
        }
    }
}
