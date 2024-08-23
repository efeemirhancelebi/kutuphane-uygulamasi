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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphaneUygulamasi
{
    public partial class rezerveKitapPaneli : Form
    {
        public rezerveKitapPaneli()
        {
            InitializeComponent();

            string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
            string sorgu = "SELECT rezerveKitap FROM rezerveKitaplar";

            using (SqlConnection baglanti = new SqlConnection(veritabani))
            {
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                try
                {
                    baglanti.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cBoxRezKitaplar.Items.Add(reader["rezerveKitap"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata meydana geldi: " + ex.Message);
                }
            }
        }

        private void cBoxRezKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxRezKitaplar.SelectedIndex != -1)
            {
                string secilenDeger = cBoxRezKitaplar.SelectedItem.ToString();
                string veritabani = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=kutuphaneUygulamasi;Integrated Security=True";
                string sorgu = "SELECT uyeAd, uyeSoyad, uyeAdres FROM rezerveKitaplar WHERE rezerveKitap = @rezerveKitap";

                using (SqlConnection baglanti = new SqlConnection(veritabani))
                {
                    SqlCommand command = new SqlCommand(sorgu, baglanti);
                    command.Parameters.AddWithValue("@rezerveKitap", secilenDeger);

                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            tBoxRezAd.Text = reader["uyeAd"].ToString();
                            tBoxRezSoyad.Text = reader["uyeSoyad"].ToString();
                            rTextBoxAdres.Text = reader["uyeAdres"].ToString();
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
}