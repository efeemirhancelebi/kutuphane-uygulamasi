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
    public partial class uyeAskiyaAlmaPaneli : Form
    {
        public uyeAskiyaAlmaPaneli()
        {
            InitializeComponent();
        }

        private void btnAski1_Click(object sender, EventArgs e)
        {
            string uyeAd = tBoxAskiAd1.Text;
            string uyeSoyad = tBoxAskiSoyad1.Text;
            string uyeMail = tBoxAskiMail1.Text;
            string uyeAskiNedeni = rTextBoxAskiNeden1.Text;

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "INSERT INTO askiyaAlinmisHesaplar (uyeAd, uyeSoyad, uyeMail, uyeAskiNedeni) VALUES (@uyeAd, @uyeSoyad, @uyeMail, @uyeAskiNedeni)";
            string sorgu2 = "SELECT * FROM askiyaAlinmisHesaplar WHERE uyeMail = @uyeMail";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                using (SqlCommand cmd2 = new SqlCommand(sorgu2, baglanti))
                {
                    baglanti.Open();

                    cmd2.Parameters.AddWithValue("@uyeMail", uyeMail);
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("Kullanıcı hesabı zaten askıya alınmış durumda.");
                            return;
                        }
                    }

                    baglanti.Close();
                }

                using (SqlCommand cmd = new SqlCommand(sorgu, baglanti))
                {
                    cmd.Parameters.AddWithValue("@uyeAd", uyeAd);
                    cmd.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);
                    cmd.Parameters.AddWithValue("@uyeMail", uyeMail);
                    cmd.Parameters.AddWithValue("@uyeAskiNedeni", uyeAskiNedeni);

                    try
                    {
                        baglanti.Open();
                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Üye hesabı başarıyla askıya alındı.");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Bir hata meydana geldi.");
                            return;
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

        private void btnAski2_Click(object sender, EventArgs e)
        {
            string uyeAd = tBoxAskiAd2.Text;
            string uyeSoyad = tBoxAskiSoyad2.Text;
            string uyeMail = tBoxAskiMail2.Text;

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "DELETE FROM askiyaAlinmisHesaplar WHERE uyeAd = @uyeAd AND uyeSoyad = @uyeSoyad AND uyeMail = @uyeMail";
            string sorgu2 = "SELECT * FROM askiyaAlinmisHesaplar WHERE uyeMail = @uyeMail";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                using (SqlCommand command2 = new SqlCommand(sorgu2, baglanti))
                {
                    baglanti.Open();

                    command2.Parameters.AddWithValue("@uyeMail", uyeMail);
                    using (SqlDataReader reader = command2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı hesabı zaten askıdan çıkartılmış durumda ya da hiç askıya alınmamış.");
                            return;
                        }

                        baglanti.Close();
                    }

                    try
                    {
                        SqlCommand command = new SqlCommand(sorgu, baglanti);
                        command.Parameters.AddWithValue("@uyeAd", uyeAd);
                        command.Parameters.AddWithValue("@uyeSoyad", uyeSoyad);
                        command.Parameters.AddWithValue("@uyeMail", uyeMail);

                        baglanti.Open();
                        int degerlerSilindi = command.ExecuteNonQuery();
                        if (degerlerSilindi > 0)
                        {
                            MessageBox.Show("Hesap başarıyla askıdan çıkartıldı.");
                        }
                        else
                        {
                            MessageBox.Show("Askıdaki hesaplar arasında kullanıcıya ait veri bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                    }
                }
            }
        }
    }
}
        


