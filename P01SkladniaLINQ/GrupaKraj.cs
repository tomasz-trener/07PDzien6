using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01SkladniaLINQ
{
    class GrupaKraj
    {
        public string NazwaKraju;
        public double SredniaWartosc;

        public GrupaKraj(string nazwaKraju, double sredniaWartosc)
        {
            NazwaKraju = nazwaKraju;
            SredniaWartosc = sredniaWartosc;
        }
    }
}
