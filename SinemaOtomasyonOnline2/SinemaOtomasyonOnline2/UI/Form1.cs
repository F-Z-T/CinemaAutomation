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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void SinemaKoltuklariniCiz()
        {
            sinemaSalonu.SiraListesi = new List<int>() {8 , 12 };
            sinemaSalonu.GrupSayisi = 3;
            sinemaSalonu.Koltuklar.ForEach(koltuk => { koltuk.RezerveChanged += OrtakKoltuk_RezerveChanged; });
        }

        private void OrtakKoltuk_RezerveChanged(Koltuk koltuk)
        {
            eventListbox.Items.Add($"{koltuk.Musteri?.AdSoyad} adlı kişinin rezervasyonu " + (koltuk.IsRezerve ? "oluşturuldu" : "iptal edildi"));
        }

        public static void OrtakKoltuk_Clicked(object sender, EventArgs e)
        {
            Koltuk koltuk = sender as Koltuk;
            KoltukDetayForm koltukDetayForm = new KoltukDetayForm();
            koltukDetayForm.Koltuk = koltuk;
        }

        private void analizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalizForm form = new AnalizForm();
            form.Koltuklar = sinemaSalonu.Koltuklar;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SinemaKoltuklariniCiz();
        }
    }

    public delegate void RezerveHandler(Koltuk koltuk);
}
