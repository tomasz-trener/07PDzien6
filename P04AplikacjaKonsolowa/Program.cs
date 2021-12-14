
using P05Biblioteka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] napisy = { "ala ma kota", "jan", "dom" };

            PDFManager pm = new PDFManager();
            pm.WygenerujPDF("plik.pdf", napisy);

        }
    }
}
