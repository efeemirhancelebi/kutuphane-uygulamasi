namespace kutuphaneUygulamasi
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            pBoxAdmin = new PictureBox();
            labelAdminName = new Label();
            panelAraclar1 = new Panel();
            tBoxKitapUpdateYeni = new TextBox();
            tBoxKitapEkleYazar = new TextBox();
            tBoxRezEkleYazar = new TextBox();
            tBoxKitapUpdate = new TextBox();
            tBoxKitapSil = new TextBox();
            tBoxKitapEkle = new TextBox();
            tBoxRezCikar = new TextBox();
            tBoxRezEkle = new TextBox();
            tBoxRezKitapSayi = new TextBox();
            panelAraclar3 = new Panel();
            btnUyeListe = new Button();
            btnAdminCikis = new Button();
            btnUyeAski = new Button();
            tBoxUyeSil = new TextBox();
            panel4 = new Panel();
            btnUyeSil = new Button();
            panel5 = new Panel();
            btnUyeEkle = new Button();
            btnUyeGor = new Button();
            btnKacKitap = new Button();
            btnRezKim = new Button();
            btnRezEkle = new Button();
            btnRezSil = new Button();
            btnKitapEkle = new Button();
            btnKitapSil = new Button();
            btnKitapUpdate = new Button();
            btnYorumYonet = new Button();
            labelKutuphaneYonetimi = new Label();
            labelVeritabaniIslemleri = new Label();
            btnSutunVeriEkle = new Button();
            btnDataSutunEkle = new Button();
            btnDataTabloEkle = new Button();
            btnDataKes = new Button();
            btnDataBaglan = new Button();
            tBoxSutun = new TextBox();
            tBoxSutunVeri = new TextBox();
            labelDataType = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxAdmin).BeginInit();
            panelAraclar1.SuspendLayout();
            panelAraclar3.SuspendLayout();
            SuspendLayout();
            // 
            // pBoxAdmin
            // 
            pBoxAdmin.BackColor = Color.Transparent;
            pBoxAdmin.Image = (Image)resources.GetObject("pBoxAdmin.Image");
            pBoxAdmin.Location = new Point(3, 3);
            pBoxAdmin.Name = "pBoxAdmin";
            pBoxAdmin.Size = new Size(40, 40);
            pBoxAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxAdmin.TabIndex = 1;
            pBoxAdmin.TabStop = false;
            // 
            // labelAdminName
            // 
            labelAdminName.AutoSize = true;
            labelAdminName.BackColor = Color.Transparent;
            labelAdminName.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdminName.ForeColor = Color.FromArgb(235, 235, 235);
            labelAdminName.Location = new Point(49, 0);
            labelAdminName.Name = "labelAdminName";
            labelAdminName.Size = new Size(103, 46);
            labelAdminName.TabIndex = 2;
            labelAdminName.Text = "x,\r\nHoşgeldiniz.";
            // 
            // panelAraclar1
            // 
            panelAraclar1.BackgroundImage = (Image)resources.GetObject("panelAraclar1.BackgroundImage");
            panelAraclar1.Controls.Add(tBoxKitapUpdateYeni);
            panelAraclar1.Controls.Add(tBoxKitapEkleYazar);
            panelAraclar1.Controls.Add(tBoxRezEkleYazar);
            panelAraclar1.Controls.Add(tBoxKitapUpdate);
            panelAraclar1.Controls.Add(tBoxKitapSil);
            panelAraclar1.Controls.Add(tBoxKitapEkle);
            panelAraclar1.Controls.Add(tBoxRezCikar);
            panelAraclar1.Controls.Add(tBoxRezEkle);
            panelAraclar1.Controls.Add(tBoxRezKitapSayi);
            panelAraclar1.Location = new Point(400, 0);
            panelAraclar1.Name = "panelAraclar1";
            panelAraclar1.Size = new Size(200, 519);
            panelAraclar1.TabIndex = 1;
            // 
            // tBoxKitapUpdateYeni
            // 
            tBoxKitapUpdateYeni.Location = new Point(3, 331);
            tBoxKitapUpdateYeni.Name = "tBoxKitapUpdateYeni";
            tBoxKitapUpdateYeni.Size = new Size(194, 23);
            tBoxKitapUpdateYeni.TabIndex = 8;
            tBoxKitapUpdateYeni.Text = "Yeni Adı:";
            tBoxKitapUpdateYeni.TextChanged += tBoxKitapUpdateYeni_TextChanged;
            // 
            // tBoxKitapEkleYazar
            // 
            tBoxKitapEkleYazar.Location = new Point(102, 220);
            tBoxKitapEkleYazar.Name = "tBoxKitapEkleYazar";
            tBoxKitapEkleYazar.Size = new Size(95, 23);
            tBoxKitapEkleYazar.TabIndex = 7;
            tBoxKitapEkleYazar.Text = "Yazarı:";
            tBoxKitapEkleYazar.TextChanged += tBoxKitapEkleYazar_TextChanged;
            // 
            // tBoxRezEkleYazar
            // 
            tBoxRezEkleYazar.Location = new Point(3, 138);
            tBoxRezEkleYazar.Name = "tBoxRezEkleYazar";
            tBoxRezEkleYazar.Size = new Size(194, 23);
            tBoxRezEkleYazar.TabIndex = 6;
            tBoxRezEkleYazar.Text = "Kitabın yazarı:";
            tBoxRezEkleYazar.TextChanged += tBoxRezEkleYazar_TextChanged;
            // 
            // tBoxKitapUpdate
            // 
            tBoxKitapUpdate.Location = new Point(3, 302);
            tBoxKitapUpdate.Name = "tBoxKitapUpdate";
            tBoxKitapUpdate.Size = new Size(194, 23);
            tBoxKitapUpdate.TabIndex = 5;
            tBoxKitapUpdate.Text = "Güncellemek istediğiniz kitabın adı: ";
            tBoxKitapUpdate.TextChanged += tBoxKitapUpdate_TextChanged;
            // 
            // tBoxKitapSil
            // 
            tBoxKitapSil.Location = new Point(3, 261);
            tBoxKitapSil.Name = "tBoxKitapSil";
            tBoxKitapSil.Size = new Size(194, 23);
            tBoxKitapSil.TabIndex = 4;
            tBoxKitapSil.Text = "Silmek istediğiniz kitap: ";
            tBoxKitapSil.TextChanged += tBoxKitapSil_TextChanged;
            // 
            // tBoxKitapEkle
            // 
            tBoxKitapEkle.Location = new Point(3, 220);
            tBoxKitapEkle.Name = "tBoxKitapEkle";
            tBoxKitapEkle.Size = new Size(95, 23);
            tBoxKitapEkle.TabIndex = 3;
            tBoxKitapEkle.Text = "Kitap Adı:";
            tBoxKitapEkle.TextChanged += tBoxKitapEkle_TextChanged_1;
            // 
            // tBoxRezCikar
            // 
            tBoxRezCikar.Location = new Point(3, 179);
            tBoxRezCikar.Name = "tBoxRezCikar";
            tBoxRezCikar.Size = new Size(194, 23);
            tBoxRezCikar.TabIndex = 2;
            tBoxRezCikar.Text = "Çıkarmak istediğiniz kitap: ";
            tBoxRezCikar.TextChanged += tBoxRezCikar_TextChanged;
            // 
            // tBoxRezEkle
            // 
            tBoxRezEkle.Location = new Point(3, 109);
            tBoxRezEkle.Name = "tBoxRezEkle";
            tBoxRezEkle.Size = new Size(194, 23);
            tBoxRezEkle.TabIndex = 1;
            tBoxRezEkle.Text = "Eklemek istediğiniz kitap: ";
            tBoxRezEkle.TextChanged += tBoxRezEkle_TextChanged;
            // 
            // tBoxRezKitapSayi
            // 
            tBoxRezKitapSayi.Location = new Point(3, 56);
            tBoxRezKitapSayi.Name = "tBoxRezKitapSayi";
            tBoxRezKitapSayi.Size = new Size(194, 23);
            tBoxRezKitapSayi.TabIndex = 0;
            tBoxRezKitapSayi.Text = "Rezerve kitap sayısı: ";
            tBoxRezKitapSayi.TextChanged += tBoxRezKitapSayi_TextChanged_1;
            // 
            // panelAraclar3
            // 
            panelAraclar3.BackgroundImage = (Image)resources.GetObject("panelAraclar3.BackgroundImage");
            panelAraclar3.Controls.Add(btnUyeListe);
            panelAraclar3.Controls.Add(btnAdminCikis);
            panelAraclar3.Controls.Add(btnUyeAski);
            panelAraclar3.Controls.Add(tBoxUyeSil);
            panelAraclar3.Controls.Add(panel4);
            panelAraclar3.Controls.Add(btnUyeSil);
            panelAraclar3.Controls.Add(panel5);
            panelAraclar3.Controls.Add(btnUyeEkle);
            panelAraclar3.Controls.Add(pBoxAdmin);
            panelAraclar3.Controls.Add(btnUyeGor);
            panelAraclar3.Controls.Add(labelAdminName);
            panelAraclar3.Location = new Point(0, 0);
            panelAraclar3.Name = "panelAraclar3";
            panelAraclar3.Size = new Size(200, 519);
            panelAraclar3.TabIndex = 4;
            // 
            // btnUyeListe
            // 
            btnUyeListe.Image = (Image)resources.GetObject("btnUyeListe.Image");
            btnUyeListe.Location = new Point(3, 242);
            btnUyeListe.Name = "btnUyeListe";
            btnUyeListe.Size = new Size(194, 35);
            btnUyeListe.TabIndex = 0;
            btnUyeListe.Text = "Son 100 Üyeyi Görüntüle";
            btnUyeListe.TextAlign = ContentAlignment.MiddleRight;
            btnUyeListe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUyeListe.UseVisualStyleBackColor = true;
            // 
            // btnAdminCikis
            // 
            btnAdminCikis.Image = (Image)resources.GetObject("btnAdminCikis.Image");
            btnAdminCikis.Location = new Point(3, 472);
            btnAdminCikis.Name = "btnAdminCikis";
            btnAdminCikis.Size = new Size(194, 35);
            btnAdminCikis.TabIndex = 5;
            btnAdminCikis.Text = "Çıkış Yap";
            btnAdminCikis.TextAlign = ContentAlignment.MiddleRight;
            btnAdminCikis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdminCikis.UseVisualStyleBackColor = true;
            btnAdminCikis.Click += btnAdminCikis_Click;
            // 
            // btnUyeAski
            // 
            btnUyeAski.Image = (Image)resources.GetObject("btnUyeAski.Image");
            btnUyeAski.Location = new Point(3, 201);
            btnUyeAski.Name = "btnUyeAski";
            btnUyeAski.Size = new Size(194, 35);
            btnUyeAski.TabIndex = 5;
            btnUyeAski.Text = "Üyenin Hesabını Askıya Al";
            btnUyeAski.TextAlign = ContentAlignment.MiddleRight;
            btnUyeAski.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUyeAski.UseVisualStyleBackColor = true;
            btnUyeAski.Click += btnUyeAski_Click;
            // 
            // tBoxUyeSil
            // 
            tBoxUyeSil.Location = new Point(3, 131);
            tBoxUyeSil.Name = "tBoxUyeSil";
            tBoxUyeSil.Size = new Size(194, 23);
            tBoxUyeSil.TabIndex = 3;
            tBoxUyeSil.Text = "Silmek istediğiniz üyenin e-posta adresi: ";
            tBoxUyeSil.TextChanged += tBoxUyeSil_TextChanged;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(400, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 690);
            panel4.TabIndex = 3;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Image = (Image)resources.GetObject("btnUyeSil.Image");
            btnUyeSil.Location = new Point(3, 160);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(194, 35);
            btnUyeSil.TabIndex = 2;
            btnUyeSil.Text = "Üye Sil";
            btnUyeSil.TextAlign = ContentAlignment.MiddleRight;
            btnUyeSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUyeSil.UseVisualStyleBackColor = true;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(400, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(100, 690);
            panel5.TabIndex = 0;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Image = (Image)resources.GetObject("btnUyeEkle.Image");
            btnUyeEkle.Location = new Point(3, 90);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(194, 35);
            btnUyeEkle.TabIndex = 1;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.TextAlign = ContentAlignment.MiddleRight;
            btnUyeEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeGor
            // 
            btnUyeGor.Image = (Image)resources.GetObject("btnUyeGor.Image");
            btnUyeGor.Location = new Point(3, 49);
            btnUyeGor.Name = "btnUyeGor";
            btnUyeGor.Size = new Size(194, 35);
            btnUyeGor.TabIndex = 0;
            btnUyeGor.Text = "Üye Bilgilerini Görüntüle";
            btnUyeGor.TextAlign = ContentAlignment.MiddleRight;
            btnUyeGor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUyeGor.UseVisualStyleBackColor = true;
            btnUyeGor.Click += btnUyeGor_Click;
            // 
            // btnKacKitap
            // 
            btnKacKitap.Image = (Image)resources.GetObject("btnKacKitap.Image");
            btnKacKitap.Location = new Point(203, 49);
            btnKacKitap.Name = "btnKacKitap";
            btnKacKitap.Size = new Size(194, 35);
            btnKacKitap.TabIndex = 5;
            btnKacKitap.Text = "Rezerve Kitap Sayısı";
            btnKacKitap.TextAlign = ContentAlignment.MiddleRight;
            btnKacKitap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKacKitap.UseVisualStyleBackColor = true;
            btnKacKitap.Click += btnKacKitap_Click;
            // 
            // btnRezKim
            // 
            btnRezKim.Image = (Image)resources.GetObject("btnRezKim.Image");
            btnRezKim.Location = new Point(203, 90);
            btnRezKim.Name = "btnRezKim";
            btnRezKim.Size = new Size(194, 35);
            btnRezKim.TabIndex = 5;
            btnRezKim.Text = "Rezerve Kitaplar Kimlerde?";
            btnRezKim.TextAlign = ContentAlignment.MiddleRight;
            btnRezKim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRezKim.UseVisualStyleBackColor = true;
            btnRezKim.Click += btnRezKim_Click;
            // 
            // btnRezEkle
            // 
            btnRezEkle.Image = (Image)resources.GetObject("btnRezEkle.Image");
            btnRezEkle.Location = new Point(203, 131);
            btnRezEkle.Name = "btnRezEkle";
            btnRezEkle.Size = new Size(194, 35);
            btnRezEkle.TabIndex = 5;
            btnRezEkle.Text = "Rezerve Kitap Ekle";
            btnRezEkle.TextAlign = ContentAlignment.MiddleRight;
            btnRezEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRezEkle.UseVisualStyleBackColor = true;
            btnRezEkle.Click += btnRezEkle_Click;
            // 
            // btnRezSil
            // 
            btnRezSil.Image = (Image)resources.GetObject("btnRezSil.Image");
            btnRezSil.Location = new Point(203, 172);
            btnRezSil.Name = "btnRezSil";
            btnRezSil.Size = new Size(194, 35);
            btnRezSil.TabIndex = 5;
            btnRezSil.Text = "Kitabı Rezerveden Çıkar";
            btnRezSil.TextAlign = ContentAlignment.MiddleRight;
            btnRezSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRezSil.UseVisualStyleBackColor = true;
            btnRezSil.Click += btnRezSil_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Image = (Image)resources.GetObject("btnKitapEkle.Image");
            btnKitapEkle.Location = new Point(203, 213);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(194, 35);
            btnKitapEkle.TabIndex = 5;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.TextAlign = ContentAlignment.MiddleRight;
            btnKitapEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // btnKitapSil
            // 
            btnKitapSil.Image = (Image)resources.GetObject("btnKitapSil.Image");
            btnKitapSil.Location = new Point(203, 254);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(194, 35);
            btnKitapSil.TabIndex = 6;
            btnKitapSil.Text = "Kitap Sil";
            btnKitapSil.TextAlign = ContentAlignment.MiddleRight;
            btnKitapSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapSil.UseVisualStyleBackColor = true;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // btnKitapUpdate
            // 
            btnKitapUpdate.Image = (Image)resources.GetObject("btnKitapUpdate.Image");
            btnKitapUpdate.Location = new Point(203, 295);
            btnKitapUpdate.Name = "btnKitapUpdate";
            btnKitapUpdate.Size = new Size(194, 35);
            btnKitapUpdate.TabIndex = 7;
            btnKitapUpdate.Text = "Kitap İsmi Güncelle";
            btnKitapUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnKitapUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKitapUpdate.UseVisualStyleBackColor = true;
            btnKitapUpdate.Click += btnKitapUpdate_Click;
            // 
            // btnYorumYonet
            // 
            btnYorumYonet.Image = (Image)resources.GetObject("btnYorumYonet.Image");
            btnYorumYonet.Location = new Point(203, 336);
            btnYorumYonet.Name = "btnYorumYonet";
            btnYorumYonet.Size = new Size(194, 35);
            btnYorumYonet.TabIndex = 8;
            btnYorumYonet.Text = "Kitap Yorumlarını Yönet";
            btnYorumYonet.TextAlign = ContentAlignment.MiddleRight;
            btnYorumYonet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnYorumYonet.UseVisualStyleBackColor = true;
            btnYorumYonet.Click += btnYorumYonet_Click;
            // 
            // labelKutuphaneYonetimi
            // 
            labelKutuphaneYonetimi.AutoSize = true;
            labelKutuphaneYonetimi.BackColor = Color.Transparent;
            labelKutuphaneYonetimi.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKutuphaneYonetimi.ForeColor = SystemColors.ControlText;
            labelKutuphaneYonetimi.ImageAlign = ContentAlignment.MiddleRight;
            labelKutuphaneYonetimi.Location = new Point(303, 0);
            labelKutuphaneYonetimi.Name = "labelKutuphaneYonetimi";
            labelKutuphaneYonetimi.Size = new Size(94, 46);
            labelKutuphaneYonetimi.TabIndex = 6;
            labelKutuphaneYonetimi.Text = "Kütüphane\r\nYönetimi.";
            labelKutuphaneYonetimi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelVeritabaniIslemleri
            // 
            labelVeritabaniIslemleri.AutoSize = true;
            labelVeritabaniIslemleri.BackColor = Color.Transparent;
            labelVeritabaniIslemleri.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVeritabaniIslemleri.ForeColor = SystemColors.ControlText;
            labelVeritabaniIslemleri.ImageAlign = ContentAlignment.MiddleRight;
            labelVeritabaniIslemleri.Location = new Point(622, 15);
            labelVeritabaniIslemleri.Name = "labelVeritabaniIslemleri";
            labelVeritabaniIslemleri.Size = new Size(155, 23);
            labelVeritabaniIslemleri.TabIndex = 9;
            labelVeritabaniIslemleri.Text = "Veritabanı İşlemleri";
            labelVeritabaniIslemleri.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSutunVeriEkle
            // 
            btnSutunVeriEkle.Image = (Image)resources.GetObject("btnSutunVeriEkle.Image");
            btnSutunVeriEkle.Location = new Point(603, 348);
            btnSutunVeriEkle.Name = "btnSutunVeriEkle";
            btnSutunVeriEkle.Size = new Size(194, 40);
            btnSutunVeriEkle.TabIndex = 6;
            btnSutunVeriEkle.Text = "Veritabanında Herhangi\r\nBir Sütuna Değer Ekle";
            btnSutunVeriEkle.TextAlign = ContentAlignment.MiddleRight;
            btnSutunVeriEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSutunVeriEkle.UseVisualStyleBackColor = true;
            // 
            // btnDataSutunEkle
            // 
            btnDataSutunEkle.Image = (Image)resources.GetObject("btnDataSutunEkle.Image");
            btnDataSutunEkle.Location = new Point(603, 172);
            btnDataSutunEkle.Name = "btnDataSutunEkle";
            btnDataSutunEkle.Size = new Size(194, 35);
            btnDataSutunEkle.TabIndex = 11;
            btnDataSutunEkle.Text = "Veritabanına Sütun Ekle";
            btnDataSutunEkle.TextAlign = ContentAlignment.MiddleRight;
            btnDataSutunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDataSutunEkle.UseVisualStyleBackColor = true;
            // 
            // btnDataTabloEkle
            // 
            btnDataTabloEkle.Image = (Image)resources.GetObject("btnDataTabloEkle.Image");
            btnDataTabloEkle.Location = new Point(603, 131);
            btnDataTabloEkle.Name = "btnDataTabloEkle";
            btnDataTabloEkle.Size = new Size(194, 35);
            btnDataTabloEkle.TabIndex = 9;
            btnDataTabloEkle.Text = "Veritabanına Tablo Ekle";
            btnDataTabloEkle.TextAlign = ContentAlignment.MiddleRight;
            btnDataTabloEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDataTabloEkle.UseVisualStyleBackColor = true;
            // 
            // btnDataKes
            // 
            btnDataKes.Image = (Image)resources.GetObject("btnDataKes.Image");
            btnDataKes.Location = new Point(603, 90);
            btnDataKes.Name = "btnDataKes";
            btnDataKes.Size = new Size(194, 35);
            btnDataKes.TabIndex = 8;
            btnDataKes.Text = "Veritabanı Bağlantısını Kes";
            btnDataKes.TextAlign = ContentAlignment.MiddleRight;
            btnDataKes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDataKes.UseVisualStyleBackColor = true;
            // 
            // btnDataBaglan
            // 
            btnDataBaglan.Image = (Image)resources.GetObject("btnDataBaglan.Image");
            btnDataBaglan.Location = new Point(603, 49);
            btnDataBaglan.Name = "btnDataBaglan";
            btnDataBaglan.Size = new Size(194, 35);
            btnDataBaglan.TabIndex = 7;
            btnDataBaglan.Text = "Veritabanına Bağlan";
            btnDataBaglan.TextAlign = ContentAlignment.MiddleRight;
            btnDataBaglan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDataBaglan.UseVisualStyleBackColor = true;
            // 
            // tBoxSutun
            // 
            tBoxSutun.Location = new Point(603, 259);
            tBoxSutun.Name = "tBoxSutun";
            tBoxSutun.Size = new Size(194, 23);
            tBoxSutun.TabIndex = 4;
            tBoxSutun.Text = "Eklemek istediğiniz sütun: ";
            // 
            // tBoxSutunVeri
            // 
            tBoxSutunVeri.Location = new Point(603, 288);
            tBoxSutunVeri.Name = "tBoxSutunVeri";
            tBoxSutunVeri.Size = new Size(194, 23);
            tBoxSutunVeri.TabIndex = 12;
            tBoxSutunVeri.Text = "Sütuna eklemek istediğiniz veri: ";
            // 
            // labelDataType
            // 
            labelDataType.AutoSize = true;
            labelDataType.BackColor = Color.Transparent;
            labelDataType.Location = new Point(603, 315);
            labelDataType.Name = "labelDataType";
            labelDataType.Size = new Size(129, 30);
            labelDataType.TabIndex = 13;
            labelDataType.Text = "Bağlandığınız Sütunun \r\nVeri Tipi: ";
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(804, 511);
            Controls.Add(labelDataType);
            Controls.Add(tBoxSutunVeri);
            Controls.Add(tBoxSutun);
            Controls.Add(btnSutunVeriEkle);
            Controls.Add(labelVeritabaniIslemleri);
            Controls.Add(btnDataSutunEkle);
            Controls.Add(labelKutuphaneYonetimi);
            Controls.Add(btnYorumYonet);
            Controls.Add(btnDataTabloEkle);
            Controls.Add(btnKitapUpdate);
            Controls.Add(btnDataKes);
            Controls.Add(btnKitapSil);
            Controls.Add(btnDataBaglan);
            Controls.Add(btnKitapEkle);
            Controls.Add(panelAraclar3);
            Controls.Add(btnRezSil);
            Controls.Add(btnRezEkle);
            Controls.Add(panelAraclar1);
            Controls.Add(btnRezKim);
            Controls.Add(btnKacKitap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "adminPanel";
            Text = "Yönetici Sistemi";
            ((System.ComponentModel.ISupportInitialize)pBoxAdmin).EndInit();
            panelAraclar1.ResumeLayout(false);
            panelAraclar1.PerformLayout();
            panelAraclar3.ResumeLayout(false);
            panelAraclar3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pBoxAdmin;
        private Label labelAdminName;
        private Panel panelAraclar1;
        private Panel panelAraclar3;
        private Panel panel4;
        private Panel panel5;
        private Button btnUyeSil;
        private Button btnUyeEkle;
        private Button btnUyeGor;
        private TextBox tBoxUyeSil;
        private Button btnKacKitap;
        private Button btnRezKim;
        private Button btnAdminCikis;
        private Button btnUyeAski;
        private Button btnRezSil;
        private Button btnRezEkle;
        private Button btnKitapEkle;
        private Button btnKitapSil;
        private Button btnKitapUpdate;
        private Button btnUyeListe;
        private Button btnYorumYonet;
        private TextBox tBoxKitapUpdate;
        private TextBox tBoxKitapSil;
        private TextBox tBoxKitapEkle;
        private TextBox tBoxRezCikar;
        private TextBox tBoxRezEkle;
        private TextBox tBoxRezKitapSayi;
        private Label labelKutuphaneYonetimi;
        private Label labelVeritabaniIslemleri;
        private Button btnSutunVeriEkle;
        private Button btnDataSutunEkle;
        private Button btnDataTabloEkle;
        private Button btnDataKes;
        private Button btnDataBaglan;
        private TextBox tBoxSutun;
        private TextBox tBoxSutunVeri;
        private Label labelDataType;
        private TextBox tBoxRezEkleYazar;
        private TextBox tBoxKitapEkleYazar;
        private TextBox tBoxKitapUpdateYeni;
    }
}