namespace kutuphaneUygulamasi
{
    partial class kutuphaneUygulamasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kutuphaneUygulamasi));
            panelUserAraclar1 = new Panel();
            lBoxKitaplar = new ListBox();
            btnKitapVer = new Button();
            radioRezSureDolmadi = new RadioButton();
            radioRezSureDoldu = new RadioButton();
            labelRezSure = new Label();
            pBoxUser = new PictureBox();
            labelUserName = new Label();
            btnKitapTeslim = new Button();
            btnKitapRez = new Button();
            panelUserAraclar2 = new Panel();
            lBoxKullaniciYorum = new ListBox();
            cBoxKullaniciYorum = new ComboBox();
            labelYorumYonetimi = new Label();
            btnYorumYonet = new Button();
            btnDigerYorum = new Button();
            btnYorumYap = new Button();
            btnCikis = new Button();
            rTextBoxKitapRez = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            cBoxRezKitaplar = new ComboBox();
            lBoxRezKitaplar = new ListBox();
            labelKitapYonetimi = new Label();
            cBoxBitenKitaplar = new ComboBox();
            rTextBoxYorum = new RichTextBox();
            textBox1 = new TextBox();
            labelImza = new LinkLabel();
            panelUserAraclar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxUser).BeginInit();
            panelUserAraclar2.SuspendLayout();
            SuspendLayout();
            // 
            // panelUserAraclar1
            // 
            panelUserAraclar1.BackgroundImage = (Image)resources.GetObject("panelUserAraclar1.BackgroundImage");
            panelUserAraclar1.Controls.Add(lBoxKitaplar);
            panelUserAraclar1.Controls.Add(btnKitapVer);
            panelUserAraclar1.Controls.Add(radioRezSureDolmadi);
            panelUserAraclar1.Controls.Add(radioRezSureDoldu);
            panelUserAraclar1.Controls.Add(labelRezSure);
            panelUserAraclar1.Controls.Add(pBoxUser);
            panelUserAraclar1.Controls.Add(labelUserName);
            panelUserAraclar1.Controls.Add(btnKitapTeslim);
            panelUserAraclar1.Controls.Add(btnKitapRez);
            panelUserAraclar1.Location = new Point(0, 0);
            panelUserAraclar1.Name = "panelUserAraclar1";
            panelUserAraclar1.Size = new Size(200, 518);
            panelUserAraclar1.TabIndex = 1;
            // 
            // lBoxKitaplar
            // 
            lBoxKitaplar.FormattingEnabled = true;
            lBoxKitaplar.ItemHeight = 15;
            lBoxKitaplar.Items.AddRange(new object[] { "Tüm Kitaplar:" });
            lBoxKitaplar.Location = new Point(3, 207);
            lBoxKitaplar.Name = "lBoxKitaplar";
            lBoxKitaplar.Size = new Size(194, 214);
            lBoxKitaplar.TabIndex = 8;
            // 
            // btnKitapVer
            // 
            btnKitapVer.Image = (Image)resources.GetObject("btnKitapVer.Image");
            btnKitapVer.Location = new Point(3, 459);
            btnKitapVer.Name = "btnKitapVer";
            btnKitapVer.Size = new Size(194, 40);
            btnKitapVer.TabIndex = 3;
            btnKitapVer.Text = "Kütüphaneye Kitap \r\nBağışlamak İster Misin?";
            btnKitapVer.TextAlign = ContentAlignment.MiddleRight;
            btnKitapVer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapVer.UseVisualStyleBackColor = true;
            // 
            // radioRezSureDolmadi
            // 
            radioRezSureDolmadi.AutoSize = true;
            radioRezSureDolmadi.BackColor = Color.Transparent;
            radioRezSureDolmadi.ForeColor = Color.FromArgb(235, 235, 235);
            radioRezSureDolmadi.Location = new Point(96, 167);
            radioRezSureDolmadi.Name = "radioRezSureDolmadi";
            radioRezSureDolmadi.Size = new Size(108, 34);
            radioRezSureDolmadi.TabIndex = 7;
            radioRezSureDolmadi.TabStop = true;
            radioRezSureDolmadi.Text = "Rezervasyon\r\nsürem dolmadı.";
            radioRezSureDolmadi.UseVisualStyleBackColor = false;
            // 
            // radioRezSureDoldu
            // 
            radioRezSureDoldu.AutoSize = true;
            radioRezSureDoldu.BackColor = Color.Transparent;
            radioRezSureDoldu.ForeColor = Color.FromArgb(235, 235, 235);
            radioRezSureDoldu.Location = new Point(0, 167);
            radioRezSureDoldu.Name = "radioRezSureDoldu";
            radioRezSureDoldu.Size = new Size(95, 34);
            radioRezSureDoldu.TabIndex = 7;
            radioRezSureDoldu.TabStop = true;
            radioRezSureDoldu.Text = "Rezervasyon \r\nsürem doldu.";
            radioRezSureDoldu.UseVisualStyleBackColor = false;
            // 
            // labelRezSure
            // 
            labelRezSure.AutoSize = true;
            labelRezSure.BackColor = Color.Transparent;
            labelRezSure.ForeColor = Color.FromArgb(235, 235, 235);
            labelRezSure.Location = new Point(20, 96);
            labelRezSure.Name = "labelRezSure";
            labelRezSure.Size = new Size(161, 15);
            labelRezSure.TabIndex = 7;
            labelRezSure.Text = "Kitabın Teslim Edileceği Tarih:";
            // 
            // pBoxUser
            // 
            pBoxUser.BackColor = Color.Transparent;
            pBoxUser.Image = (Image)resources.GetObject("pBoxUser.Image");
            pBoxUser.Location = new Point(3, 3);
            pBoxUser.Name = "pBoxUser";
            pBoxUser.Size = new Size(40, 40);
            pBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxUser.TabIndex = 3;
            pBoxUser.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.BackColor = Color.Transparent;
            labelUserName.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = Color.FromArgb(235, 235, 235);
            labelUserName.Location = new Point(49, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(103, 46);
            labelUserName.TabIndex = 4;
            labelUserName.Text = "x,\r\nHoşgeldiniz.";
            // 
            // btnKitapTeslim
            // 
            btnKitapTeslim.Image = (Image)resources.GetObject("btnKitapTeslim.Image");
            btnKitapTeslim.Location = new Point(3, 126);
            btnKitapTeslim.Name = "btnKitapTeslim";
            btnKitapTeslim.Size = new Size(194, 35);
            btnKitapTeslim.TabIndex = 2;
            btnKitapTeslim.Text = "Kitabı Teslim Etmek İstiyorum";
            btnKitapTeslim.TextAlign = ContentAlignment.MiddleRight;
            btnKitapTeslim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapTeslim.UseVisualStyleBackColor = true;
            btnKitapTeslim.Click += btnKitapTeslim_Click;
            // 
            // btnKitapRez
            // 
            btnKitapRez.Image = (Image)resources.GetObject("btnKitapRez.Image");
            btnKitapRez.Location = new Point(3, 49);
            btnKitapRez.Name = "btnKitapRez";
            btnKitapRez.Size = new Size(194, 35);
            btnKitapRez.TabIndex = 0;
            btnKitapRez.Text = "Kitap Rezervasyonu Oluştur";
            btnKitapRez.TextAlign = ContentAlignment.MiddleRight;
            btnKitapRez.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapRez.UseVisualStyleBackColor = true;
            btnKitapRez.Click += btnKitapRez_Click;
            // 
            // panelUserAraclar2
            // 
            panelUserAraclar2.BackgroundImage = (Image)resources.GetObject("panelUserAraclar2.BackgroundImage");
            panelUserAraclar2.Controls.Add(lBoxKullaniciYorum);
            panelUserAraclar2.Controls.Add(cBoxKullaniciYorum);
            panelUserAraclar2.Controls.Add(labelYorumYonetimi);
            panelUserAraclar2.Controls.Add(btnYorumYonet);
            panelUserAraclar2.Controls.Add(btnDigerYorum);
            panelUserAraclar2.Location = new Point(400, 0);
            panelUserAraclar2.Name = "panelUserAraclar2";
            panelUserAraclar2.Size = new Size(200, 518);
            panelUserAraclar2.TabIndex = 2;
            // 
            // lBoxKullaniciYorum
            // 
            lBoxKullaniciYorum.FormattingEnabled = true;
            lBoxKullaniciYorum.ItemHeight = 15;
            lBoxKullaniciYorum.Items.AddRange(new object[] { "Kullanıcı Yorumları: " });
            lBoxKullaniciYorum.Location = new Point(3, 160);
            lBoxKullaniciYorum.Name = "lBoxKullaniciYorum";
            lBoxKullaniciYorum.Size = new Size(194, 199);
            lBoxKullaniciYorum.TabIndex = 14;
            // 
            // cBoxKullaniciYorum
            // 
            cBoxKullaniciYorum.FormattingEnabled = true;
            cBoxKullaniciYorum.Location = new Point(3, 90);
            cBoxKullaniciYorum.Name = "cBoxKullaniciYorum";
            cBoxKullaniciYorum.Size = new Size(194, 23);
            cBoxKullaniciYorum.TabIndex = 13;
            cBoxKullaniciYorum.Text = "İncelemek istediğin kitabı seç: ";
            // 
            // labelYorumYonetimi
            // 
            labelYorumYonetimi.AutoSize = true;
            labelYorumYonetimi.BackColor = Color.Transparent;
            labelYorumYonetimi.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYorumYonetimi.ForeColor = Color.FromArgb(235, 235, 235);
            labelYorumYonetimi.ImageAlign = ContentAlignment.MiddleRight;
            labelYorumYonetimi.Location = new Point(117, 3);
            labelYorumYonetimi.Name = "labelYorumYonetimi";
            labelYorumYonetimi.Size = new Size(80, 46);
            labelYorumYonetimi.TabIndex = 10;
            labelYorumYonetimi.Text = "Yorum \r\nYönetimi.";
            labelYorumYonetimi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnYorumYonet
            // 
            btnYorumYonet.Image = (Image)resources.GetObject("btnYorumYonet.Image");
            btnYorumYonet.Location = new Point(3, 49);
            btnYorumYonet.Name = "btnYorumYonet";
            btnYorumYonet.Size = new Size(194, 35);
            btnYorumYonet.TabIndex = 4;
            btnYorumYonet.Text = "Yorumlarını Yönet";
            btnYorumYonet.TextAlign = ContentAlignment.MiddleRight;
            btnYorumYonet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYorumYonet.UseVisualStyleBackColor = true;
            // 
            // btnDigerYorum
            // 
            btnDigerYorum.Image = (Image)resources.GetObject("btnDigerYorum.Image");
            btnDigerYorum.Location = new Point(3, 119);
            btnDigerYorum.Name = "btnDigerYorum";
            btnDigerYorum.Size = new Size(194, 35);
            btnDigerYorum.TabIndex = 1;
            btnDigerYorum.Text = "Diğer Yorumları Görüntüle";
            btnDigerYorum.TextAlign = ContentAlignment.MiddleRight;
            btnDigerYorum.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDigerYorum.UseVisualStyleBackColor = true;
            btnDigerYorum.Click += btnDigerYorum_Click;
            // 
            // btnYorumYap
            // 
            btnYorumYap.Image = (Image)resources.GetObject("btnYorumYap.Image");
            btnYorumYap.Location = new Point(603, 288);
            btnYorumYap.Name = "btnYorumYap";
            btnYorumYap.Size = new Size(194, 40);
            btnYorumYap.TabIndex = 3;
            btnYorumYap.Text = "Yorum Yap";
            btnYorumYap.TextAlign = ContentAlignment.MiddleRight;
            btnYorumYap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYorumYap.UseVisualStyleBackColor = true;
            btnYorumYap.Click += btnYorumYap_Click;
            // 
            // btnCikis
            // 
            btnCikis.Image = (Image)resources.GetObject("btnCikis.Image");
            btnCikis.Location = new Point(606, 464);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(194, 35);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.TextAlign = ContentAlignment.MiddleRight;
            btnCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // rTextBoxKitapRez
            // 
            rTextBoxKitapRez.Location = new Point(203, 49);
            rTextBoxKitapRez.Name = "rTextBoxKitapRez";
            rTextBoxKitapRez.Size = new Size(194, 35);
            rTextBoxKitapRez.TabIndex = 5;
            rTextBoxKitapRez.Text = "Rezerve etmek istediğin kitabın ismi: ";
            rTextBoxKitapRez.TextChanged += rTextBoxKitapRez_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(203, 90);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // cBoxRezKitaplar
            // 
            cBoxRezKitaplar.FormattingEnabled = true;
            cBoxRezKitaplar.Location = new Point(206, 133);
            cBoxRezKitaplar.Name = "cBoxRezKitaplar";
            cBoxRezKitaplar.Size = new Size(188, 23);
            cBoxRezKitaplar.TabIndex = 7;
            cBoxRezKitaplar.Text = "Rezerve kitapların: ";
            cBoxRezKitaplar.SelectedIndexChanged += cBoxRezKitaplar_SelectedIndexChanged;
            // 
            // lBoxRezKitaplar
            // 
            lBoxRezKitaplar.FormattingEnabled = true;
            lBoxRezKitaplar.ItemHeight = 15;
            lBoxRezKitaplar.Items.AddRange(new object[] { "Teslim etmek istediğin kitapların:" });
            lBoxRezKitaplar.Location = new Point(203, 162);
            lBoxRezKitaplar.Name = "lBoxRezKitaplar";
            lBoxRezKitaplar.Size = new Size(194, 139);
            lBoxRezKitaplar.TabIndex = 8;
            // 
            // labelKitapYonetimi
            // 
            labelKitapYonetimi.AutoSize = true;
            labelKitapYonetimi.BackColor = Color.Transparent;
            labelKitapYonetimi.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKitapYonetimi.ForeColor = SystemColors.ControlText;
            labelKitapYonetimi.ImageAlign = ContentAlignment.MiddleRight;
            labelKitapYonetimi.Location = new Point(314, 0);
            labelKitapYonetimi.Name = "labelKitapYonetimi";
            labelKitapYonetimi.Size = new Size(80, 46);
            labelKitapYonetimi.TabIndex = 9;
            labelKitapYonetimi.Text = "Kitap \r\nYönetimi.";
            labelKitapYonetimi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cBoxBitenKitaplar
            // 
            cBoxBitenKitaplar.FormattingEnabled = true;
            cBoxBitenKitaplar.Location = new Point(603, 49);
            cBoxBitenKitaplar.Name = "cBoxBitenKitaplar";
            cBoxBitenKitaplar.Size = new Size(194, 23);
            cBoxBitenKitaplar.TabIndex = 10;
            cBoxBitenKitaplar.Text = "Okuduğun Kitaplar:";
            // 
            // rTextBoxYorum
            // 
            rTextBoxYorum.Location = new Point(603, 107);
            rTextBoxYorum.Name = "rTextBoxYorum";
            rTextBoxYorum.Size = new Size(194, 175);
            rTextBoxYorum.TabIndex = 11;
            rTextBoxYorum.Text = "Yorumun: ";
            rTextBoxYorum.TextChanged += rTextBoxYorum_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "Yorum başlığın: ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelImza
            // 
            labelImza.AutoSize = true;
            labelImza.BackColor = Color.Transparent;
            labelImza.DisabledLinkColor = Color.FromArgb(78, 49, 170);
            labelImza.LinkColor = Color.FromArgb(78, 49, 170);
            labelImza.Location = new Point(616, 446);
            labelImza.Name = "labelImza";
            labelImza.Size = new Size(174, 15);
            labelImza.TabIndex = 13;
            labelImza.TabStop = true;
            labelImza.Text = "Designed by Efe Emirhan Çelebi";
            labelImza.VisitedLinkColor = Color.FromArgb(58, 16, 120);
            labelImza.LinkClicked += labelImza_LinkClicked;
            // 
            // kutuphaneUygulamasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 511);
            Controls.Add(labelImza);
            Controls.Add(textBox1);
            Controls.Add(rTextBoxYorum);
            Controls.Add(cBoxBitenKitaplar);
            Controls.Add(labelKitapYonetimi);
            Controls.Add(btnYorumYap);
            Controls.Add(btnCikis);
            Controls.Add(lBoxRezKitaplar);
            Controls.Add(cBoxRezKitaplar);
            Controls.Add(dateTimePicker1);
            Controls.Add(rTextBoxKitapRez);
            Controls.Add(panelUserAraclar2);
            Controls.Add(panelUserAraclar1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "kutuphaneUygulamasi";
            Text = "Kütüphane";
            panelUserAraclar1.ResumeLayout(false);
            panelUserAraclar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxUser).EndInit();
            panelUserAraclar2.ResumeLayout(false);
            panelUserAraclar2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUserAraclar1;
        private Panel panelUserAraclar2;
        private PictureBox pBoxUser;
        private Label labelUserName;
        private Button btnDigerYorum;
        private Button btnKitapRez;
        private Button btnCikis;
        private Button btnKitapVer;
        private Button btnKitapTeslim;
        private Button btnYorumYap;
        private Button btnYorumYonet;
        private RichTextBox rTextBoxKitapRez;
        private DateTimePicker dateTimePicker1;
        private Label labelRezSure;
        private RadioButton radioRezSureDoldu;
        private RadioButton radioRezSureDolmadi;
        private ComboBox cBoxRezKitaplar;
        private ListBox lBoxRezKitaplar;
        private ComboBox cBoxDini;
        private ComboBox cBoxKisisel;
        private ComboBox cBoxCizgi;
        private ComboBox cBoxDergi;
        private ComboBox cBoxBilim;
        private Label labelKitapYonetimi;
        private Label labelYorumYonetimi;
        private ComboBox cBoxBitenKitaplar;
        private RichTextBox rTextBoxYorum;
        private TextBox textBox1;
        private ListBox lBoxKullaniciYorum;
        private ComboBox cBoxKullaniciYorum;
        private ListBox lBoxKitaplar;
        private LinkLabel labelImza;
    }
}
