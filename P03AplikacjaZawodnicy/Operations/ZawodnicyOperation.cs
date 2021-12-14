using P03AplikacjaZawodnicy.Repositories;
using P03AplikacjaZawodnicy.Tools;
using P03AplikacjaZawodnicy.ViewModles;
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
            
            PDFManager pm = new PDFManager();
            string sciezka= "HelloWorld.pdf";
         //   pm.WygenerujPDF(sciezka);
            Process.Start(sciezka);

            return null;
        }
    }
}
