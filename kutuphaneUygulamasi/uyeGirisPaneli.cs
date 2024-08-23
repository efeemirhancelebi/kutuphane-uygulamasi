using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kutuphaneUygulamasi
{
    public partial class uyeGirisPaneli : Form
    {
        public static string kullaniciAd;
        public static string kullaniciSoyad;
        public static string kullaniciAdres;
        public static string kullaniciTc;

        public uyeGirisPaneli()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            uyeKayitPaneli uyeKayitPaneli = new uyeKayitPaneli();
            uyeKayitPaneli.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string uyeMail = tBoxMail.Text;
            string uyeSifre = tBoxSifre.Text;
            if (string.IsNullOrEmpty(uyeMail) || string.IsNullOrEmpty(uyeSifre))
            {
                MessageBox.Show("Tüm kısımları doldurunuz.");
                return;
            }

            // Üye sorgusu
            string uyeSorgu = @"SELECT uyeAd, uyeSoyad, uyeAdres, uyeTc FROM uyeBilgileri 
                                WHERE uyeMail = @uyeMail AND uyeSifre = @uyeSifre";

            // Yönetici sorgusu
            string adminSorgu = @"SELECT COUNT(*) FROM yoneticiBilgileri 
                                  WHERE adminMail = @adminMail AND adminSifre = @adminSifre";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand uyeCommand = new SqlCommand(uyeSorgu, baglanti);
                uyeCommand.Parameters.AddWithValue("@uyeMail", uyeMail);
                uyeCommand.Parameters.AddWithValue("@uyeSifre", uyeSifre);

                SqlCommand adminCommand = new SqlCommand(adminSorgu, baglanti);
                adminCommand.Parameters.AddWithValue("@adminMail", uyeMail);
                adminCommand.Parameters.AddWithValue("@adminSifre", uyeSifre);

                baglanti.Open();

                // Üye giriş kontrolü
                SqlDataReader reader = uyeCommand.ExecuteReader();
                if (reader.Read())
                {
                    kullaniciAd = reader["uyeAd"].ToString();
                    kullaniciSoyad = reader["uyeSoyad"].ToString();
                    kullaniciAdres = reader["uyeAdres"].ToString();
                    kullaniciTc = reader["uyeTc"].ToString();

                    MessageBox.Show("Giriş başarılı.");
                    kutuphaneUygulamasi kutuphaneUygulamasi = new kutuphaneUygulamasi();
                    kutuphaneUygulamasi.Show();
                    this.Hide();
                }
                else
                {
                    reader.Close();

                    // Yönetici giriş kontrolü
                    object adminResult = adminCommand.ExecuteScalar();
                    int adminCount = adminResult != null ? Convert.ToInt32(adminResult) : 0;

                    if (adminCount > 0)
                    {
                        MessageBox.Show("Giriş başarılı. Hoşgeldin sayın yönetici.");
                        adminPanel adminPanel = new adminPanel();
                        adminPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız. Lütfen tekrar deneyin.");
                    }
                }
            }
        }
    }
}
