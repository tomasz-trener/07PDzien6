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

            // filtrowanie 

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

            Zawodnik[] wynik6 = dane.Where(x => x.Wzrost > x.Waga * 2).ToArray();

            // 2) Wypisz zawodników, którzy mają czertoliterowe imie lub nazwisko

            Zawodnik[] wynik7 = dane.Where(x => x.Imie.Length == 4).ToArray();

            // 3) wypisz zawodników, którzych imie i nazwisko zaczyna się na tę samą literę

            Zawodnik[] wyni8 = dane.Where(x => x.Imie[0] == x.Nazwisko[0]).ToArray();

            // 4) wypisz zawodników, którzy nie mają trenera 

            Zawodnik[] wynik9 = dane.Where(x => x.Id_trenera == null).ToArray();

            // sortowanie 

            Zawodnik[] wynik10 =  dane.OrderBy(x => x.Kraj).ToArray();

            Zawodnik[] wynik11 = dane.OrderByDescending(x => x.Kraj).ToArray();

            Zawodnik[] wynik12 = dane
                .OrderBy(x => x.Kraj)
                .ThenBy(x=>x.Wzrost)
                .ToArray();

           
            // 1) wypisz zawodników posortowanych po BMI

            // bmi = waga[kg]/wzrost[m]^2 

            Zawodnik[] wynik13 =
                dane.OrderBy(x => x.Waga / Math.Pow(x.Wzrost / 100.0, 2)).ToArray();

            Zawodnik[] wynik14 =
               dane.OrderBy(x=>x.BMI).ToArray();


         
           string[] wynik15 = dane.Select(x => x.Imie).ToArray();

           string[] wynik16 = dane.Select(x => x.Imie + " " + x.Nazwisko).ToArray();

            ZawodnikMini[] wynik17 =
                dane.
                    Select(x => new ZawodnikMini() { Imie = x.Imie, Nazwisko = x.Nazwisko })
                    .ToArray();

            var wynik18 =
                dane.
                    Select(x => new { MojeImie = x.Imie, MojeNazwisko = x.Nazwisko })
                    .ToArray();
            
            foreach (var z in wynik18)
                Console.WriteLine(z.MojeImie + " " + z.MojeNazwisko);

            // zad1 
            // stwórz tablice tpyu string która zawiera ciągi w potaci:
            // imie nazwisko (kraj) 
            // imie i nazwisko jest z dużych liter (pozotałe małe)
            // kraj w nawiasie 

            string[] wynik19= 
                dane.Select(x =>
                x.Imie.Substring(0, 1).ToUpper() +
                x.Imie.Substring(1).ToLower() + " " +
                x.Nazwisko.Substring(0, 1).ToUpper() +
                x.Nazwisko.Substring(1).ToLower() + " " +
                "(" + x.Kraj + ")").ToArray();


            // zad2 
            // narty skoczka nie mogą być dłuższe niz 146% jego wzrost u
            // stwórz nową tablicę typu double z maksymalną długością nart 


            double[] wynik20 = dane.Select(x => x.Wzrost * 1.46).ToArray();

            string[] wynik21 =
               dane.Select(x =>
               x.ImieNazwiskoDuze + " " +
               "(" + x.Kraj + ")").ToArray();

            string[] wynik22 =
                dane
                    .Where(x => x.Kraj == "POL")
                    .OrderBy(x => x.Wzrost)
                    .Select(x => x.ImieNazwisko)
                    .ToArray();

            string[] wynik23 =
             dane
                 .Where(x => x.Kraj == "POL")
                 .Select(x => x.ImieNazwisko)
                 .OrderBy(x => x)
                 .ToArray();

            string[] wynik24 =
              dane  
                  .Where(x => x.Kraj == "POL")
                  .OrderBy(x => x.Wzrost)
                  .Select(x => x.ImieNazwisko)
                  .ToArray();

            // wybierz unikalne kraje z zawodnikow

            string[] wynik25 = dane.Select(x => x.Kraj).Distinct().ToArray();

            // podaj średni wzrost zawodnikow 

            double wynik26=  dane.Select(x => x.Wzrost).Average();

            double wynik27= dane.Average(x => x.Wzrost);

            // podaj śrredni wzrost polakow 

            double wynik28= dane.Where(x => x.Kraj == "POL").Average(x => x.Wzrost);

            // podaj sredni wzrost dla kazdego kraju

            GrupaKraj[] wynik29=
                dane
                    .GroupBy(x => x.Kraj)
                    .Select(x => new GrupaKraj(x.Key, x.Average(y => y.Wzrost)))
                    .ToArray();
            
            
            var wynik30 =
            dane
                .GroupBy(x => x.Kraj)
                .Select(x => new { Kraj = x.Key, Wartosc = x.Average(y => y.Wzrost) })
                .ToArray();
                






            Console.ReadKey();
        }
    }
}
