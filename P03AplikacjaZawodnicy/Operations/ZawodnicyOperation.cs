using P03AplikacjaZawodnicy.Domain;
using P03AplikacjaZawodnicy.Repositories;

using P03AplikacjaZawodnicy.ViewModles;
using P05Biblioteka;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Operations
{
    class ZawodnicyOperation
    {
        ZawodnicyRepository zawodnicyRepository = new ZawodnicyRepository();
        public ZawodnikVM[] PodajZawodnikow()
        {
            var zawodnicy = zawodnicyRepository.PodajZawodnikow();

            return zawodnicy.Select(x => new ZawodnikVM()
            {
                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj
            }).ToArray();
        }

        public ZawodnikVM[] WygenerujRaportPDF()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zaw =  zr.PodajZawodnikow();
            string[] linie = zaw.Select(x => x.imie + " " + x.nazwisko + " " + x.kraj).ToArray();
            PDFManager pm = new PDFManager();
            string sciezka= "HelloWorld.pdf";
            pm.WygenerujPDF(sciezka, linie);
            Process.Start(sciezka);

            return zaw.Select(x => new ZawodnikVM()
            {
                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj
            }).ToArray();
        }

        public DaneWykresu WygenerujDaneDoWykresu()
        {
            var zawodnicy = zawodnicyRepository.PodajZawodnikow();
            var grupy =  zawodnicy
                .Where(x=>x.wzrost != null)
                .GroupBy(x => x.kraj)
                .Select(x => new { Kraj = x.Key, Wzrost = x.Average(y => y.wzrost) }).ToArray();

            DaneWykresu daneWykresu = new DaneWykresu();
            daneWykresu.X = grupy.Select(x => x.Kraj).ToArray();
            daneWykresu.Y = grupy.Select(x => (double)x.Wzrost).ToArray();
            return daneWykresu;
        }
    }
}
