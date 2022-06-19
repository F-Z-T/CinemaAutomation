namespace SinemaOtomasyonOnline2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.koltuklarLabel = new System.Windows.Forms.Label();
            this.bosKoltukLabel = new System.Windows.Forms.Label();
            this.doluKoltukLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinemaSalonu = new SinemaOtomasyonOnline2.SinemaSalonu();
            this.koltuk2 = new SinemaOtomasyonOnline2.Koltuk();
            this.koltuk1 = new SinemaOtomasyonOnline2.Koltuk();
            this.eventListbox = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk1)).BeginInit();
            this.SuspendLayout();
            // 
            // koltuklarLabel
            // 
            this.koltuklarLabel.AutoSize = true;
            this.koltuklarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koltuklarLabel.Location = new System.Drawing.Point(16, 48);
            this.koltuklarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koltuklarLabel.Name = "koltuklarLabel";
            this.koltuklarLabel.Size = new System.Drawing.Size(83, 20);
            this.koltuklarLabel.TabIndex = 0;
            this.koltuklarLabel.Text = "Koltuklar";
            // 
            // bosKoltukLabel
            // 
            this.bosKoltukLabel.AutoSize = true;
            this.bosKoltukLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bosKoltukLabel.Location = new System.Drawing.Point(24, 140);
            this.bosKoltukLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bosKoltukLabel.Name = "bosKoltukLabel";
            this.bosKoltukLabel.Size = new System.Drawing.Size(35, 17);
            this.bosKoltukLabel.TabIndex = 3;
            this.bosKoltukLabel.Text = "Boş";
            // 
            // doluKoltukLabel
            // 
            this.doluKoltukLabel.AutoSize = true;
            this.doluKoltukLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doluKoltukLabel.Location = new System.Drawing.Point(92, 140);
            this.doluKoltukLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doluKoltukLabel.Name = "doluKoltukLabel";
            this.doluKoltukLabel.Size = new System.Drawing.Size(41, 17);
            this.doluKoltukLabel.TabIndex = 3;
            this.doluKoltukLabel.Text = "Dolu";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(763, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analizToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menü";
            // 
            // analizToolStripMenuItem
            // 
            this.analizToolStripMenuItem.Name = "analizToolStripMenuItem";
            this.analizToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.analizToolStripMenuItem.Text = "Analiz";
            this.analizToolStripMenuItem.Click += new System.EventHandler(this.analizToolStripMenuItem_Click);
            // 
            // sinemaSalonu
            // 
            this.sinemaSalonu.AutoSize = true;
            this.sinemaSalonu.GrupSayisi = 0;
            this.sinemaSalonu.Location = new System.Drawing.Point(20, 174);
            this.sinemaSalonu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sinemaSalonu.Name = "sinemaSalonu";
            this.sinemaSalonu.SiraListesi = ((System.Collections.Generic.List<int>)(resources.GetObject("sinemaSalonu.SiraListesi")));
            this.sinemaSalonu.Size = new System.Drawing.Size(48, 62);
            this.sinemaSalonu.TabIndex = 4;
            // 
            // koltuk2
            // 
            this.koltuk2.Image = ((System.Drawing.Image)(resources.GetObject("koltuk2.Image")));
            this.koltuk2.IsRezerve = true;
            this.koltuk2.Location = new System.Drawing.Point(91, 75);
            this.koltuk2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.koltuk2.Musteri = null;
            this.koltuk2.Name = "koltuk2";
            this.koltuk2.Size = new System.Drawing.Size(48, 62);
            this.koltuk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.koltuk2.TabIndex = 2;
            this.koltuk2.TabStop = false;
            // 
            // koltuk1
            // 
            this.koltuk1.Image = ((System.Drawing.Image)(resources.GetObject("koltuk1.Image")));
            this.koltuk1.IsRezerve = false;
            this.koltuk1.Location = new System.Drawing.Point(20, 75);
            this.koltuk1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.koltuk1.Musteri = null;
            this.koltuk1.Name = "koltuk1";
            this.koltuk1.Size = new System.Drawing.Size(48, 62);
            this.koltuk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.koltuk1.TabIndex = 1;
            this.koltuk1.TabStop = false;
            // 
            // eventListbox
            // 
            this.eventListbox.FormattingEnabled = true;
            this.eventListbox.ItemHeight = 16;
            this.eventListbox.Location = new System.Drawing.Point(147, 48);
            this.eventListbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventListbox.Name = "eventListbox";
            this.eventListbox.Size = new System.Drawing.Size(556, 100);
            this.eventListbox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(763, 576);
            this.Controls.Add(this.eventListbox);
            this.Controls.Add(this.sinemaSalonu);
            this.Controls.Add(this.doluKoltukLabel);
            this.Controls.Add(this.bosKoltukLabel);
            this.Controls.Add(this.koltuk2);
            this.Controls.Add(this.koltuk1);
            this.Controls.Add(this.koltuklarLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koltuk1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label koltuklarLabel;
        private Koltuk koltuk1;
        private Koltuk koltuk2;
        private System.Windows.Forms.Label bosKoltukLabel;
        private System.Windows.Forms.Label doluKoltukLabel;
        private SinemaSalonu sinemaSalonu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizToolStripMenuItem;
        private System.Windows.Forms.ListBox eventListbox;
    }
}

