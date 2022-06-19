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
    public partial class KoltukDetayForm : Form
    {
        public KoltukDetayForm()
        {
            InitializeComponent();
        }

        private Koltuk koltuk;

        public Koltuk Koltuk
        {
            get { return koltuk; }
            set
            {
                koltuk = value;
                this.Show();
                this.adSoyadTextbox.Text = koltuk.Musteri?.AdSoyad;
                this.tcKimlikNoTextBox.Text = koltuk.Musteri?.TCKimlikNo;
                if (koltuk.Musteri?.Cinsiyet == Cinsiyet.Kadin)
                    kadinRadioButton.Checked = true;
                else
                    erkekRadioButton.Checked = true;

                iptalButton.Enabled = koltuk.IsRezerve;
            }
        }

        private void onaylaButton_Click(object sender, EventArgs e)
        {
            koltuk.Musteri = new Musteri()
            {
                AdSoyad = adSoyadTextbox.Text,
                TCKimlikNo = tcKimlikNoTextBox.Text,
                Cinsiyet = kadinRadioButton.Checked ? Cinsiyet.Kadin : Cinsiyet.Erkek
            };

            koltuk.IsRezerve = true;
            this.Close();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İptal etmek istediğinize emin misiniz ?","İptal Onayı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                koltuk.IsRezerve = false;
                koltuk.Musteri = null;
                this.Close();
            }
        }
    }
}
