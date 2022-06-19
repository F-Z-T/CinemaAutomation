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
    public partial class Form2 : Form
    {

        public Form1 f1;
        public Form3 f3;


        public static string Isım = "", Soyisim = "", TC = "", Cinsiyet = "";


        public Form2()
        {
            InitializeComponent();            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
           
           f1 = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Form1")
                {
                    f1 = (Form1)f;
                }
            }
            if (f1 != null)
            {
                
                    foreach (Control c in f1.gbxKoltuklar.Controls)
                {
                    if (c is Button)
                    {
                        if (c.BackColor == Color.Red)
                        {
                            c.BackgroundImage = Image.FromFile("C:\\Users\\monster\\Desktop\\CinemaAutomation\\bos.jpg");
                        }
                    }
                }
            }

            this.Close();
        }

        public static  String[] Isımler = new string[0];

        private void btnOnay_Click(object sender, EventArgs e)
        {

            if(tbxTC.Text == "" || tbxIsım.Text == "" || tbxSoyisim.Text == "")   //TextBox'ların null olup olmadığıı kontrol et.
            {
                MessageBox.Show("Boş Alan Bırakamazsınız","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else  //Textboxlara giriş yapıldı girilen değerleri kontorol et..
            {
                if (tbxIsım.Text.Length < 3 || tbxSoyisim.Text.Length < 3)  //isim soyisim kontorlü
                {
                    MessageBox.Show("İsminizi ya da Soyisminizi eksik girdiniz.Lütfen Kontrol edin.");
                }
                else // isim soyisim yazımında belirlenen hatalar yoksa tc kontorlüne geç..
                {
                    if (tbxTC.TextLength < 11 || tbxTC.TextLength > 11)
                        MessageBox.Show("TC Kimlik numaranızı eksik girdiniz.Lütfen kontrol edin !! ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    else  //TC kontorlünde hatalı şartlar sağlanmadı cinsiyeti seçimi yapılıp yapılmadığını kontorl et.
                    {

                        if (!radioButton1.Checked && !radioButton2.Checked)
                        {
                            MessageBox.Show("Lütfen cinsiyetinizi seçiniz.");
                        }
                        else 
                        {
                            //Textboxlara giilen değerleri tutabilmek için değişke atadım.

                            Isım = tbxIsım.Text; 

                            Soyisim = tbxSoyisim.Text;

                            TC = tbxTC.Text;

                            if (radioButton1.Checked == true)
                            {
                                Cinsiyet = radioButton1.Text;
                            }
                            else if (radioButton2.Checked == true)
                            {
                                Cinsiyet = radioButton2.Text;
                            }


                            Array.Resize(ref Isımler, Isımler.Length + 1);
                            Isımler[Isımler.Length - 1] = Isım;

                           /* Array.Resize(ref Soylar, Soylar.Length + 1);
                            Soylar[Soylar.Length - 1] = Soyisim;*/



                            MessageBox.Show("Rezervasyon yapıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            this.Close();
                        }

                    }

                }

            }
        }

        private void tbxIsım_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))   // rakam dışında değer tut.
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))   // rakam dışında değer tut.
            {
                e.Handled = true;
            }
        }

        private void tbxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))   // harf dışında değer tut.
            {
                e.Handled = true;
            }
        }
    
    }
}
