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
    public partial class uyeBilgileriPaneli : Form
    {
        public uyeBilgileriPaneli()
        {
            InitializeComponent();

            MessageBox.Show("Sistemi kullanmak için e-posta kısmına kullanıcı bilgilerini öğrenmek istediğiniz kişinin e-posta adresini girin.");
        }

        private void btnUyeBilgSorgula_Click(object sender, EventArgs e)
        {
            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";

            string uyeAd = tBoxUyeBilgAd.Text;
            string uyeSoyad = tBoxUyeBilgSoyad.Text;
            string uyeTc = tBoxUyeBilgTc.Text;
            string uyeMail = tBoxUyeBilgMail.Text;
            string uyeSifre = tBoxUyeBilgSifre.Text;
            string uyeCins = tBoxUyeBilgCins.Text;
            string uyeAdres = tBoxUyeBilgAdres.Text;
            string uyeOgrBilgi = tBoxUyeBilgOgr.Text;

            string sorgu = "SELECT uyeAd, uyeSoyad, uyeAdres, uyeTc, uyeMail, uyeSifre, uyeCins, uyeAdres, uyeOgrBilgi FROM uyeBilgileri WHERE uyeMail = @uyeMail";
            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@uyeMail", uyeMail);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        tBoxUyeBilgAd.Text = reader["uyeAd"].ToString();
                        tBoxUyeBilgSoyad.Text = reader["uyeSoyad"].ToString();
                        tBoxUyeBilgAdres.Text = reader["uyeAdres"].ToString();
                        tBoxUyeBilgTc.Text = reader["uyeTc"].ToString();
                        tBoxUyeBilgMail.Text = reader["uyeMail"].ToString();
                        tBoxUyeBilgSifre.Text = reader["uyeSifre"].ToString();
                        tBoxUyeBilgCins.Text = reader["uyeCins"].ToString();
                        tBoxUyeBilgOgr.Text = reader["uyeOgrBilgi"].ToString();

                        MessageBox.Show("Bilgiler toplandı.");
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
