using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Input;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.Design;

namespace kutuphaneUygulamasi
{
    public partial class kutuphaneUygulamasi : Form
    {
        public kutuphaneUygulamasi()
        {
            InitializeComponent();
            labelUserName.Text = uyeGirisPaneli.kullaniciAd + " " + uyeGirisPaneli.kullaniciSoyad + "," + "\n" + "Hoşgeldiniz.";
            KitaplariYukle();
            tumKitaplariYukle();
            yorumKitapYukle();
            btnYorumYonet.Enabled = false;
            btnKitapVer.Enabled = false;
        }

        private void KitaplariYukle()
        {
            cBoxRezKitaplar.Items.Clear();
            string uyeAd = uyeGirisPaneli.kullaniciAd;
            string uyeSoyad = uyeGirisPaneli.kullaniciSoyad;

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT rezerveKitap FROM rezerveKitaplar WHERE uyeAd = @uyeAd AND uyeSoyad = @uyeSoyad AND teslimEdildigiTarih IS NULL";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@uyeAd", uyeAd);
                command.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string rezerveKitap = reader["rezerveKitap"].ToString();
                        if (!string.IsNullOrWhiteSpace(rezerveKitap))
                        {
                            cBoxRezKitaplar.Items.Add(rezerveKitap);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void rezerveKitapListesiYukle()
        {

            if (cBoxRezKitaplar.SelectedItem != null)
            {
                string secilenKitap = cBoxRezKitaplar.SelectedItem.ToString();

                bool zatenVar = false;

                foreach (var item in lBoxRezKitaplar.Items)
                {
                    if (item.ToString() == secilenKitap)
                    {
                        zatenVar = true;
                        break;
                    }
                }

                if (zatenVar)
                {
                    MessageBox.Show($"'{secilenKitap}' kitabı zaten listede mevcut!");
                }
                else
                {
                    lBoxRezKitaplar.Items.Remove("Teslim etmek istediğin kitapların:");
                    lBoxRezKitaplar.Items.Add(secilenKitap);
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir kitap seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isDefaultText2 = true;

        private void rTextBoxYorum_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText2)
            {
                if (!string.IsNullOrEmpty(rTextBoxYorum.Text) && rTextBoxYorum.Text != "Yorumun:")
                {
                    rTextBoxYorum.Text = rTextBoxYorum.Text.Substring(rTextBoxYorum.Text.Length - 1);
                    isDefaultText2 = false;
                    rTextBoxYorum.SelectionStart = rTextBoxYorum.Text.Length;
                }
            }
        }

        private void btnKitapRez_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string kitapAdi = rTextBoxKitapRez.Text;
            if (string.IsNullOrWhiteSpace(kitapAdi))
            {
                MessageBox.Show("Kitap adı kısmı boş bırakılamaz.");
                return;
            }
            DateTime kitabinTeslimEdilecegiTarih = (DateTime)dateTimePicker1.Value;
            if (kitabinTeslimEdilecegiTarih == DateTime.Now.Date)
            {
                MessageBox.Show("Minimum 1 günlük rezerve oluşturabilirsiniz. Bu sebeple takvimden ertesi günü seçmelisiniz. Lütfen tekrar deneyin.");
                return;
            }
            string kitapYazari;
            DateTime alindigiTarih = DateTime.Now.Date;
            string uyeAd = uyeGirisPaneli.kullaniciAd;
            string uyeSoyad = uyeGirisPaneli.kullaniciSoyad;
            string uyeAdres = uyeGirisPaneli.kullaniciAdres;
            string uyeTc = uyeGirisPaneli.kullaniciTc;

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command2 = new SqlCommand("SELECT kitapAdi, kitapYazari FROM kitaplar WHERE kitapAdi = @kitapAdi", baglanti);
                command2.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                try
                {
                    // Veritabanı bağlantısını açma.

                    baglanti.Open();

                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kitapAdi = reader["kitapAdi"].ToString();
                            kitapYazari = reader["kitapYazari"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Belirttiğiniz kitap kütüphanede bulunmuyor, bundan dolayı rezerve edilemedi. Lütfen tekrar deneyin.");
                            return;
                        }
                    }

                    SqlCommand command3 = new SqlCommand("SELECT rezerveKitap FROM rezerveKitaplar WHERE rezerveKitap = @rezerveKitap", baglanti);
                    command3.Parameters.AddWithValue("@rezerveKitap", kitapAdi);
                    using (SqlDataReader reader = command3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kitapAdi = reader["rezerveKitap"].ToString();
                            MessageBox.Show("Kitap zaten rezerve edilmiş. Lütfen başka bir kitabı almayı dene.");
                            return;
                        }
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO rezerveKitaplar (uyeAd, uyeSoyad, uyeAdres, teslimEdilecegiTarih, rezerveKitap, yazar, alindigiTarih) VALUES (@uyeAd, @uyeSoyad, @uyeAdres, @teslimEdilecegiTarih, @rezerveKitap, @yazar, @alindigiTarih)", baglanti);
                    command.Parameters.AddWithValue("@uyeAd", uyeAd);
                    command.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);
                    command.Parameters.AddWithValue("@uyeAdres", uyeAdres);
                    command.Parameters.AddWithValue("@teslimEdilecegiTarih", kitabinTeslimEdilecegiTarih);
                    command.Parameters.AddWithValue("@rezerveKitap", kitapAdi);
                    command.Parameters.AddWithValue("@yazar", kitapYazari);
                    command.Parameters.AddWithValue("@alindigiTarih", alindigiTarih);

                    int degerlerEklendi = command.ExecuteNonQuery();

                    if (degerlerEklendi > 0)
                    {
                        MessageBox.Show("Kitap başarıyla rezerve edildi!");
                        KitaplariYukle();
                    }
                    else
                    {
                        MessageBox.Show("Kitap rezerve edilirken bir hata meydana geldi. Lütfen tekrar deneyin.");
                        return;
                    }

                    string sorgu4 = "UPDATE uyeBilgileri SET uyeAldigiKitaplar = uyeAldigiKitaplar + 1 WHERE uyeTc = @uyeTc";
                    using (SqlCommand command4 = new SqlCommand(sorgu4, baglanti))
                    {
                        command4.Parameters.AddWithValue("@uyeTc", uyeTc);

                        int degerlerEklendi2 = command4.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı. Hata mesajı: " + ex.Message);
                    return;
                }
            }
        }

        private bool isDefaultText = true;

        private void rTextBoxKitapRez_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText)
            {
                if (!string.IsNullOrEmpty(rTextBoxKitapRez.Text) && rTextBoxKitapRez.Text != "Rezerve etmek istediğiniz kitabın ismi:")
                {
                    rTextBoxKitapRez.Text = rTextBoxKitapRez.Text.Substring(rTextBoxKitapRez.Text.Length - 1);
                    isDefaultText = false;
                    rTextBoxKitapRez.SelectionStart = rTextBoxKitapRez.Text.Length;
                }
            }
        }

        private void btnKitapTeslim_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string kitapSuresi;
            if (radioRezSureDoldu.Checked)
            {
                kitapSuresi = "Rezervasyon süresi doldu.";
            }
            else
            {
                kitapSuresi = "Rezervasyon süresi dolmadı.";
            }

            if (!radioRezSureDoldu.Checked && !radioRezSureDolmadi.Checked)
            {
                MessageBox.Show("Kitap sürenizin dolduğunu veya dolmadığı seçenekleri boş bırakılamaz. Lütfen birini seçin");
                return;
            }
            DateTime kitabinTeslimEdildigiTarih = DateTime.Now.Date;
            string uyeTc = uyeGirisPaneli.kullaniciTc;

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    foreach (var item in lBoxRezKitaplar.Items)
                    {
                        string secilenRezerveKitap = item.ToString();
                        string sorgu = "UPDATE rezerveKitaplar SET teslimEdildigiTarih = @teslimEdildigiTarih WHERE rezerveKitap = @rezerveKitap";
                        using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                        {
                            command.Parameters.AddWithValue("@teslimEdildigiTarih", kitabinTeslimEdildigiTarih);
                            command.Parameters.AddWithValue("@rezerveKitap", secilenRezerveKitap);
                            int degerlerEklendi = command.ExecuteNonQuery();

                            if (degerlerEklendi > 0)
                            {
                                try
                                {
                                    string sorgu2 = "UPDATE uyeBilgileri SET uyeTamamladigiKitaplar = uyeTamamladigiKitaplar + 1 WHERE uyeTc = @uyeTc";
                                    {
                                        command.Parameters.AddWithValue("@uyeTc", uyeTc);
                                    }
                                    using (SqlCommand command2 = new SqlCommand(sorgu2, baglanti))
                                    {
                                        command2.Parameters.AddWithValue("@uyeTc", uyeTc);
                                        int degerlerEklendi2 = command2.ExecuteNonQuery();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                                }
                                MessageBox.Show($"{secilenRezerveKitap} başarıyla kütüphaneye teslim edildi.");
                                KitaplariYukle();
                            }
                            else
                            {
                                MessageBox.Show($"{secilenRezerveKitap} elinizde bulunamadı, bu sebeple teslim edilemedi.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                    return;
                }
            }
        }

        private void cBoxRezKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            rezerveKitapListesiYukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yorumKitapYukle()
        {
            cBoxBitenKitaplar.Items.Clear();
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT rezerveKitap FROM rezerveKitaplar WHERE teslimEdildigiTarih IS NOT NULL";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cBoxBitenKitaplar.Items.Add(reader["rezerveKitap"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void tumKitaplariYukle()
        {
            lBoxKitaplar.Items.Clear();
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT kitapAdi FROM kitaplar";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lBoxKitaplar.Items.Add(reader["kitapAdi"].ToString());
                        cBoxKullaniciYorum.Items.Add(reader["kitapAdi"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }

            string sorgu2 = "SELECT rezerveKitap FROM rezerveKitaplar";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu2, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lBoxKitaplar.Items.Remove(reader["rezerveKitap"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string yorumBasligi = textBox1.Text;
            string yorum = rTextBoxYorum.Text;
            string kitapAdi = cBoxBitenKitaplar.SelectedItem.ToString();
            string uyeAd = uyeGirisPaneli.kullaniciAd;
            string uyeSoyad = uyeGirisPaneli.kullaniciSoyad;

            string sorgu = "INSERT INTO uyeYorumlari (uyeAd, uyeSoyad, uyeYorum, uyeYorumBasligi, yorumYaptigiKitap) VALUES (@uyeAd, @uyeSoyad, @uyeYorum, @uyeYorumBasligi, @yorumYaptigiKitap)";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                    {
                        command.Parameters.AddWithValue("@uyeAd", uyeAd);
                        command.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);
                        command.Parameters.AddWithValue("@uyeYorum", yorum);
                        command.Parameters.AddWithValue("@uyeYorumBasligi", yorumBasligi);
                        command.Parameters.AddWithValue("@yorumYaptigiKitap", kitapAdi);

                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show("Başarıyla yorum yapıldı!");
                        }
                        else
                        {
                            MessageBox.Show("Yorum yapılırken bir hata meydana geldi. Lütfen tekrar deneyin.");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı. Hata mesajı: " + ex.Message);
                    return;
                }
            }
        }

        private bool isDefaultText3 = true;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText3)
            {
                if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "Yorum başlığın:")
                {
                    textBox1.Text = textBox1.Text.Substring(textBox1.Text.Length - 1);
                    isDefaultText3 = false;
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
        }

        private void btnDigerYorum_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT uyeYorum, uyeYorumBasligi FROM uyeYorumlari";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string yorumBasligi = reader["uyeYorumBasligi"].ToString();
                        string yorum = reader["uyeYorum"].ToString();
                        string listedeYorum = yorumBasligi + ": " + yorum;

                        lBoxKullaniciYorum.Items.Add(listedeYorum);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void labelImza_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/efeemirhancelebi",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
