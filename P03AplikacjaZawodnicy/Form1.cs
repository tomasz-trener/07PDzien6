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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            // lbDane.DataSource = new ModelBazyDanychDataContext().Zawodnik.ToArray();
            //lbDane.DisplayMember = "nazwisko";

            ZawodnicyOperation zo = new ZawodnicyOperation();
            var zawodnicy = zo.PodajZawodnikow();

            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "PodstawoweDane";
        }
    }
}
