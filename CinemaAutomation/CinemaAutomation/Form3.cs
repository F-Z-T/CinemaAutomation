using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class Form3 : Form
    {
        Form2 f2;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            // string[] list = new string[60];

            foreach (var item in Form2.Isımler )
            {
               // listBox1.Items.AddRange(Form2.Isımler);  //!!error:Tek Tek dizi tanımlayıp yapıldığında her seferinde diziyi tekrar yazıyor.

                listBox1.Items.Add(Form2.Isım + " " + Form2.Soyisim + " " + Form2.TC + " " + Form2.Cinsiyet); // !!!error: rezervazsyon kayıtları listboxa eklenirken son kayıt değerini alıp ekleniyor.
            }

            //int deger = listBox1.Items.Add(Form2.Isım + " "  + Form2.Soyisim + " " + Form2.TC + " " + Form2.Cinsiyet);

        }

        private void btnSıl_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                DialogResult onay = MessageBox.Show("Rezervasyon Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {                  
                    listBox1.Items.RemoveAt(secim);                  
                }
                
            }
            else
            {
                 MessageBox.Show("İptal edilemesi gereken rezervasyonu seçin.");
            }
        }
    }
}
