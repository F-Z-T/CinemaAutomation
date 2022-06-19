using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
  Form2'de İsim Soyisim ve TC textboxları boş kalamıyor.
  Form2'de Tc 11 haneden küçük ya da büyük girilemiyor.
  Form2'de isim - Soyisim lenght > 3 koşulu var.
  Form 1 yüklenirken Butonlar runtime olarak ekrana geliyor.
  Form1'de Koltuk butonuna tıklandığı anda kırmızı oluyor Form2' de iptal butonuna basıldığında beyaz renge dönüyor.
  Form2'deki Textboxları doğru biçimde doldurduktan sonra onay butonuna basarsak kullanıcıdan alınan bilgiler Form3'deki listbox'a ekleniyor.
  Rezerveyi iptal etmek için Form1'de Yetkili girişi butonuna basılıyor.(error)
 */

namespace CinemaAutomation
{
    public partial class Form1 : Form
    {
        
       // public Form3 f3;
        public Form2 f2;

        public Form1()
        {
            InitializeComponent();
        }
    
        int sayac = 0;

        public void Form1_Load(object sender, EventArgs e)
        {
            #region Koltuklar

            int sayac = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;       
                    btn.Size = new Size(40,40);
                    btn.Location = new Point(j*40+40,i*40+40); //durma
                    btn.Name = sayac.ToString();
                    //btn.Text = sayac.ToString();
                    
                    
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage  = Image.FromFile("C:\\Users\\monster\\Desktop\\CinemaAutomation\\bos.jpg");
               
                    // istenilen noktalardaki butonları kaldırmak için bir koşul sağlandı.

                    if (j == 3 || j == 6 || j == 9 || j == 12)  
                    {
                        continue;
                }

                    if ((i == 0 || i == 2 || i == 4) && (j == 14 || j == 15))
                    {
                        continue;
                    }
                    if ((i == 0 || i == 2 || i == 4) && (j == 0 || j == 1))
                    {
                        continue;
                    }

                    sayac++;
                    this.gbxKoltuklar.Controls.Add(btn);  //koltuklar kutusuna koltukları ekleme

             #endregion

                    btn.Click += Btn_Click; // Butona basıldığında işlem yapabilme
                }

            }
         
        }

        public void Btn_Click(object sender, EventArgs e)
        {

             Button b = (Button)sender;   // butona basıldığında buton beyaz ise kırmızı olsun.
             if (b.BackColor == Color.White)
             {
                b.BackColor = Color.Red;
                b.BackgroundImage = Image.FromFile("C:\\Users\\monster\\Desktop\\CinemaAutomation\\doluu.jpg"); 

                 Form2 f2 = new Form2();
                 f2.Show();
                 f2.lblKoltuk.Text = b.Name;  //Buton numarasını form2 deki labelde gösterme.


            }
             else
             {
                 MessageBox.Show("Bu koltuk rezerve edilmiştir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }
    }
}
