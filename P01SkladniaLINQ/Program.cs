using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01SkladniaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt

            string sciezka = "c:\\dane\\zawodnicy.txt";

            ManagerZawodnikow mz = new ManagerZawodnikow(TypZrodlaDanych.Lokalne, sciezka);
            mz.WczytajZawodnikow();

            Zawodnik[] dane = mz.Zawodnicy;

            //SQL 

            // problem: znajdz tylko polaków 

            // rozwiązanie klasyczne 
            List<Zawodnik> polacy = new List<Zawodnik>();
            for (int i = 0; i < dane.Length; i++)
                if (dane[i].Kraj == "POL")
                    polacy.Add(dane[i]);

            string kraj = "POL";

            Zawodnik[] polacyINiemcy=  
                dane.Where(x => x.Kraj == kraj || x.Kraj =="GER").ToArray();

            Zawodnik[] wynik1 =
              dane.Where(x => x.Kraj == kraj && x.Wzrost>170).ToArray();


            Zawodnik wynik2 = dane.Where(x => x.Id_zawodnika == 4).ToArray()[0];

            Zawodnik wynik3 = dane.Where(x => x.Id_zawodnika == 4).FirstOrDefault();

            Zawodnik wynik4 = dane.FirstOrDefault(x => x.Id_zawodnika == 4);

            // znajdz zawodników urodzonych w miesiącach parzystych 

            int a = 8;
            int b = a % 2;

            Zawodnik[] wynik5 = dane.Where(x => x.DataUr.Month % 2 == 0).ToArray();

            // 1) Wypisz zaawodników , których wzrost jest 2x większy niż waga
            // 2) Wypisz zawodników, którzy mają czertoliterowe imie lub nazwisko
            // 3) wypisz zawodników, którzych imie i nazwisko zaczyna się na tę samą literę
            // 4) wypisz zawodników, którzy nie mają trenera 
        }
    }
}
