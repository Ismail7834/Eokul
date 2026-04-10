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

namespace Proje
{
    public partial class ogretmenParola : Form
    {
        veriTabaniIslemleri vt= new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogretmenParola()
        {
            InitializeComponent();
        }
        public string ogretmenTc;
        public string sifre;
        private void Geri_Click(object sender, EventArgs e)
        {

            ogretmenMenu om=new ogretmenMenu(ogretmenTc,sifre);
            om.Show();
            this.Hide();
        }
        private string GuvenlikKoduUret()
        {
            Random rnd = new Random();
            string karakterler = "ABCDEFGHJKLMNPQRSTUVWXYZ123456789";
            return new string(Enumerable.Range(0, 6).Select(x => karakterler[rnd.Next(karakterler.Length)]).ToArray());
        }

        private void OgretmenParola_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            baglanti = vt.baglan();
            baglanti.Open();
            lblGuvenlik.Text = GuvenlikKoduUret();
        }

        private void OgretmenParola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string mevcut = txtMParola.Text.Trim();
            string yeni = txtYParola.Text.Trim();
            string girilenKod = txtGuvenlik.Text.Trim();
            string guvenlikKod = lblGuvenlik.Text;

            if (string.IsNullOrWhiteSpace(mevcut) || string.IsNullOrWhiteSpace(yeni) || string.IsNullOrWhiteSpace(girilenKod))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (girilenKod != guvenlikKod)
            {
                MessageBox.Show("Güvenlik kodu hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblGuvenlik.Text = GuvenlikKoduUret();
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM Ogretmenler WHERE ogretmenTC = @tc AND sifre = @mevcut", baglanti);
                kontrolCmd.Parameters.AddWithValue("@tc", ogretmenTc); 
                kontrolCmd.Parameters.AddWithValue("@mevcut", mevcut);

                int sayi = Convert.ToInt32(kontrolCmd.ExecuteScalar());

                if (sayi == 0)
                {
                    MessageBox.Show("Mevcut parola hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mevcut == yeni)
                {
                    MessageBox.Show("Yeni parola, mevcut parolayla aynı olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand guncelle = new SqlCommand("UPDATE Ogretmenler SET sifre = @yeni WHERE ogretmenTC = @tc", baglanti);
                guncelle.Parameters.AddWithValue("@yeni", yeni);
                guncelle.Parameters.AddWithValue("@tc", ogretmenTc);
                guncelle.ExecuteNonQuery();

                MessageBox.Show("Parola başarıyla değiştirildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
