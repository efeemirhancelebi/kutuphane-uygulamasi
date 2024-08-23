using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneUygulamasi
{
    public partial class uyeEklemePaneli : Form
    {
        public uyeEklemePaneli()
        {
            InitializeComponent();
        }

        private void btnPanelUyeEkle_Click(object sender, EventArgs e)
        {
            // Veritabanı adresi.

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            // Kullanıcıdan veri alma işlemleri.

            string uyeAd = tBoxPanelUyeAd.Text;
            string uyeSoyad = tBoxPanelUyeSoyad.Text;
            long uyeTc = Convert.ToInt64(tBoxPanelUyeTc.Text);
            string convertedUyeTc = Convert.ToString(uyeTc);
            string uyeMail = tBoxPanelUyeMail.Text;
            string uyeSifre = tBoxPanelUyeSifre.Text;
            if (uyeSifre.Length > 32)
            {
                MessageBox.Show("Şifreniz 32 karakterden daha uzun olamaz. Lütfen yeni bir şifre girin.");
                return;
            }
            else if (uyeSifre.Length < 8)
            {
                MessageBox.Show("Şifreniz 8 karakterden daha az olamaz. Lütfen yeni bir şifre deneyin.");
                return;
            }
            string uyeCins = "";
            if (radioPanelUyeErkek.Checked)
            {
                uyeCins = "Erkek";
            }
            else if (radioPanelUyeKadin.Checked)
            {
                uyeCins = "Kadın";
            }
            else { }
            string uyeAdres = tBoxPanelUyeAdres.Text;
            string uyeOgrBilgi = "";
            if (radioPanelOgr.Checked)
            {
                uyeOgrBilgi = "Öğrenci";
            }
            else if (radioPanelOgrDegil.Checked)
            {
                uyeOgrBilgi = "Değil";
            }
            else { }

            // Kullanıcının boş alan bırakmasını engelleme.

            if (string.IsNullOrEmpty(uyeAd) ||
                string.IsNullOrEmpty(uyeSoyad) ||
                string.IsNullOrEmpty(convertedUyeTc) ||
                string.IsNullOrEmpty(uyeMail) ||
                string.IsNullOrEmpty(uyeSifre) ||
                string.IsNullOrEmpty(uyeCins) ||
                string.IsNullOrEmpty(uyeAdres) ||
                string.IsNullOrEmpty(uyeOgrBilgi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }

            // Kullanıcıdan alınan verileri veritabanında olup olmadığını sorgulama

            using (SqlConnection baglanti2 = new SqlConnection(veritabani))
            {
                baglanti2.Open();

                string sorguMail = "SELECT COUNT(*) FROM uyeBilgileri WHERE uyeMail = @uyeMail";
                using (SqlCommand commandMail = new SqlCommand(sorguMail, baglanti2))
                {
                    commandMail.Parameters.AddWithValue("@uyeMail", uyeMail);

                    int mailSayisi = (int)commandMail.ExecuteScalar();

                    if (mailSayisi > 0)
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
                    }
                    else
                    {
                        MessageBox.Show("Bu e-posta adresi kayıtlı değil.");
                    }
                }

                string sorguTc = "SELECT COUNT(*) FROM uyeBilgileri WHERE uyeTc = @uyeTc";
                using (SqlCommand commandTc = new SqlCommand(sorguTc, baglanti2))
                {
                    commandTc.Parameters.AddWithValue("@uyeTc", uyeTc);

                    int tcSayisi = (int)commandTc.ExecuteScalar();

                    if (tcSayisi > 0)
                    {
                        MessageBox.Show("Bu TC numarası zaten kayıtlı.");
                    }
                    else
                    {
                        MessageBox.Show("Bu TC numarası kayıtlı değil.");
                    }
                }
            }

            // Kullanıcıdan alınan verileri veritabanına işleme.

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand("INSERT INTO uyeBilgileri (uyeAd, uyeSoyad, uyeTc, uyeMail, uyeSifre, uyeCins, uyeAdres, uyeOgrBilgi) VALUES (@uyeAd, @uyeSoyad, @uyeTc, @uyeMail, @uyeSifre, @uyeCins, @uyeAdres, @uyeOgrBilgi)", baglanti);

                command.Parameters.AddWithValue("@uyeAd", uyeAd);
                command.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);
                command.Parameters.AddWithValue("@uyeTc", uyeTc);
                command.Parameters.AddWithValue("@uyeMail", uyeMail);
                command.Parameters.AddWithValue("@uyeSifre", uyeSifre);
                command.Parameters.AddWithValue("@uyeCins", uyeCins);
                command.Parameters.AddWithValue("@uyeAdres", uyeAdres);
                command.Parameters.AddWithValue("@uyeOgrBilgi", uyeOgrBilgi);

                try
                {
                    // Veritabanı bağlantısını açma.

                    baglanti.Open();

                    // Verilerin eklenip eklenmediğini sorgulama.

                    int degerlerEklendi = command.ExecuteNonQuery();

                    if (degerlerEklendi > 0)
                    {
                        MessageBox.Show("Kaydınız başarıyla tamamlandı! Lütfen giriş yapın.");
                    }
                    else
                    {
                        MessageBox.Show("Kaydınız eklenirken bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı. Hata mesajı: " + ex.Message);
                    return;
                }
            }

            // Pencereyi kapatıp yönlendirme işlemi.

            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Close();
        }
    }
}
