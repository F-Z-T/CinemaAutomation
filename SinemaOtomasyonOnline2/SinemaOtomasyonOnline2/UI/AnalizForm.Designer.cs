namespace SinemaOtomasyonOnline2
{
    partial class AnalizForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.kisiLabel = new System.Windows.Forms.Label();
            this.kisiSayisiLabel = new System.Windows.Forms.Label();
            this.cinsiyetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetChart)).BeginInit();
            this.SuspendLayout();
            // 
            // kisiLabel
            // 
            this.kisiLabel.AutoSize = true;
            this.kisiLabel.Location = new System.Drawing.Point(13, 13);
            this.kisiLabel.Name = "kisiLabel";
            this.kisiLabel.Size = new System.Drawing.Size(132, 13);
            this.kisiLabel.TabIndex = 0;
            this.kisiLabel.Text = "Sinema izleyen kişi sayısı : ";
            // 
            // kisiSayisiLabel
            // 
            this.kisiSayisiLabel.AutoSize = true;
            this.kisiSayisiLabel.Location = new System.Drawing.Point(143, 14);
            this.kisiSayisiLabel.Name = "kisiSayisiLabel";
            this.kisiSayisiLabel.Size = new System.Drawing.Size(0, 13);
            this.kisiSayisiLabel.TabIndex = 1;
            // 
            // cinsiyetChart
            // 
            chartArea1.Name = "ChartArea1";
            this.cinsiyetChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cinsiyetChart.Legends.Add(legend1);
            this.cinsiyetChart.Location = new System.Drawing.Point(16, 48);
            this.cinsiyetChart.Name = "cinsiyetChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cinsiyet";
            this.cinsiyetChart.Series.Add(series1);
            this.cinsiyetChart.Size = new System.Drawing.Size(300, 183);
            this.cinsiyetChart.TabIndex = 2;
            this.cinsiyetChart.Text = "chart1";
            // 
            // AnalizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 257);
            this.Controls.Add(this.cinsiyetChart);
            this.Controls.Add(this.kisiSayisiLabel);
            this.Controls.Add(this.kisiLabel);
            this.Name = "AnalizForm";
            this.Text = "AnalizForm";
            ((System.ComponentModel.ISupportInitialize)(this.cinsiyetChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kisiLabel;
        private System.Windows.Forms.Label kisiSayisiLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart cinsiyetChart;
    }
}