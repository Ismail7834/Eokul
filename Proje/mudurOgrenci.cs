using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class mudurOgrenci : Form
    {
        veriTabaniIslemleri vt = new veriTabaniIslemleri();
        SqlCommand komut;
        SqlConnection baglanti;
        string komutsatiri;
        public mudurOgrenci()
        {
            InitializeComponent();
        }

        public void ogrenciListele(string ad)
        {
            try
            {
                baglanti = vt.baglan();

                komutsatiri =
@"SELECT 
o.ogrenciNo,
o.ogrenciAd,
o.ogrenciSoyad,
o.ogrenciTc,
o.anneAdi,
o.babaAdi,
o.dogumTarihi,
o.adres,
o.veliTelefon,
o.ogrenciFoto,
s.sinifAdi,
k.klubAdi,
d.ozurluDevamsizlik,
d.ozursuzDevamsizlik
FROM Ogrenciler o
LEFT JOIN Siniflar s ON o.sinifID = s.sinifID
LEFT JOIN Devamsizlik d ON o.ogrenciNo = d.ogrenciNo
LEFT JOIN Klubler k ON o.klubID = k.klubID";
                komut = new SqlCommand(komutsatiri, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataOgrenci.DataSource = dt;

                dataOgrenci.Columns["ogrenciNo"].HeaderText = "Öğrenci No";
                dataOgrenci.Columns["ogrenciAd"].HeaderText = "Adı";
                dataOgrenci.Columns["ogrenciSoyad"].HeaderText = "Soyadı";
                dataOgrenci.Columns["ogrenciTc"].HeaderText = "TC";
                dataOgrenci.Columns["anneAdi"].HeaderText = "Anne Adı";
                dataOgrenci.Columns["babaAdi"].HeaderText = "Baba Adı";
                dataOgrenci.Columns["dogumTarihi"].HeaderText = "Doğum Tarihi";
                dataOgrenci.Columns["adres"].HeaderText = "Adres";
                dataOgrenci.Columns["veliTelefon"].HeaderText = "Telefon";
                dataOgrenci.Columns["ogrenciFoto"].HeaderText = "Fotoğraf";
                dataOgrenci.Columns["ozurluDevamsizlik"].HeaderText = "Özürlü D";
                dataOgrenci.Columns["ozursuzDevamsizlik"].HeaderText = "Özürsüz D";
                dataOgrenci.Columns["sinifAdi"].HeaderText = "Sınıfı";
                dataOgrenci.Columns["klubAdi"].HeaderText = "Klübü";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void ComboDoldur()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                SqlDataAdapter daS = new SqlDataAdapter("SELECT sinifID, sinifAdi FROM Siniflar", baglanti);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                cbSinif.DataSource = dtS;
                cbSinif.DisplayMember = "sinifAdi";
                cbSinif.ValueMember = "sinifID";   

                SqlDataAdapter daK = new SqlDataAdapter("SELECT klubID, klubAdi FROM Klubler", baglanti);
                DataTable dtK = new DataTable();
                daK.Fill(dtK);
                cbKlub.DataSource = dtK;
                cbKlub.DisplayMember = "klubAdi";
                cbKlub.ValueMember = "klubID";

                SqlDataAdapter daD = new SqlDataAdapter("SELECT dersNo, dersAdi FROM Dersler", baglanti);
                DataTable dtD = new DataTable();
                daD.Fill(dtD);
                cbDersler.DataSource = dtD;
                cbDersler.DisplayMember = "dersAdi";
                cbDersler.ValueMember = "dersNo";
            }
            catch (Exception ex) { MessageBox.Show("Liste yükleme hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            mudurMenu menu = new mudurMenu();
            menu.Show();
            this.Hide();
        }

        private void mudurOgrenci_Load(object sender, EventArgs e)
        {
            ogrenciListele(txtAd.Text);
            notListele();
            this.Icon = new Icon("Icon.ico");
            dataNot.AutoResizeRows();
            ComboDoldur();
        }

        private void mudurOgrenci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void Temizle(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
                else if (ctrl.HasChildren)
                    Temizle(ctrl);
            }
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(this);
            mtbTc.Clear();
            mtbTelefon.Clear();
            rtbAdres.Clear();

        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            Temizle(this);
        }
        

        //              CELL CLİCK


        private void dataOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAd.Text = dataOgrenci.CurrentRow.Cells["ogrenciAd"].Value?.ToString() ?? "";
                txtAnneAd.Text = dataOgrenci.CurrentRow.Cells["anneAdi"].Value?.ToString() ?? "";
                txtBabaAd.Text = dataOgrenci.CurrentRow.Cells["babaAdi"].Value?.ToString() ?? "";
                txtOgrenciNo.Text = dataOgrenci.CurrentRow.Cells["ogrenciNo"].Value?.ToString() ?? "";
                txtSoyad.Text = dataOgrenci.CurrentRow.Cells["ogrenciSoyad"].Value?.ToString() ?? "";
                mtbTc.Text = dataOgrenci.CurrentRow.Cells["ogrenciTc"].Value?.ToString() ?? "";
                mtbTelefon.Text = dataOgrenci.CurrentRow.Cells["veliTelefon"].Value?.ToString() ?? "";
                cbSinif.Text = dataOgrenci.CurrentRow.Cells["sinifAdi"].Value?.ToString() ?? "";
                cbKlub.Text = dataOgrenci.CurrentRow.Cells["klubAdi"].Value?.ToString() ?? "";
                rtbAdres.Text = dataOgrenci.CurrentRow.Cells["adres"].Value?.ToString() ?? "";
                if (dataOgrenci.CurrentRow.Cells["dogumTarihi"].Value != null)
                    dateOgrenci.Value = Convert.ToDateTime(dataOgrenci.CurrentRow.Cells["dogumTarihi"].Value);
                pbOgrenci.Image = null;
                mevcutFotoBytes = null;

                var fotoHücre = dataOgrenci.CurrentRow.Cells["ogrenciFoto"];
                if (fotoHücre?.Value != null && fotoHücre.Value != DBNull.Value)
                {
                    mevcutFotoBytes = fotoHücre.Value as byte[];

                    if (mevcutFotoBytes != null && mevcutFotoBytes.Length > 0)
                    {
                        using (var ms = new MemoryStream(mevcutFotoBytes))
                        using (var img = Image.FromStream(ms))
                        {
                            pbOgrenci.Image = new Bitmap(img);
                            pbOgrenci.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri aktarılırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //              OGRENCİ EKLE 


        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTc.Text) || string.IsNullOrEmpty(txtAd.Text))
            {
                MessageBox.Show("TC ve Ad alanları boş bırakılamaz!");
                return;
            }

            if (MessageBox.Show("Öğrenciyi kaydetmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    SqlCommand cmdSinif = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @sAd", baglanti);
                    cmdSinif.Parameters.AddWithValue("@sAd", cbSinif.Text);
                    object sIDObj = cmdSinif.ExecuteScalar();
                    if (sIDObj == null) { MessageBox.Show("Girdiğiniz sınıf bulunamadı!"); return; }
                    int sID = Convert.ToInt32(sIDObj);

                    SqlCommand cmdKlub = new SqlCommand("SELECT klubID FROM Klubler WHERE klubAdi = @kAd", baglanti);
                    cmdKlub.Parameters.AddWithValue("@kAd", cbKlub.Text);
                    object kIDObj = cmdKlub.ExecuteScalar();
                    if (kIDObj == null) { MessageBox.Show("Girdiğiniz kulüp bulunamadı!"); return; }
                    int kID = Convert.ToInt32(kIDObj);

                    byte[] fotoBytes = null;
                    if (pbOgrenci.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pbOgrenci.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            fotoBytes = ms.ToArray();
                        }
                    }

                    string sql = @"INSERT INTO Ogrenciler (ogrenciTc, ogrenciAd, ogrenciSoyad, anneAdi, babaAdi, veliTelefon, adres, ogrenciFoto, dogumTarihi, sinifID, klubID) 
                           VALUES (@tc, @ad, @soyad, @anne, @baba, @tel, @adr, @foto, @dt, @sID, @kID)";

                    using (SqlCommand cmd = new SqlCommand(sql, baglanti))
                    {
                        cmd.Parameters.AddWithValue("@tc", mtbTc.Text);
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@anne", txtAnneAd.Text);
                        cmd.Parameters.AddWithValue("@baba", txtBabaAd.Text);
                        cmd.Parameters.AddWithValue("@tel", mtbTelefon.Text);
                        cmd.Parameters.AddWithValue("@adr", rtbAdres.Text);
                        cmd.Parameters.AddWithValue("@foto", (object)fotoBytes ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@dt", dateOgrenci.Value);
                        cmd.Parameters.AddWithValue("@sID", sID);
                        cmd.Parameters.AddWithValue("@kID", kID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci kaydı başarıyla tamamlandı.");
                    ogrenciListele("");
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
                finally { baglanti.Close(); }
            }

        }

        private void btnFotoEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbOgrenci.Image = Image.FromFile(ofd.FileName);
                pbOgrenci.Tag = ofd.FileName;
                pbOgrenci.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private byte[] mevcutFotoBytes = null;


        //                  OGRENCİ GUNCELLE 



        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbTc.Text))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz öğrencinin TC numarasını girin.");
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();


                SqlCommand cmdSinif = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @sAd", baglanti);
                cmdSinif.Parameters.AddWithValue("@sAd", cbSinif.Text);
                int sID = Convert.ToInt32(cmdSinif.ExecuteScalar());

                SqlCommand cmdKlub = new SqlCommand("SELECT klubID FROM Klubler WHERE klubAdi = @kAd", baglanti);
                cmdKlub.Parameters.AddWithValue("@kAd", cbKlub.Text);
                int kID = Convert.ToInt32(cmdKlub.ExecuteScalar());


                byte[] fotoBytes = null;
                if (pbOgrenci.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbOgrenci.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        fotoBytes = ms.ToArray();
                    }
                }
                string sql = @"UPDATE Ogrenciler SET 
                        ogrenciAd=@ad, ogrenciSoyad=@soyad, anneAdi=@anne, babaAdi=@baba, 
                        veliTelefon=@tel, adres=@adr, ogrenciFoto=@foto, dogumTarihi=@dt, 
                        sinifID=@sID, klubID=@kID 
                      WHERE ogrenciTc=@tc";

                using (SqlCommand cmd = new SqlCommand(sql, baglanti))
                {
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@anne", txtAnneAd.Text);
                    cmd.Parameters.AddWithValue("@baba", txtBabaAd.Text);
                    cmd.Parameters.AddWithValue("@tel", mtbTelefon.Text);
                    cmd.Parameters.AddWithValue("@adr", rtbAdres.Text);
                    cmd.Parameters.AddWithValue("@foto", (object)fotoBytes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@dt", dateOgrenci.Value);
                    cmd.Parameters.AddWithValue("@sID", sID);
                    cmd.Parameters.AddWithValue("@kID", kID);
                    cmd.Parameters.AddWithValue("@tc", mtbTc.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Öğrenci bilgileri güncellendi.");
                ogrenciListele("");
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }


        //                  OGRENCİ SİL


        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Bu öğrenciye ait tüm kayıtlar silinecek. Emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cevap == DialogResult.Yes)
                {
                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();

                    string ogrenciTc = mtbTc.Text;
                    int ogrenciNo = -1;

                    using (SqlCommand komut = new SqlCommand("SELECT ogrenciNo FROM Ogrenciler WHERE ogrenciTc = @tc", baglanti))
                    {
                        komut.Parameters.AddWithValue("@tc", ogrenciTc);
                        object sonuc = komut.ExecuteScalar();
                        if (sonuc != null)
                            ogrenciNo = Convert.ToInt32(sonuc);
                        else
                            throw new Exception("Öğrenci bulunamadı.");
                    }


                    using (SqlCommand silDevamsizlik = new SqlCommand("DELETE FROM Devamsizlik WHERE ogrenciNo = @no", baglanti))
                    {
                        silDevamsizlik.Parameters.AddWithValue("@no", ogrenciNo);
                        silDevamsizlik.ExecuteNonQuery();
                    }


                    using (SqlCommand silOgrenci = new SqlCommand("DELETE FROM Ogrenciler WHERE ogrenciNo = @no", baglanti))
                    {
                        silOgrenci.Parameters.AddWithValue("@no", ogrenciNo);
                        silOgrenci.ExecuteNonQuery();
                    }

                    MessageBox.Show("Öğrenci ve ilişkili kayıtlar başarıyla silindi.");
                    ogrenciListele("");
                    notListele();
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DevamsizlikGuncelle(1);
            ogrenciListele("");
        }


        private void btnAzalt_Click(object sender, EventArgs e)
        {
            DevamsizlikGuncelle(-1);
            ogrenciListele("");
        }


        //                  DEVAMSIZLIK GUNCELLE


        private void DevamsizlikGuncelle(int miktar)
        {
            if (string.IsNullOrEmpty(txtOgrenciNo.Text)) return;

            string kolon = rbOzurlu.Checked ? "ozurluDevamsizlik" : "ozursuzDevamsizlik";
            int ogrNo = Convert.ToInt32(txtOgrenciNo.Text);

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                string sql = $@"
        IF EXISTS (SELECT 1 FROM Devamsizlik WHERE ogrenciNo=@no)
        BEGIN
            UPDATE Devamsizlik 
            SET {kolon} = CASE WHEN {kolon} + @m < 0 THEN 0 ELSE {kolon} + @m END 
            WHERE ogrenciNo=@no
        END
        ELSE
        BEGIN
            -- INSERT yaparken iki kolonu da (0 ve miktar şeklinde) dolduruyoruz
            INSERT INTO Devamsizlik (ogrenciNo, ozurluDevamsizlik, ozursuzDevamsizlik) 
            VALUES (@no, 
                CASE WHEN @k = 'ozurluDevamsizlik' THEN (CASE WHEN @m < 0 THEN 0 ELSE @m END) ELSE 0 END, 
                CASE WHEN @k = 'ozursuzDevamsizlik' THEN (CASE WHEN @m < 0 THEN 0 ELSE @m END) ELSE 0 END)
        END";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@m", miktar);
                cmd.Parameters.AddWithValue("@no", ogrNo);
                cmd.Parameters.AddWithValue("@k", kolon); 

                cmd.ExecuteNonQuery();


                ogrenciListele("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı Hatası: " + ex.Message);
            }
            finally { baglanti.Close(); }
        }
        private void dataNot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow satir = dataNot.Rows[e.RowIndex];

            try
            {
              
                txtOgrenciNo2.Text = satir.Cells["ogrenciNo"].Value.ToString();

                if (dataNot.Columns.Contains("dersAdi"))
                    cbDersler.Text = satir.Cells["dersAdi"].Value.ToString();

                if (dataNot.Columns.Contains("donemNo"))
                    cbDonem.Text = satir.Cells["donemNo"].Value.ToString();

                txtNot1.Text = satir.Cells["not1"].Value?.ToString() ?? "";
                txtNot2.Text = satir.Cells["not2"].Value?.ToString() ?? "";
                txtSozlu1.Text = satir.Cells["sozlu1"].Value?.ToString() ?? "";
                txtSozlu2.Text = satir.Cells["sozlu2"].Value?.ToString() ?? "";
                txtPerformans.Text = satir.Cells["performansOdevi"].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veri taşıma hatası: " + ex.Message);
            }
        }


        //                  DEVAMSIZLIK LİSTELE 


        private void devamsizlikListele()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                string sql = @"SELECT D.ogrenciNo, O.ogrenciAd, O.ogrenciSoyad, D.ozurluDevamsizlik, D.ozursuzDevamsizlik 
                       FROM Devamsizlik D 
                       INNER JOIN Ogrenciler O ON D.ogrenciNo = O.ogrenciNo";

                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataOgrenci.DataSource = dt; 
            }
            catch (Exception ex) { MessageBox.Show("Listeleme Hatası: " + ex.Message); }
            finally { baglanti.Close(); }
        }


        //                  NOT LİSTELE 


        private void notListele()
        {
            baglanti = vt.baglan();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            string komutSatiri = "SELECT o.ogrenciNo, o.ogrenciAd, d.dersAdi, " +
                     "n.not1, n.not2, n.sozlu1, n.sozlu2, n.performansOdevi, n.donemNo, d.dersNo " +
                     "FROM Ogrenciler o " +
                     "LEFT JOIN Notlar n ON o.ogrenciNo = n.ogrenciNo " +
                     "LEFT JOIN Dersler d ON n.dersNo = d.dersNo";

            SqlCommand komut = new SqlCommand(komutSatiri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataNot.DataSource = dt;

            dataNot.Columns["ogrenciNo"].HeaderText = "Öğrenci No";
            dataNot.Columns["ogrenciAd"].HeaderText = "Adı";
            dataNot.Columns["dersAdi"].HeaderText = "Ders Adı";
            dataNot.Columns["not1"].HeaderText = "Not 1";
            dataNot.Columns["not2"].HeaderText = "Not 2";
            dataNot.Columns["sozlu1"].HeaderText = "Sözlü 1";
            dataNot.Columns["sozlu2"].HeaderText = "Sözlü 2";
            dataNot.Columns["performansOdevi"].HeaderText = "Performans";
            dataNot.Columns["donemNo"].HeaderText = "Dönem";

            dataNot.Columns["dersNo"].Visible = false;

        }


        //                       NOT EKLE


        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciNo2.Text) || string.IsNullOrEmpty(cbDersler.Text))
            {
                MessageBox.Show("Öğrenci No ve Ders Adı boş olamaz!"); return;
            }
            if (cbDonem.Text != "1" && cbDonem.Text != "2")
            {
                MessageBox.Show("Dönem 1 veya 2 olmalıdır!"); return;
            }

            TextBox[] notlar = { txtNot1, txtNot2, txtSozlu1, txtSozlu2, txtPerformans };
            foreach (var kutu in notlar)
            {
                if (int.TryParse(kutu.Text, out int n) && (n < 0 || n > 100))
                {
                    MessageBox.Show("Notlar 0-100 arasında olmalıdır!"); return;
                }
            }

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                SqlCommand dersBul = new SqlCommand("SELECT dersNo FROM Dersler WHERE dersAdi = @dAd", baglanti);
                dersBul.Parameters.AddWithValue("@dAd", cbDersler.Text.Trim());
                object dersObj = dersBul.ExecuteScalar();
                if (dersObj == null) { MessageBox.Show("Ders bulunamadı!"); return; }
                int dersID = Convert.ToInt32(dersObj);

                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Notlar WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn", baglanti);
                kontrol.Parameters.AddWithValue("@o", txtOgrenciNo2.Text);
                kontrol.Parameters.AddWithValue("@d", dersID);
                kontrol.Parameters.AddWithValue("@dn", cbDonem.Text);

                int varMi = (int)kontrol.ExecuteScalar();

                if (varMi > 0)
                {
                    MessageBox.Show("Bu ders kaydı zaten var! Notları değiştirmek için GÜNCELLE butonuna basın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = @"INSERT INTO Notlar (ogrenciNo, dersNo, donemNo, not1, not2, sozlu1, sozlu2, performansOdevi) 
                       VALUES (@o, @d, @dn, @n1, @n2, @s1, @s2, @po)";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@o", txtOgrenciNo2.Text);
                cmd.Parameters.AddWithValue("@d", dersID);
                cmd.Parameters.AddWithValue("@dn", cbDonem.Text);
                cmd.Parameters.AddWithValue("@n1", string.IsNullOrWhiteSpace(txtNot1.Text) ? (object)DBNull.Value : txtNot1.Text);
                cmd.Parameters.AddWithValue("@n2", string.IsNullOrWhiteSpace(txtNot2.Text) ? (object)DBNull.Value : txtNot2.Text);
                cmd.Parameters.AddWithValue("@s1", string.IsNullOrWhiteSpace(txtSozlu1.Text) ? (object)DBNull.Value : txtSozlu1.Text);
                cmd.Parameters.AddWithValue("@s2", string.IsNullOrWhiteSpace(txtSozlu2.Text) ? (object)DBNull.Value : txtSozlu2.Text);
                cmd.Parameters.AddWithValue("@po", string.IsNullOrWhiteSpace(txtPerformans.Text) ? (object)DBNull.Value : txtPerformans.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Yeni ders kaydı oluşturuldu.");
                notListele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        //                      NOT GUNCELLE

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                SqlCommand dersBul = new SqlCommand("SELECT dersNo FROM Dersler WHERE dersAdi = @dAd", baglanti);
                dersBul.Parameters.AddWithValue("@dAd", cbDersler.Text.Trim());
                object dersObj = dersBul.ExecuteScalar();
                if (dersObj == null) return;
                int dersID = Convert.ToInt32(dersObj);

                
                string sql = @"UPDATE Notlar SET 
                        not1=@n1, not2=@n2, sozlu1=@s1, sozlu2=@s2, performansOdevi=@po 
                      WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@o", txtOgrenciNo2.Text);
                cmd.Parameters.AddWithValue("@d", dersID);
                cmd.Parameters.AddWithValue("@dn", cbDonem.Text);
                cmd.Parameters.AddWithValue("@n1", string.IsNullOrWhiteSpace(txtNot1.Text) ? (object)DBNull.Value : txtNot1.Text);
                cmd.Parameters.AddWithValue("@n2", string.IsNullOrWhiteSpace(txtNot2.Text) ? (object)DBNull.Value : txtNot2.Text);
                cmd.Parameters.AddWithValue("@s1", string.IsNullOrWhiteSpace(txtSozlu1.Text) ? (object)DBNull.Value : txtSozlu1.Text);
                cmd.Parameters.AddWithValue("@s2", string.IsNullOrWhiteSpace(txtSozlu2.Text) ? (object)DBNull.Value : txtSozlu2.Text);
                cmd.Parameters.AddWithValue("@po", string.IsNullOrWhiteSpace(txtPerformans.Text) ? (object)DBNull.Value : txtPerformans.Text);

                int etkilenen = cmd.ExecuteNonQuery();

                if (etkilenen > 0)
                    MessageBox.Show("Notlar güncellendi.");
                else
                    MessageBox.Show("Güncellenecek kayıt bulunamadı! Önce KAYDET butonuna basın.");

                notListele();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            finally { baglanti.Close(); }
        }

        //              NOT SİL
        private void btnNotSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciNo2.Text) || cbDersler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen silinecek dersi ve öğrenciyi seçin!"); return;
            }

            DialogResult sor = MessageBox.Show("Bu ders kaydı tamamen silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    int dersID = Convert.ToInt32(cbDersler.SelectedValue);

                    string sql = "DELETE FROM Notlar WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn";
                    SqlCommand cmd = new SqlCommand(sql, baglanti);
                    cmd.Parameters.AddWithValue("@o", txtOgrenciNo2.Text);
                    cmd.Parameters.AddWithValue("@d", dersID);
                    cmd.Parameters.AddWithValue("@dn", cbDonem.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sadece seçili dersin not kaydı silindi.");
                    notListele();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { baglanti.Close(); }
            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrenciAra.Text;

            SqlDataAdapter daOgr = new SqlDataAdapter(@"
                                SELECT 
                                O.*, 
                                S.sinifAdi,
                                D.ozurluDevamsizlik,
                                D.ozursuzDevamsizlik,
                                K.klubAdi
                                FROM Ogrenciler O
                                LEFT JOIN Devamsizlik D ON  O.ogrenciNo= D.ogrenciNo
                                LEFT JOIN Siniflar S ON O.sinifID = S.sinifID
                                LEFT JOIN Klubler K ON O.klubID = K.klubID
                                WHERE O.ogrenciAd LIKE @ad + '%'", baglanti);
            {
            }
            ;
            daOgr.SelectCommand.Parameters.AddWithValue("@ad", aranan + "%");
            DataTable dtOgr = new DataTable();
            daOgr.Fill(dtOgr);
            dataOgrenci.DataSource = dtOgr;
            if (dataOgrenci.Columns.Contains("sinifID"))
                dataOgrenci.Columns["sinifID"].Visible = false;
            if (dataOgrenci.Columns.Contains("ogrenciNo"))
                dataOgrenci.Columns["ogrenciNo"].Visible = false;
            if (dataOgrenci.Columns.Contains("klubID"))
                dataOgrenci.Columns["klubID"].Visible = false;


            SqlDataAdapter daNot = new SqlDataAdapter(@"
                            SELECT
                            N.notID,
                            O.ogrenciNo,
                            O.ogrenciAd,
                            N.not1,
                            N.not2,
                            N.sozlu1,
                            N.sozlu2,
                            N.performansOdevi,
                            N.donemNo
                            FROM Ogrenciler O
                            LEFT JOIN Notlar N ON O.ogrenciNo = N.ogrenciNo
                            WHERE O.ogrenciAd LIKE @ad + '%'", baglanti);
            daNot.SelectCommand.Parameters.AddWithValue("@ad", aranan);
            DataTable dtNot = new DataTable();
            daNot.Fill(dtNot);
            dataNot.DataSource = dtNot;
        }
    }
}





