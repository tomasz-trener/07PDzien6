using P03AplikacjaZawodnicy.Repositories;
using P03AplikacjaZawodnicy.ViewModles;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
