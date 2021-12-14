using P03AplikacjaZawodnicy.ViewModles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Repositories
{
    class ZawodnicyRepository
    {
        public Zawodnik[] PodajZawodnikow()
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Zawodnik[] zawodnicy = db.Zawodnik.ToArray();
            return zawodnicy;
        }
    }
}
