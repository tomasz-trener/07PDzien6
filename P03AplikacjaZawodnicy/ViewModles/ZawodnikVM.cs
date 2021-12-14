using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.ViewModles
{
    class ZawodnikVM
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public string PodstawoweDane {  get { return Imie + " " + Nazwisko + " " + Kraj; } }
    }
}
