namespace SinemaOtomasyonOnline2
{
    partial class KoltukDetayForm
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
            this.adSoyadLabel = new System.Windows.Forms.Label();
            this.adSoyadTextbox = new System.Windows.Forms.TextBox();
            this.tcKimlikLabel = new System.Windows.Forms.Label();
            this.tcKimlikNoTextBox = new System.Windows.Forms.TextBox();
            this.kadinRadioButton = new System.Windows.Forms.RadioButton();
            this.erkekRadioButton = new System.Windows.Forms.RadioButton();
            this.iptalButton = new System.Windows.Forms.Button();
            this.onaylaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adSoyadLabel
            // 
            this.adSoyadLabel.AutoSize = true;
            this.adSoyadLabel.Location = new System.Drawing.Point(12, 22);
            this.adSoyadLabel.Name = "adSoyadLabel";
            this.adSoyadLabel.Size = new System.Drawing.Size(62, 13);
            this.adSoyadLabel.TabIndex = 0;
            this.adSoyadLabel.Text = "Ad Soyad : ";
            // 
            // adSoyadTextbox
            // 
            this.adSoyadTextbox.Location = new System.Drawing.Point(90, 19);
            this.adSoyadTextbox.Name = "adSoyadTextbox";
            this.adSoyadTextbox.Size = new System.Drawing.Size(100, 20);
            this.adSoyadTextbox.TabIndex = 1;
            // 
            // tcKimlikLabel
            // 
            this.tcKimlikLabel.AutoSize = true;
            this.tcKimlikLabel.Location = new System.Drawing.Point(12, 53);
            this.tcKimlikLabel.Name = "tcKimlikLabel";
            this.tcKimlikLabel.Size = new System.Drawing.Size(77, 13);
            this.tcKimlikLabel.TabIndex = 2;
            this.tcKimlikLabel.Text = "TC Kimlik No : ";
            // 
            // tcKimlikNoTextBox
            // 
            this.tcKimlikNoTextBox.Location = new System.Drawing.Point(90, 50);
            this.tcKimlikNoTextBox.Name = "tcKimlikNoTextBox";
            this.tcKimlikNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tcKimlikNoTextBox.TabIndex = 1;
            // 
            // kadinRadioButton
            // 
            this.kadinRadioButton.AutoSize = true;
            this.kadinRadioButton.Location = new System.Drawing.Point(221, 22);
            this.kadinRadioButton.Name = "kadinRadioButton";
            this.kadinRadioButton.Size = new System.Drawing.Size(52, 17);
            this.kadinRadioButton.TabIndex = 3;
            this.kadinRadioButton.TabStop = true;
            this.kadinRadioButton.Text = "Kadın";
            this.kadinRadioButton.UseVisualStyleBackColor = true;
            // 
            // erkekRadioButton
            // 
            this.erkekRadioButton.AutoSize = true;
            this.erkekRadioButton.Location = new System.Drawing.Point(221, 53);
            this.erkekRadioButton.Name = "erkekRadioButton";
            this.erkekRadioButton.Size = new System.Drawing.Size(53, 17);
            this.erkekRadioButton.TabIndex = 3;
            this.erkekRadioButton.TabStop = true;
            this.erkekRadioButton.Text = "Erkek";
            this.erkekRadioButton.UseVisualStyleBackColor = true;
            // 
            // iptalButton
            // 
            this.iptalButton.Location = new System.Drawing.Point(115, 89);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(75, 23);
            this.iptalButton.TabIndex = 4;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // onaylaButton
            // 
            this.onaylaButton.Location = new System.Drawing.Point(199, 89);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(75, 23);
            this.onaylaButton.TabIndex = 4;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = true;
            this.onaylaButton.Click += new System.EventHandler(this.onaylaButton_Click);
            // 
            // KoltukDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 136);
            this.Controls.Add(this.onaylaButton);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.erkekRadioButton);
            this.Controls.Add(this.kadinRadioButton);
            this.Controls.Add(this.tcKimlikLabel);
            this.Controls.Add(this.tcKimlikNoTextBox);
            this.Controls.Add(this.adSoyadTextbox);
            this.Controls.Add(this.adSoyadLabel);
            this.Name = "KoltukDetayForm";
            this.Text = "KoltukDetayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adSoyadLabel;
        private System.Windows.Forms.TextBox adSoyadTextbox;
        private System.Windows.Forms.Label tcKimlikLabel;
        private System.Windows.Forms.TextBox tcKimlikNoTextBox;
        private System.Windows.Forms.RadioButton kadinRadioButton;
        private System.Windows.Forms.RadioButton erkekRadioButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.Button onaylaButton;
    }
}