using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonOnline2
{
    public class Koltuk : PictureBox, IKoltuk
    {
        public event RezerveHandler RezerveChanged;
        public Koltuk()
        {
            this.Image = new Bitmap(BosKoltukPath);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(36, 50);
            this.Name = Guid.NewGuid().ToString();
            this.Click += Form1.OrtakKoltuk_Clicked;
        }

        const string DoluKoltukPath = @"C:\Users\monster\Desktop\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\Assets\doluu.jpg";
        const string BosKoltukPath = @"C:\Users\monster\Desktop\SinemaOtomasyonOnline2\SinemaOtomasyonOnline2\Assets\bos.jpg";

        private bool isRezerve;
        public bool IsRezerve
        {
            get
            {
                return isRezerve;
            }
            set
            {
                isRezerve = value;

                if (this.RezerveChanged != null)
                    this.RezerveChanged(this);

                if (value)
                    this.Image = new Bitmap(DoluKoltukPath);
                else
                    this.Image = new Bitmap(BosKoltukPath);
                
            }
        }
        public Musteri Musteri { get; set; }
    }
}
