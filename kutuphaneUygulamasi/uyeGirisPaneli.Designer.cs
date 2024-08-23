namespace kutuphaneUygulamasi
{
    partial class uyeGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeGirisPaneli));
            labelMail = new Label();
            labelSifre = new Label();
            tBoxMail = new TextBox();
            tBoxSifre = new TextBox();
            btnGiris = new Button();
            gBoxGiris = new GroupBox();
            btnKayit = new Button();
            labelGirisTitle = new Label();
            gBoxGiris.SuspendLayout();
            SuspendLayout();
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.Transparent;
            labelMail.ForeColor = Color.FromArgb(235, 235, 235);
            labelMail.Location = new Point(6, 26);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(50, 15);
            labelMail.TabIndex = 0;
            labelMail.Text = "E-posta:";
            labelMail.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.BackColor = Color.Transparent;
            labelSifre.ForeColor = Color.FromArgb(235, 235, 235);
            labelSifre.Location = new Point(6, 55);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(33, 15);
            labelSifre.TabIndex = 1;
            labelSifre.Text = "Şifre:";
            labelSifre.TextAlign = ContentAlignment.TopCenter;
            // 
            // tBoxMail
            // 
            tBoxMail.Location = new Point(62, 23);
            tBoxMail.Name = "tBoxMail";
            tBoxMail.Size = new Size(251, 23);
            tBoxMail.TabIndex = 2;
            // 
            // tBoxSifre
            // 
            tBoxSifre.Location = new Point(62, 52);
            tBoxSifre.Name = "tBoxSifre";
            tBoxSifre.Size = new Size(251, 23);
            tBoxSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.ForeColor = SystemColors.ControlText;
            btnGiris.Location = new Point(6, 81);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(307, 35);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // gBoxGiris
            // 
            gBoxGiris.BackColor = Color.Transparent;
            gBoxGiris.Controls.Add(tBoxMail);
            gBoxGiris.Controls.Add(btnGiris);
            gBoxGiris.Controls.Add(labelMail);
            gBoxGiris.Controls.Add(tBoxSifre);
            gBoxGiris.Controls.Add(labelSifre);
            gBoxGiris.ForeColor = Color.FromArgb(235, 235, 235);
            gBoxGiris.Location = new Point(40, 60);
            gBoxGiris.Name = "gBoxGiris";
            gBoxGiris.Size = new Size(320, 130);
            gBoxGiris.TabIndex = 5;
            gBoxGiris.TabStop = false;
            gBoxGiris.Text = "Giriş İşlemleri";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(46, 196);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(307, 35);
            btnKayit.TabIndex = 6;
            btnKayit.Text = "Eğer üyeliğiniz yoksa kayıt olabilirsiniz.";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // labelGirisTitle
            // 
            labelGirisTitle.AutoSize = true;
            labelGirisTitle.BackColor = Color.Transparent;
            labelGirisTitle.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGirisTitle.ForeColor = Color.FromArgb(235, 235, 235);
            labelGirisTitle.Location = new Point(152, 9);
            labelGirisTitle.Name = "labelGirisTitle";
            labelGirisTitle.Size = new Size(95, 23);
            labelGirisTitle.TabIndex = 7;
            labelGirisTitle.Text = "Giriş Ekranı";
            labelGirisTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // uyeGirisPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(384, 261);
            Controls.Add(labelGirisTitle);
            Controls.Add(btnKayit);
            Controls.Add(gBoxGiris);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "uyeGirisPaneli";
            Text = "Üye Girişi";
            gBoxGiris.ResumeLayout(false);
            gBoxGiris.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMail;
        private Label labelSifre;
        private TextBox tBoxMail;
        private TextBox tBoxSifre;
        private Button btnGiris;
        private GroupBox gBoxGiris;
        private Button btnKayit;
        private Label labelGirisTitle;
    }
}