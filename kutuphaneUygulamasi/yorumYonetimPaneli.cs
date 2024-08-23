using System;
using System.Collections;
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
    public partial class yorumYonetimPaneli : Form
    {
        public yorumYonetimPaneli()
        {
            InitializeComponent();
            YorumlariYukle();
            KitaplariYukle();
        }
        private void YorumlariYukle()
        {
            cBoxSonYorumlar.Items.Clear();

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT uyeYorumBasligi FROM uyeYorumlari";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cBoxSonYorumlar.Items.Add(reader["uyeYorumBasligi"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btnYorumGoster_Click(object sender, EventArgs e)
        {
            if (cBoxSonYorumlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir yorum seçin.");
                return;
            }

            string secilenDeger = cBoxSonYorumlar.SelectedItem.ToString();
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT uyeYorum FROM uyeYorumlari WHERE uyeYorumBasligi = @uyeYorumBasligi";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@uyeYorumBasligi", secilenDeger);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tBoxYorumBasligi1.Text = secilenDeger;
                        rTextBoxYorumGoster.Text = reader["uyeYorum"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btnYorumSil_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string yorumSil = rTextBoxYorumGoster.Text;
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                try
                {
                    baglanti.Open();
                    string yorumSilmeAdresi = "DELETE FROM uyeYorumlari WHERE uyeYorum = @uyeYorum";
                    using (SqlCommand command = new SqlCommand(yorumSilmeAdresi, baglanti))
                    {
                        command.Parameters.AddWithValue("@uyeYorum", yorumSil);
                        int degerlerEklendi = command.ExecuteNonQuery();
                        if (degerlerEklendi > 0)
                        {
                            MessageBox.Show("Yorum başarıyla silindi.");
                            YorumlariYukle();
                            cBoxSonYorumlar.Text = "";
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

        private void btnYorumEdit_Click(object sender, EventArgs e)
        {
            if (cBoxSonYorumlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir yorum başlığı seçin.");
                return;
            }

            string uyeYorum = rTextBoxYorumGoster.Text;
            string uyeYorumBasligi = cBoxSonYorumlar.SelectedItem.ToString();

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "UPDATE uyeYorumlari SET uyeYorum = @uyeYorum WHERE uyeYorumBasligi = @uyeYorumBasligi";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);

                command.Parameters.AddWithValue("@uyeYorum", uyeYorum);
                command.Parameters.AddWithValue("@uyeYorumBasligi", uyeYorumBasligi);

                try
                {
                    baglanti.Open();

                    int etkilenenSatirlar = command.ExecuteNonQuery();

                    if (etkilenenSatirlar > 0)
                    {
                        MessageBox.Show("Yorum başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Yorum güncellenemedi. Lütfen başlığı kontrol edin.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btnYorumPencereKapat_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            adminPanel.Show();
            this.Close();
        }

        private void KitaplariYukle()
        {
            cBoxYorumKitapSec.Items.Clear();

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT DISTINCT yorumYaptigiKitap FROM uyeYorumlari";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string kitapAdi = reader["yorumYaptigiKitap"].ToString();
                        if (!string.IsNullOrWhiteSpace(kitapAdi))
                        {
                            cBoxYorumKitapSec.Items.Add(kitapAdi);
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

        private void cBoxYorumKitapYorumlari_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string secilenDeger = cBoxYorumKitapYorumlari.SelectedItem.ToString();
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT uyeYorum FROM uyeYorumlari WHERE uyeYorumBasligi = @uyeYorumBasligi";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@uyeYorumBasligi", secilenDeger);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cBoxYorumKitapYorumlari.Text = secilenDeger;
                        rTextBoxKitapYorumlari.Text = reader["uyeYorum"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void btnKitapYorumlariGoster_Click(object sender, EventArgs e)
        {
            kitabaAitYorumlar();

            if (cBoxYorumKitapSec.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kitap seçin.");
                return;
            }
        }

        private void kitabaAitYorumlar()
        {
            cBoxYorumKitapYorumlari.Items.Clear();

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT uyeYorumBasligi FROM uyeYorumlari";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cBoxYorumKitapYorumlari.Items.Add(reader["uyeYorumBasligi"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }
    }
}