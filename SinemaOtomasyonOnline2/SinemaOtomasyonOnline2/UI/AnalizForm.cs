using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public partial class AnalizForm : Form
    {
        public AnalizForm()
        {
            InitializeComponent();
        }

        private List<Koltuk> koltuklar;

        public List<Koltuk> Koltuklar
        {
            get { return koltuklar; }
            set
            {
                koltuklar = value;
                this.Show();
                IstatistikleriAnalizEt();
            }
        }

        private void IstatistikleriAnalizEt()
        {
            kisiSayisiLabel.Text = koltuklar.Where(x => x.IsRezerve).Count().ToString();

            cinsiyetChart.Series["Cinsiyet"].Points.AddXY("Kadın", koltuklar.Where(x => x.IsRezerve && x.Musteri.Cinsiyet == Cinsiyet.Kadin).Count());
            cinsiyetChart.Series["Cinsiyet"].Points.AddXY("Erkek", koltuklar.Where(x => x.IsRezerve && x.Musteri.Cinsiyet == Cinsiyet.Erkek).Count());
        }
    }
}
