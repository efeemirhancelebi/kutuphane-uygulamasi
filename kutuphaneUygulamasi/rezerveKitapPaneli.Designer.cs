namespace kutuphaneUygulamasi
{
    partial class rezerveKitapPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rezerveKitapPaneli));
            labelRezTitle = new Label();
            labelRezAd = new Label();
            labelRezSoyad = new Label();
            label3 = new Label();
            cBoxRezKitaplar = new ComboBox();
            tBoxRezAd = new TextBox();
            tBoxRezSoyad = new TextBox();
            rTextBoxAdres = new RichTextBox();
            gBoxRezUyeBilg = new GroupBox();
            gBoxRezUyeBilg.SuspendLayout();
            SuspendLayout();
            // 
            // labelRezTitle
            // 
            labelRezTitle.AutoSize = true;
            labelRezTitle.BackColor = Color.Transparent;
            labelRezTitle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRezTitle.Location = new Point(112, 9);
            labelRezTitle.Name = "labelRezTitle";
            labelRezTitle.Size = new Size(176, 23);
            labelRezTitle.TabIndex = 0;
            labelRezTitle.Text = "Rezerve Kitap Bilgileri";
            // 
            // labelRezAd
            // 
            labelRezAd.AutoSize = true;
            labelRezAd.BackColor = Color.Transparent;
            labelRezAd.Location = new Point(6, 54);
            labelRezAd.Name = "labelRezAd";
            labelRezAd.Size = new Size(110, 15);
            labelRezAd.TabIndex = 1;
            labelRezAd.Text = "Kitap Sahibinin Adı:";
            // 
            // labelRezSoyad
            // 
            labelRezSoyad.AutoSize = true;
            labelRezSoyad.BackColor = Color.Transparent;
            labelRezSoyad.Location = new Point(71, 83);
            labelRezSoyad.Name = "labelRezSoyad";
            labelRezSoyad.Size = new Size(45, 15);
            labelRezSoyad.TabIndex = 2;
            labelRezSoyad.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(73, 112);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Adresi:";
            // 
            // cBoxRezKitaplar
            // 
            cBoxRezKitaplar.FormattingEnabled = true;
            cBoxRezKitaplar.Location = new Point(94, 22);
            cBoxRezKitaplar.Name = "cBoxRezKitaplar";
            cBoxRezKitaplar.Size = new Size(200, 23);
            cBoxRezKitaplar.TabIndex = 4;
            cBoxRezKitaplar.Text = "Rezerve Kitaplar: ";
            cBoxRezKitaplar.SelectedIndexChanged += cBoxRezKitaplar_SelectedIndexChanged;
            // 
            // tBoxRezAd
            // 
            tBoxRezAd.Location = new Point(122, 51);
            tBoxRezAd.Name = "tBoxRezAd";
            tBoxRezAd.Size = new Size(172, 23);
            tBoxRezAd.TabIndex = 5;
            // 
            // tBoxRezSoyad
            // 
            tBoxRezSoyad.Location = new Point(122, 80);
            tBoxRezSoyad.Name = "tBoxRezSoyad";
            tBoxRezSoyad.Size = new Size(172, 23);
            tBoxRezSoyad.TabIndex = 6;
            // 
            // rTextBoxAdres
            // 
            rTextBoxAdres.Location = new Point(122, 109);
            rTextBoxAdres.Name = "rTextBoxAdres";
            rTextBoxAdres.Size = new Size(172, 96);
            rTextBoxAdres.TabIndex = 7;
            rTextBoxAdres.Text = "";
            // 
            // gBoxRezUyeBilg
            // 
            gBoxRezUyeBilg.BackColor = Color.Transparent;
            gBoxRezUyeBilg.Controls.Add(cBoxRezKitaplar);
            gBoxRezUyeBilg.Controls.Add(rTextBoxAdres);
            gBoxRezUyeBilg.Controls.Add(labelRezAd);
            gBoxRezUyeBilg.Controls.Add(tBoxRezSoyad);
            gBoxRezUyeBilg.Controls.Add(labelRezSoyad);
            gBoxRezUyeBilg.Controls.Add(tBoxRezAd);
            gBoxRezUyeBilg.Controls.Add(label3);
            gBoxRezUyeBilg.Location = new Point(50, 75);
            gBoxRezUyeBilg.Name = "gBoxRezUyeBilg";
            gBoxRezUyeBilg.Size = new Size(300, 215);
            gBoxRezUyeBilg.TabIndex = 8;
            gBoxRezUyeBilg.TabStop = false;
            gBoxRezUyeBilg.Text = "Üye Bilgileri";
            // 
            // rezerveKitapPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(384, 311);
            Controls.Add(gBoxRezUyeBilg);
            Controls.Add(labelRezTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "rezerveKitapPaneli";
            Text = "Rezerve Kitaplar Kimlerde?";
            gBoxRezUyeBilg.ResumeLayout(false);
            gBoxRezUyeBilg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRezTitle;
        private Label labelRezAd;
        private Label labelRezSoyad;
        private Label label3;
        private ComboBox cBoxRezKitaplar;
        private TextBox tBoxRezAd;
        private TextBox tBoxRezSoyad;
        private RichTextBox rTextBoxAdres;
        private GroupBox gBoxRezUyeBilg;
    }
}