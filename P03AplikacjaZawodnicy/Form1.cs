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
    }
}
