using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy.Tools
{
    class PDFManager
    {
        public void WygenerujPDF(string sciezke, string[] linie)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            for (int i = 0; i < 10; i++)
            {
                gfx.DrawString("ala ma kota", font, XBrushes.Black, 20,20+ 20*i);
            }
            

            //gfx.DrawString("Hello, World!", font, XBrushes.Black,
            //    new XRect(0, 0, page.Width, page.Height),
            //    XStringFormats.Center);

           
            document.Save(sciezke);
        }
    }
}
