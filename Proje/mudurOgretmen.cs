using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class mudurOgretmen : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public mudurOgretmen()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            mudurMenu menu=new mudurMenu();
            menu.Show();
            this.Hide();
        }

        private void mudurOgretmen_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            OgretmenListele();
        }
        void OgretmenListele()
        {
            baglanti = vt.baglan();

            string komutsatiri = @"
SELECT 
o.ogretmenNo, 
o.ogretmenAd, 
o.ogretmenSoyad, 
o.ogretmenTC, 
o.ogretmenTelefon,
o.ogretmenEmail, 
o.ogretmenAdres, 
o.ogretmenBrans, 
o.dogumTarihi,
s.sinifAdi, 
k.klubAdi,
o.ogretmenFoto,
o.sifre
FROM Ogretmenler o
LEFT JOIN Siniflar s ON o.sinifID = s.sinifID
LEFT JOIN Klubler k ON o.klubID = k.klubID";

            SqlDataAdapter da = new SqlDataAdapter(komutsatiri, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataOgretmen.DataSource = dt;

            dataOgretmen.Columns["ogretmenNo"].HeaderText = "No";
            dataOgretmen.Columns["ogretmenAd"].HeaderText = "Ad";
            dataOgretmen.Columns["ogretmenSoyad"].HeaderText = "Soyad";
            dataOgretmen.Columns["ogretmenTC"].HeaderText = "TC No";
            dataOgretmen.Columns["ogretmenTelefon"].HeaderText = "Telefon";
            dataOgretmen.Columns["ogretmenEmail"].HeaderText = "Email";
            dataOgretmen.Columns["ogretmenAdres"].HeaderText = "Adres";
            dataOgretmen.Columns["ogretmenBrans"].HeaderText = "Branş";
            dataOgretmen.Columns["dogumTarihi"].HeaderText = "Doğum Tarihi";
            dataOgretmen.Columns["sinifAdi"].HeaderText = "Sınıf";
            dataOgretmen.Columns["klubAdi"].HeaderText = "Kulüp";
            dataOgretmen.Columns["ogretmenFoto"].HeaderText = "Fotoğraf";
            dataOgretmen.Columns["sifre"].HeaderText = "Şifre";
        }
        private void mudurOgretmen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydetmek İstiyor musunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {


                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    using (SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Ogrenciler WHERE ogrenciTc = @tc", baglanti))
                    {
                        kontrol.Parameters.AddWithValue("@tc", mtbTC.Text);
                        int sayi = (int)kontrol.ExecuteScalar();
                        if (sayi > 0)
                        {
                            MessageBox.Show("Bu öğrenci zaten kayıtlı!");
                            return;
                        }
                    }

                    if (!txtEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Lütfen geçerli bir e-posta adresi girin (örnek: isim@mail.com).");
                        return;
                    }


                    int? sinifID = null;
                    SqlCommand sinif = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @sinifAdi", baglanti);
                    sinif.Parameters.AddWithValue("@sinifAdi", txtSinif.Text);
                    object sinifIDObj = sinif.ExecuteScalar();
                    if (sinifIDObj != null)
                        sinifID = (int)sinifIDObj;


                    int? klubID = null;
                    SqlCommand klub = new SqlCommand("SELECT klubID FROM Klubler WHERE klubAdi = @klubAdi", baglanti);
                    klub.Parameters.AddWithValue("@klubAdi", txtKlub.Text);
                    object klubIDObj = klub.ExecuteScalar();
                    if (klubIDObj != null)
                        klubID = (int)klubIDObj;



                    string bransAdi = txtBrans.Text.Trim();
                    SqlCommand ders = new SqlCommand("SELECT dersAdi FROM Dersler WHERE dersAdi = @dersAdi", baglanti);
                    ders.Parameters.AddWithValue("@dersAdi", bransAdi);
                    object dersObj = ders.ExecuteScalar();
                    string bransDegeri = dersObj != null ? bransAdi : null;


                    byte[] fotoBytes = null;
                    if (pbOgretmen.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbOgretmen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBytes = ms.ToArray();
                        }
                    }



                    string sifre = txtSifre.Text.Trim();
                    if (string.IsNullOrEmpty(sifre))
                    {
                        MessageBox.Show("Şifre boş olamaz.");
                        return;
                    }


                    SqlCommand ekle = new SqlCommand(@"
        INSERT INTO Ogretmenler (
            ogretmenAd, ogretmenSoyad, ogretmenTC, ogretmenTelefon,
            ogretmenEmail, ogretmenAdres, ogretmenBrans, dogumTarihi,
            sinifID, klubID, ogretmenFoto, sifre
        )
        VALUES (
            @ad, @soyad, @tc, @telefon,
            @mail, @adres, @brans, @dogum,
            @sinifID, @klubID, @foto, @sifre
        )", baglanti);

                    ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                    ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    ekle.Parameters.AddWithValue("@tc", mtbTC.Text);
                    ekle.Parameters.AddWithValue("@telefon", mtbTelefon.Text);
                    ekle.Parameters.AddWithValue("@mail", txtEmail.Text);
                    ekle.Parameters.AddWithValue("@adres", rtbAdres.Text);
                    ekle.Parameters.AddWithValue("@brans", bransDegeri ?? (object)DBNull.Value);
                    ekle.Parameters.AddWithValue("@dogum", dateOgretmen.Value);
                    ekle.Parameters.AddWithValue("@sinifID", sinifID ?? (object)DBNull.Value);
                    ekle.Parameters.AddWithValue("@klubID", (object)klubID ?? DBNull.Value);
                    ekle.Parameters.AddWithValue("@foto", fotoBytes ?? (object)DBNull.Value);
                    ekle.Parameters.AddWithValue("@sifre", sifre);

                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Öğretmen başarıyla eklendi.");
                    OgretmenListele();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex.Message);
                }

            }
        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbOgretmen.Image = Image.FromFile(ofd.FileName);
                pbOgretmen.Tag = ofd.FileName;
                pbOgretmen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataOgretmen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSifre.Text = dataOgretmen.CurrentRow.Cells["sifre"].Value.ToString() ?? "";
            txtNo.Text = dataOgretmen.CurrentRow.Cells["ogretmenNo"].Value.ToString() ?? "";
            txtAd.Text = dataOgretmen.CurrentRow.Cells["ogretmenAd"].Value.ToString() ?? "";
            txtSoyad.Text = dataOgretmen.CurrentRow.Cells["ogretmenSoyad"].Value.ToString() ?? "";
            mtbTC.Text = dataOgretmen.CurrentRow.Cells["ogretmenTC"].Value.ToString() ?? "";
            mtbTelefon.Text = dataOgretmen.CurrentRow.Cells["ogretmenTelefon"].Value.ToString() ?? "";
            txtEmail.Text = dataOgretmen.CurrentRow.Cells["ogretmenEmail"].Value.ToString() ?? "";
            rtbAdres.Text = dataOgretmen.CurrentRow.Cells["ogretmenAdres"].Value.ToString() ?? "";
            txtBrans.Text = dataOgretmen.CurrentRow.Cells["ogretmenBrans"].Value.ToString() ?? "";
            txtSinif.Text = dataOgretmen.CurrentRow.Cells["sinifAdi"].Value.ToString() ?? "";
            txtKlub.Text = dataOgretmen.CurrentRow.Cells["klubAdi"].Value.ToString() ?? "";
            if (dataOgretmen.CurrentRow.Cells["dogumTarihi"].Value != null)
                dateOgretmen.Value = Convert.ToDateTime(dataOgretmen.CurrentRow.Cells["dogumTarihi"].Value);
            pbOgretmen.Image = null;
            mevcutFotoBytes = null;

            var fotoHücre = dataOgretmen.CurrentRow.Cells["ogretmenFoto"];
            if (fotoHücre?.Value != null && fotoHücre.Value != DBNull.Value)
            {
                mevcutFotoBytes = fotoHücre.Value as byte[];

                if (mevcutFotoBytes != null && mevcutFotoBytes.Length > 0)
                {
                    using (var ms = new MemoryStream(mevcutFotoBytes))
                    using (var img = Image.FromStream(ms))
                    {
                        pbOgretmen.Image = new Bitmap(img);
                        pbOgretmen.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }
        private byte[] mevcutFotoBytes = null;
        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu öğretmenin bilgilerini güncellemek istiyor musunuz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

    
                    SqlCommand sinif = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @sinifAdi", baglanti);
                    sinif.Parameters.AddWithValue("@sinifAdi", txtSinif.Text);
                    object sinifIDObj = sinif.ExecuteScalar();
                    int? sinifID = sinifIDObj != null ? (int?)Convert.ToInt32(sinifIDObj) : null;

                    SqlCommand klub = new SqlCommand("SELECT klubID FROM Klubler WHERE klubAdi = @klubAdi", baglanti);
                    klub.Parameters.AddWithValue("@klubAdi", txtKlub.Text);
                    object klubIDObj = klub.ExecuteScalar();
                    int? klubID = klubIDObj != null ? (int?)Convert.ToInt32(klubIDObj) : null;

                    if (!txtEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SqlCommand dersCmd = new SqlCommand("SELECT COUNT(*) FROM Dersler WHERE dersAdi = @ad", baglanti);
                    dersCmd.Parameters.AddWithValue("@ad", txtBrans.Text);
                    int dersVarMi = (int)dersCmd.ExecuteScalar();
                    string brans = txtBrans.Text;

                    if (string.IsNullOrWhiteSpace(txtSifre.Text))
                    {
                        MessageBox.Show("Şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string sifre = txtSifre.Text;


                    byte[] fotoBytes = null;
                    if (pbOgretmen.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbOgretmen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBytes = ms.ToArray();
                        }

                        if (mevcutFotoBytes != null && fotoBytes.SequenceEqual(mevcutFotoBytes))
                        {
                            fotoBytes = null;
                        }
                    }

                    SqlCommand guncelle = new SqlCommand(@"
            UPDATE Ogretmenler SET 
                ogretmenAd = @ad,
                ogretmenSoyad = @soyad,
                ogretmenTelefon = @tel,
                ogretmenEmail = @email,
                ogretmenAdres = @adres,
                ogretmenBrans = @brans,
                dogumTarihi = @dogum,
                sinifID = @sinifID,
                klubID = @klubID,
                ogretmenFoto = @foto,
                sifre = @sifre
            WHERE ogretmenNo = @no", baglanti);

                    guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                    guncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    guncelle.Parameters.AddWithValue("@tel", mtbTelefon.Text);
                    guncelle.Parameters.AddWithValue("@email", txtEmail.Text);
                    guncelle.Parameters.AddWithValue("@adres", rtbAdres.Text);
                    guncelle.Parameters.AddWithValue("@brans", brans);
                    guncelle.Parameters.AddWithValue("@dogum", dateOgretmen.Value);
                    guncelle.Parameters.AddWithValue("@sinifID", (object)sinifID ?? DBNull.Value);
                    guncelle.Parameters.AddWithValue("@klubID", (object)klubID ?? DBNull.Value);
                    guncelle.Parameters.AddWithValue("@foto", (object)fotoBytes ?? DBNull.Value);
                    guncelle.Parameters.AddWithValue("@sifre", sifre);
                    guncelle.Parameters.AddWithValue("@no", txtNo.Text);

                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleştirildi ");
                    OgretmenListele();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            
            DialogResult cevap = MessageBox.Show("Bu öğretmeni silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {

                    if(baglanti.State!=ConnectionState.Open) baglanti.Open();
                    SqlCommand sil = new SqlCommand("DELETE FROM Ogretmenler WHERE ogretmenNo = @no", baglanti);
                    sil.Parameters.AddWithValue("@no", txtNo.Text);

                    sil.ExecuteNonQuery();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleştirildi");
                    OgretmenListele();
                    baglanti.Close ();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

            }
        }

        private void txtOgretmenAra_TextChanged(object sender, EventArgs e)
        {
            string arama = txtOgretmenAra.Text.Trim();
            baglanti = vt.baglan();

            string komut = @"
SELECT o.ogretmenNo, o.ogretmenAd, o.ogretmenSoyad, o.ogretmenTC, o.ogretmenTelefon,
       o.ogretmenEmail, o.ogretmenAdres, o.ogretmenBrans, o.dogumTarihi,
       o.ogretmenFoto, s.sinifAdi, k.klubAdi
FROM Ogretmenler o
LEFT JOIN Siniflar s ON o.sinifID = s.sinifID
LEFT JOIN Klubler k ON o.klubID = k.klubID
WHERE o.ogretmenAd LIKE @arama";

            SqlDataAdapter da = new SqlDataAdapter(komut, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@arama", "%" + arama + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataOgretmen.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtBrans.Clear();
            txtNo.Clear();
            txtEmail.Clear();
            txtKlub.Clear();
            txtSinif.Clear();
            txtSoyad.Clear();
            mtbTC.Clear();
            mtbTelefon.Clear();
            rtbAdres.Clear();
            txtSifre.Clear();
            pbOgretmen.BackgroundImage = null;
            dateOgretmen.Value= DateTime.Now;
        }
    }
}
