using P03AplikacjaZawodnicy.Operations;
using P03AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P03AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        ZawodnicyOperation zawodnicyOperation = new ZawodnicyOperation();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            // lbDane.DataSource = new ModelBazyDanychDataContext().Zawodnik.ToArray();
            //lbDane.DisplayMember = "nazwisko";

            zawodnicyOperation = new ZawodnicyOperation();
            var zawodnicy = zawodnicyOperation.PodajZawodnikow();

            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "PodstawoweDane";
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            zawodnicyOperation.WygenerujRaportPDF();
        }

        private void btnStrona_Click(object sender, EventArgs e)
        { 
            // string sciezka = System.Reflection.Assembly.GetEntryAssembly().Location; // razem z nazwą pliku
            string sciezka = Application.StartupPath;
            
            webBrowser1.Navigate(sciezka + "\\HelloWorld.pdf");
        }

        private void btnWygenerujPodsumowanie_Click(object sender, EventArgs e)
        {
            chartZawodnicy.Series.Clear();

            Series seria = new Series("wzrost");
            seria.ChartType = SeriesChartType.Column;

            var dw =  zawodnicyOperation.WygenerujDaneDoWykresu();

            seria.Points.DataBindXY(dw.X, dw.Y);
            chartZawodnicy.Series.Add(seria);
        }
    }
}
