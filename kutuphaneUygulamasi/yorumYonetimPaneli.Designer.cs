namespace kutuphaneUygulamasi
{
    partial class yorumYonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yorumYonetimPaneli));
            panelYorum1 = new Panel();
            tBoxYorumBasligi1 = new TextBox();
            btnYorumPencereKapat = new Button();
            btnYorumEdit = new Button();
            btnYorumSil = new Button();
            rTextBoxYorumGoster = new RichTextBox();
            btnYorumGoster = new Button();
            cBoxSonYorumlar = new ComboBox();
            labelYorumTitle = new Label();
            pBoxYorumTitle = new PictureBox();
            cBoxYorumKitapSec = new ComboBox();
            cBoxYorumKitapYorumlari = new ComboBox();
            rTextBoxKitapYorumlari = new RichTextBox();
            btnKitapYorumlariGoster = new Button();
            panelYorum1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxYorumTitle).BeginInit();
            SuspendLayout();
            // 
            // panelYorum1
            // 
            panelYorum1.BackgroundImage = (Image)resources.GetObject("panelYorum1.BackgroundImage");
            panelYorum1.Controls.Add(tBoxYorumBasligi1);
            panelYorum1.Controls.Add(btnYorumPencereKapat);
            panelYorum1.Controls.Add(btnYorumEdit);
            panelYorum1.Controls.Add(btnYorumSil);
            panelYorum1.Controls.Add(rTextBoxYorumGoster);
            panelYorum1.Controls.Add(btnYorumGoster);
            panelYorum1.Controls.Add(cBoxSonYorumlar);
            panelYorum1.Controls.Add(labelYorumTitle);
            panelYorum1.Controls.Add(pBoxYorumTitle);
            panelYorum1.Location = new Point(0, 0);
            panelYorum1.Name = "panelYorum1";
            panelYorum1.Size = new Size(200, 519);
            panelYorum1.TabIndex = 0;
            // 
            // tBoxYorumBasligi1
            // 
            tBoxYorumBasligi1.Location = new Point(4, 119);
            tBoxYorumBasligi1.Name = "tBoxYorumBasligi1";
            tBoxYorumBasligi1.Size = new Size(193, 23);
            tBoxYorumBasligi1.TabIndex = 3;
            tBoxYorumBasligi1.Text = "Yorum Başlığı:";
            // 
            // btnYorumPencereKapat
            // 
            btnYorumPencereKapat.Location = new Point(3, 383);
            btnYorumPencereKapat.Name = "btnYorumPencereKapat";
            btnYorumPencereKapat.Size = new Size(194, 35);
            btnYorumPencereKapat.TabIndex = 0;
            btnYorumPencereKapat.Text = "Pencereyi Kapat";
            btnYorumPencereKapat.UseVisualStyleBackColor = true;
            btnYorumPencereKapat.Click += btnYorumPencereKapat_Click;
            // 
            // btnYorumEdit
            // 
            btnYorumEdit.Location = new Point(3, 321);
            btnYorumEdit.Name = "btnYorumEdit";
            btnYorumEdit.Size = new Size(194, 35);
            btnYorumEdit.TabIndex = 2;
            btnYorumEdit.Text = "Yorumu Düzenle";
            btnYorumEdit.UseVisualStyleBackColor = true;
            btnYorumEdit.Click += btnYorumEdit_Click;
            // 
            // btnYorumSil
            // 
            btnYorumSil.Location = new Point(3, 280);
            btnYorumSil.Name = "btnYorumSil";
            btnYorumSil.Size = new Size(194, 35);
            btnYorumSil.TabIndex = 0;
            btnYorumSil.Text = "Yorumu Sil";
            btnYorumSil.UseVisualStyleBackColor = true;
            btnYorumSil.Click += btnYorumSil_Click;
            // 
            // rTextBoxYorumGoster
            // 
            rTextBoxYorumGoster.Location = new Point(3, 148);
            rTextBoxYorumGoster.Name = "rTextBoxYorumGoster";
            rTextBoxYorumGoster.Size = new Size(194, 125);
            rTextBoxYorumGoster.TabIndex = 2;
            rTextBoxYorumGoster.Text = "Seçtiğin yorum:";
            // 
            // btnYorumGoster
            // 
            btnYorumGoster.Location = new Point(3, 78);
            btnYorumGoster.Name = "btnYorumGoster";
            btnYorumGoster.Size = new Size(194, 35);
            btnYorumGoster.TabIndex = 2;
            btnYorumGoster.Text = "Seçilen Yorumu İncele";
            btnYorumGoster.UseVisualStyleBackColor = true;
            btnYorumGoster.Click += btnYorumGoster_Click;
            // 
            // cBoxSonYorumlar
            // 
            cBoxSonYorumlar.FormattingEnabled = true;
            cBoxSonYorumlar.Location = new Point(4, 49);
            cBoxSonYorumlar.Name = "cBoxSonYorumlar";
            cBoxSonYorumlar.Size = new Size(193, 23);
            cBoxSonYorumlar.TabIndex = 2;
            cBoxSonYorumlar.Text = "Yapılan son yorumlar:";
            // 
            // labelYorumTitle
            // 
            labelYorumTitle.AutoSize = true;
            labelYorumTitle.BackColor = Color.Transparent;
            labelYorumTitle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYorumTitle.ForeColor = Color.FromArgb(235, 235, 235);
            labelYorumTitle.Location = new Point(49, 0);
            labelYorumTitle.Name = "labelYorumTitle";
            labelYorumTitle.Size = new Size(76, 46);
            labelYorumTitle.TabIndex = 2;
            labelYorumTitle.Text = "Yorum\r\nYönetimi";
            // 
            // pBoxYorumTitle
            // 
            pBoxYorumTitle.BackColor = Color.Transparent;
            pBoxYorumTitle.Image = (Image)resources.GetObject("pBoxYorumTitle.Image");
            pBoxYorumTitle.Location = new Point(3, 3);
            pBoxYorumTitle.Name = "pBoxYorumTitle";
            pBoxYorumTitle.Size = new Size(40, 40);
            pBoxYorumTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxYorumTitle.TabIndex = 2;
            pBoxYorumTitle.TabStop = false;
            // 
            // cBoxYorumKitapSec
            // 
            cBoxYorumKitapSec.FormattingEnabled = true;
            cBoxYorumKitapSec.Location = new Point(206, 49);
            cBoxYorumKitapSec.Name = "cBoxYorumKitapSec";
            cBoxYorumKitapSec.Size = new Size(188, 23);
            cBoxYorumKitapSec.TabIndex = 2;
            cBoxYorumKitapSec.Text = "İncelemek istediğin kitap:";
            // 
            // cBoxYorumKitapYorumlari
            // 
            cBoxYorumKitapYorumlari.FormattingEnabled = true;
            cBoxYorumKitapYorumlari.Location = new Point(206, 119);
            cBoxYorumKitapYorumlari.Name = "cBoxYorumKitapYorumlari";
            cBoxYorumKitapYorumlari.Size = new Size(188, 23);
            cBoxYorumKitapYorumlari.TabIndex = 3;
            cBoxYorumKitapYorumlari.Text = "Kitaba ait yorumlar:";
            cBoxYorumKitapYorumlari.SelectedIndexChanged += cBoxYorumKitapYorumlari_SelectedIndexChanged_1;
            // 
            // rTextBoxKitapYorumlari
            // 
            rTextBoxKitapYorumlari.Location = new Point(206, 148);
            rTextBoxKitapYorumlari.Name = "rTextBoxKitapYorumlari";
            rTextBoxKitapYorumlari.Size = new Size(188, 125);
            rTextBoxKitapYorumlari.TabIndex = 4;
            rTextBoxKitapYorumlari.Text = "Seçtiğin yorum:";
            // 
            // btnKitapYorumlariGoster
            // 
            btnKitapYorumlariGoster.Location = new Point(206, 78);
            btnKitapYorumlariGoster.Name = "btnKitapYorumlariGoster";
            btnKitapYorumlariGoster.Size = new Size(188, 35);
            btnKitapYorumlariGoster.TabIndex = 0;
            btnKitapYorumlariGoster.Text = "Kitapa Ait Yorumları Göster";
            btnKitapYorumlariGoster.UseVisualStyleBackColor = true;
            btnKitapYorumlariGoster.Click += btnKitapYorumlariGoster_Click;
            // 
            // yorumYonetimPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(399, 421);
            Controls.Add(btnKitapYorumlariGoster);
            Controls.Add(rTextBoxKitapYorumlari);
            Controls.Add(cBoxYorumKitapYorumlari);
            Controls.Add(cBoxYorumKitapSec);
            Controls.Add(panelYorum1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "yorumYonetimPaneli";
            Text = "Yorum Yönetimi";
            panelYorum1.ResumeLayout(false);
            panelYorum1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxYorumTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelYorum1;
        private PictureBox pBoxYorumTitle;
        private Label labelYorumTitle;
        private ComboBox cBoxSonYorumlar;
        private Button btnYorumEdit;
        private Button btnYorumSil;
        private RichTextBox rTextBoxYorumGoster;
        private Button btnYorumGoster;
        private Button btnYorumPencereKapat;
        private ComboBox cBoxYorumKitapSec;
        private ComboBox cBoxYorumKitapYorumlari;
        private RichTextBox rTextBoxKitapYorumlari;
        private Button btnKitapYorumlariGoster;
        private TextBox tBoxYorumBasligi1;
    }
}