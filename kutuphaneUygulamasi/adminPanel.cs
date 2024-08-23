using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphaneUygulamasi
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
            btnUyeListe.Enabled = false;
            btnDataBaglan.Enabled = false;
            btnDataKes.Enabled = false;
            btnDataSutunEkle.Enabled = false;
            btnDataTabloEkle.Enabled = false;
            btnSutunVeriEkle.Enabled = false;
            tBoxSutun.Enabled = false;
            tBoxSutunVeri.Enabled = false;
            labelDataType.Enabled = false;
        }

        private void btnUyeGor_Click(object sender, EventArgs e)
        {
            uyeBilgileriPaneli uyeBilgileriPaneli = new uyeBilgileriPaneli();
            uyeBilgileriPaneli.Show();
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            uyeEklemePaneli uyeEklemePaneli = new uyeEklemePaneli();
            uyeEklemePaneli.Show();
            this.Close();
        }

        private void btnUyeAski_Click(object sender, EventArgs e)
        {
            uyeAskiyaAlmaPaneli uyeAskiyaAlmaPaneli = new uyeAskiyaAlmaPaneli();
            uyeAskiyaAlmaPaneli.Show();
            this.Close();
        }

        private void btnAdminCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRezKim_Click(object sender, EventArgs e)
        {
            rezerveKitapPaneli rezerveKitapPaneli = new rezerveKitapPaneli();
            rezerveKitapPaneli.Show();
            this.Close();
        }

        private void btnYorumYonet_Click(object sender, EventArgs e)
        {
            yorumYonetimPaneli yorumYonetimPaneli = new yorumYonetimPaneli();
            yorumYonetimPaneli.Show();
            this.Close();
        }

        private void btnRezEkle_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string rezerveKitap = tBoxRezEkle.Text;
            string yazar = tBoxRezEkleYazar.Text;
            if (string.IsNullOrEmpty(rezerveKitap))
            {
                MessageBox.Show("Bu kısım boş bırakılamaz.");
                return;
            }
            else if (string.IsNullOrEmpty(yazar))
            {
                MessageBox.Show("Bu kısım boş bırakılamaz.");
                return;
            }
            else { }

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand("INSERT INTO rezerveKitaplar (rezerveKitap, yazar) VALUES (@rezerveKitap, @yazar)", baglanti);
                command.Parameters.AddWithValue("@rezerveKitap", rezerveKitap);
                command.Parameters.AddWithValue("@yazar", yazar);

                try
                {
                    baglanti.Open();

                    int kitapRezerveEdildi = command.ExecuteNonQuery();

                    if (kitapRezerveEdildi > 0)
                    {
                        MessageBox.Show("Kitap başarıyla rezerve edildi.");
                    }
                    else
                    {
                        MessageBox.Show("Kitap rezerve edilirken bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
                        return;
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

        private void tBoxRezEkle_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText)
            {
                if (!string.IsNullOrEmpty(tBoxRezEkle.Text) && tBoxRezEkle.Text != "Eklemek istediğiniz kitap:")
                {
                    tBoxRezEkle.Text = tBoxRezEkle.Text.Substring(tBoxRezEkle.Text.Length - 1);
                    isDefaultText = false;
                    tBoxRezEkle.SelectionStart = tBoxRezEkle.Text.Length;
                }
            }
        }

        private bool isDefaultText1 = true;

        private void tBoxRezEkleYazar_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText1)
            {
                if (!string.IsNullOrEmpty(tBoxRezEkleYazar.Text) && tBoxRezEkleYazar.Text != "Kitabın yazarı:")
                {
                    tBoxRezEkleYazar.Text = tBoxRezEkleYazar.Text.Substring(tBoxRezEkleYazar.Text.Length - 1);
                    isDefaultText1 = false;
                    tBoxRezEkleYazar.SelectionStart = tBoxRezEkleYazar.Text.Length;
                }
            }
        }

        private void tBoxRezKitapSayi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnKacKitap_Click(object sender, EventArgs e)
        {
            tBoxRezKitapSayi.Clear();
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(veritabani);
            try
            {
                baglanti.Open();
                string sorgu = "SELECT COUNT(*) FROM rezerveKitaplar WHERE rezerveKitap IS NOT NULL";
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                int rezerveKitapSayisi = (int)command.ExecuteScalar();
                tBoxRezKitapSayi.Text = "Rezerve kitap sayısı: " + rezerveKitapSayisi.ToString();
            }
            catch
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
            }
        }

        private void btnRezSil_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string rezervedenKitapCikar = tBoxRezCikar.Text;
            tBoxRezCikar.Clear();

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    string rezerveKitapCikarSorgu = "DELETE FROM rezerveKitaplar WHERE rezerveKitap = @rezerveKitap";
                    using (SqlCommand command = new SqlCommand(rezerveKitapCikarSorgu, baglanti))
                    {
                        command.Parameters.AddWithValue("@rezerveKitap", rezervedenKitapCikar);
                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show("Kitap başarıyla rezerveden çıkarıldı.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Beklenmeyen bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
                            return;
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

        private bool isDefaultText2 = true;

        private void tBoxRezCikar_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText2)
            {
                if (!string.IsNullOrEmpty(tBoxRezCikar.Text) && tBoxRezCikar.Text != "Çıkarmak istediğiniz kitap:")
                {
                    tBoxRezCikar.Text = tBoxRezCikar.Text.Substring(tBoxRezCikar.Text.Length - 1);
                    isDefaultText2 = false;
                    tBoxRezCikar.SelectionStart = tBoxRezCikar.Text.Length;
                }
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string kitapAdi = tBoxKitapEkle.Text;
            string kitapYazari = tBoxKitapEkleYazar.Text;
            tBoxKitapEkle.Clear();
            tBoxKitapEkleYazar.Clear();

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "INSERT INTO kitaplar (kitapAdi, kitapYazari) VALUES (@kitapAdi, @kitapYazari)";
                    using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                    {
                        command.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                        command.Parameters.AddWithValue("@kitapYazari", kitapYazari);
                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show(kitapYazari + "'a ait " + kitapAdi + " eseri başarıyla kütüphaneye eklendi.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Kitap eklenemedi. Lütfen tekrar deneyin.");
                            return;
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

        private bool isDefaultText4 = true;

        private void tBoxKitapEkleYazar_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText4)
            {
                if (!string.IsNullOrEmpty(tBoxKitapEkleYazar.Text) && tBoxKitapEkleYazar.Text != "Yazarı:")
                {
                    tBoxKitapEkleYazar.Text = tBoxKitapEkleYazar.Text.Substring(tBoxKitapEkleYazar.Text.Length - 1);
                    isDefaultText4 = false;
                    tBoxKitapEkleYazar.SelectionStart = tBoxKitapEkleYazar.Text.Length;
                }
            }
        }

        private bool isDefaultText3 = true;

        private void tBoxKitapEkle_TextChanged_1(object sender, EventArgs e)
        {
            if (isDefaultText3)
            {
                if (!string.IsNullOrEmpty(tBoxKitapEkle.Text) && tBoxKitapEkle.Text != "Kitap Adı:")
                {
                    tBoxKitapEkle.Text = tBoxKitapEkle.Text.Substring(tBoxKitapEkle.Text.Length - 1);
                    isDefaultText3 = false;
                    tBoxKitapEkle.SelectionStart = tBoxKitapEkle.Text.Length;
                }
            }
        }

        private bool isDefaultText5 = true;

        private void tBoxKitapSil_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText5)
            {
                if (!string.IsNullOrEmpty(tBoxKitapSil.Text) && tBoxKitapSil.Text != "Silmek istediğiniz kitap:")
                {
                    tBoxKitapSil.Text = tBoxKitapSil.Text.Substring(tBoxKitapSil.Text.Length - 1);
                    isDefaultText5 = false;
                    tBoxKitapSil.SelectionStart = tBoxKitapSil.Text.Length;
                }
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string kitapSil = tBoxKitapSil.Text;
            tBoxKitapSil.Clear();

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    string kitapSilmeAdresi = "DELETE FROM kitaplar WHERE kitapAdi = @kitapAdi";
                    using (SqlCommand command = new SqlCommand(kitapSilmeAdresi, baglanti))
                    {
                        command.Parameters.AddWithValue("@kitapAdi", kitapSil);
                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show("Kitap başarıyla kütüphaneden çıkarıldı.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Beklenmeyen bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
                            return;
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

        private void btnKitapUpdate_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string kitapGuncelleEski = tBoxKitapUpdate.Text;
            string kitapGuncelleYeni = tBoxKitapUpdateYeni.Text;
            tBoxKitapUpdate.Clear();
            tBoxKitapUpdateYeni.Clear();

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                baglanti.Open();

                string guncellemeSorgusu = "UPDATE kitaplar SET kitapAdi = @kitapGuncelleYeni WHERE kitapAdi = @kitapGuncelleEski";

                using (SqlCommand command = new SqlCommand(guncellemeSorgusu, baglanti))
                {
                    command.Parameters.AddWithValue("@kitapGuncelleYeni", kitapGuncelleYeni);
                    command.Parameters.AddWithValue("@kitapGuncelleEski", kitapGuncelleEski);

                    int degerlerEklendi = command.ExecuteNonQuery();

                    if (degerlerEklendi > 0)
                    {
                        MessageBox.Show("Kitap güncelleme başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Kitap güncelleme başarısız!");
                    }
                }
            }
        }


        private bool isDefaultText6 = true;

        private void tBoxKitapUpdate_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText6)
            {
                if (!string.IsNullOrEmpty(tBoxKitapUpdate.Text) && tBoxKitapUpdate.Text != "Güncellemek istediğiniz kitabın adı:")
                {
                    tBoxKitapUpdate.Text = tBoxKitapUpdate.Text.Substring(tBoxKitapUpdate.Text.Length - 1);
                    isDefaultText6 = false;
                    tBoxKitapUpdate.SelectionStart = tBoxKitapUpdate.Text.Length;
                }
            }
        }

        private bool isDefaultText7 = true;

        private void tBoxKitapUpdateYeni_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText7)
            {
                if (!string.IsNullOrEmpty(tBoxKitapUpdateYeni.Text) && tBoxKitapUpdateYeni.Text != "Yazarı:")
                {
                    tBoxKitapUpdateYeni.Text = tBoxKitapUpdateYeni.Text.Substring(tBoxKitapUpdateYeni.Text.Length - 1);
                    isDefaultText7 = false;
                    tBoxKitapUpdateYeni.SelectionStart = tBoxKitapUpdateYeni.Text.Length;
                }
            }
        }

        private bool isDefaultText8 = true;

        private void tBoxUyeSil_TextChanged(object sender, EventArgs e)
        {
            if (isDefaultText8)
            {
                if (!string.IsNullOrEmpty(tBoxUyeSil.Text) && tBoxUyeSil.Text != "Silmek istediğiniz üyenin e-posta adresi:")
                {
                    tBoxUyeSil.Text = tBoxUyeSil.Text.Substring(tBoxUyeSil.Text.Length - 1);
                    isDefaultText8 = false;
                    tBoxUyeSil.SelectionStart = tBoxUyeSil.Text.Length;
                }
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string uyeMailSil = tBoxUyeSil.Text;
            tBoxUyeSil.Clear();

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    string uyeSilmeAdresi = "DELETE FROM uyeBilgileri WHERE uyeMail = @uyeMail";
                    using (SqlCommand command = new SqlCommand(uyeSilmeAdresi, baglanti))
                    {
                        command.Parameters.AddWithValue("@uyeMail", uyeMailSil);
                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show("Üyenin hesabı başarıyla silindi.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Beklenmeyen bir hata ile karşılaşıldı. Lütfen tekrar deneyin.");
                            return;
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
    }
}