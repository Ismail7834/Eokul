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
    public partial class mudurDersProgrami : Form
    {
        veriTabaniIslemleri vt = new veriTabaniIslemleri();
        SqlConnection baglanti;

        public mudurDersProgrami()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            mudurMenu mm = new mudurMenu();
            mm.Show();
            this.Hide();
        }
        public void Listele()
        {
            baglanti = vt.baglan();
            SqlDataAdapter da = new SqlDataAdapter(@"
SELECT dp.islemID,dp.programID, d.dersAdi, dp.dersSaati, dp.gun, s.sinifAdi
FROM Ders_Programi dp
JOIN Dersler d ON dp.dersNo = d.dersNo
JOIN Siniflar s ON dp.sinifID = s.sinifID", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataDersProgram.DataSource = dt;
            dataDersProgram.Columns["programID"].HeaderText = "Program No";
            dataDersProgram.Columns["dersAdi"].HeaderText = "Ders Adı";
            dataDersProgram.Columns["dersSaati"].HeaderText = "Ders Saati";
            dataDersProgram.Columns["gun"].HeaderText = "Gün";
            dataDersProgram.Columns["sinifAdi"].HeaderText = "Sınıf Adı";
            if (dataDersProgram.Columns.Contains("islemID"))
                dataDersProgram.Columns["islemID"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (txtProgram.Text==" "||txtGun.Text==" "||txtDersAd.Text==" "||txtSaat.Text==" "||txtSinif.Text==" ")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }

                int programID = int.Parse(txtProgram.Text);


                SqlCommand ders = new SqlCommand("SELECT dersNo FROM Dersler WHERE dersAdi = @adi", baglanti);
                ders.Parameters.AddWithValue("@adi", txtDersAd.Text);
                object dersNoObj = ders.ExecuteScalar();

                if (dersNoObj == null)
                {
                    MessageBox.Show("Girilen ders sistemde kayıtlı değil!");
                    return;
                }
                int dersNo = (int)dersNoObj;


                SqlCommand sinif = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @adi", baglanti);
                sinif.Parameters.AddWithValue("@adi", txtSinif.Text);
                object sinifIDObj = sinif.ExecuteScalar();

                if (sinifIDObj == null)
                {
                    MessageBox.Show("Girilen sınıf sistemde bulunamadı!");
                    return;
                }
                int sinifID = (int)sinifIDObj;


                SqlCommand kontrol = new SqlCommand(
@"SELECT DISTINCT sinifID FROM Ders_Programi WHERE programID = @programID", baglanti);
                kontrol.Parameters.AddWithValue("@programID", programID);
                object oncekiSinif = kontrol.ExecuteScalar();

                if (oncekiSinif != null && (int)oncekiSinif != sinifID)
                {
                    MessageBox.Show("Bu Program ID başka bir sınıfa atanmış. Aynı program farklı sınıflarda kullanılamaz!");
                    return;
                }


                SqlCommand toplamSaat = new SqlCommand(
@"SELECT ISNULL(SUM(CAST(SUBSTRING(dersSaati, 1, 2) AS INT)), 0) FROM Ders_Programi WHERE programID = @programID", baglanti);
                toplamSaat.Parameters.AddWithValue("@programID", programID);
                int toplamSaat1 = (int)toplamSaat.ExecuteScalar();


                int yeniSaat;
                if (!int.TryParse(txtSaat.Text, out yeniSaat))
                {
                    MessageBox.Show("Ders saati sayı olarak girilmeli!");
                    return;
                }

                if (toplamSaat1 + yeniSaat > 10)
                {
                    MessageBox.Show("Bu programın toplam ders saati 10 saati aşamaz!");
                    return;
                }


                SqlCommand ekle = new SqlCommand(
@"INSERT INTO Ders_Programi (programID, dersNo, dersSaati, gun, sinifID) VALUES (@programID, @dersNo, @saat, @gun, @sinifID)", baglanti);

                ekle.Parameters.AddWithValue("@programID", programID);
                ekle.Parameters.AddWithValue("@dersNo", dersNo);
                ekle.Parameters.AddWithValue("@saat", txtSaat.Text);
                ekle.Parameters.AddWithValue("@gun", txtGun.Text);
                ekle.Parameters.AddWithValue("@sinifID", sinifID);

                ekle.ExecuteNonQuery();
                MessageBox.Show("Ders başarıyla programa eklendi.");
                Listele();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
            finally
            {
                baglanti.Close();
            }
        }
        int seciliIslem = 0;
        private void dataDersProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliIslem = Convert.ToInt32(dataDersProgram.CurrentRow.Cells["islemID"].Value);
            txtProgram.Text = dataDersProgram.CurrentRow.Cells["programID"].Value?.ToString() ?? "";
            txtDersAd.Text = dataDersProgram.CurrentRow.Cells["dersAdi"].Value?.ToString() ?? "";
            txtSaat.Text = dataDersProgram.CurrentRow.Cells["dersSaati"].Value?.ToString() ?? "";
            txtGun.Text = dataDersProgram.CurrentRow.Cells["gun"].Value?.ToString() ?? "";
            txtSinif.Text = dataDersProgram.CurrentRow.Cells["sinifAdi"].Value?.ToString() ?? "";
        }

        private void mudurDersProgrami_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            Listele();
        }

        private void mudurDersProgrami_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                if (seciliIslem == 0)
                {
                    MessageBox.Show("Güncellenecek satırı seçin.");
                    return;
                }

                try
                {
                    if (baglanti.State != ConnectionState.Open)
                        baglanti.Open();

                    string gun = txtGun.Text.Trim();
                    string dersAdi = txtDersAd.Text.Trim();

                    int dersno;
                    SqlCommand ders = new SqlCommand("SELECT dersNo FROM Dersler WHERE dersAdi = @dersAdi", baglanti);
                    ders.Parameters.AddWithValue("@dersAdi", dersAdi);
                    SqlDataReader dr = ders.ExecuteReader();

                    if (dr.Read())
                    {
                        dersno = Convert.ToInt32(dr["dersNo"]);
                    }
                    else
                    {
                        MessageBox.Show("Girilen ders adı geçerli değil.");
                        dr.Close();
                        return;
                    }
                    dr.Close();

                    int sinifID;
                    SqlCommand sinifSorgu = new SqlCommand("SELECT sinifID FROM Siniflar WHERE sinifAdi = @ad", baglanti);
                    sinifSorgu.Parameters.AddWithValue("@ad", txtSinif.Text.Trim());
                    SqlDataReader sinifDR = sinifSorgu.ExecuteReader();

                    if (sinifDR.Read())
                    {
                        sinifID = Convert.ToInt32(sinifDR["sinifID"]);
                    }
                    else
                    {
                        MessageBox.Show("Girilen sınıf adı veritabanında bulunamadı.");
                        sinifDR.Close();
                        return;
                    }
                    sinifDR.Close();

                    SqlCommand guncelle = new SqlCommand(@"
UPDATE Ders_Programi 
SET programID = @programID, sinifID = @sinifID, gun = @gun, dersSaati = @saat, dersNo = @dersNo 
WHERE islemID = @islemID", baglanti);

                    guncelle.Parameters.AddWithValue("@programID", txtProgram.Text);
                    guncelle.Parameters.AddWithValue("@sinifID", sinifID);
                    guncelle.Parameters.AddWithValue("@gun", gun);
                    guncelle.Parameters.AddWithValue("@saat", txtSaat.Text);
                    guncelle.Parameters.AddWithValue("@dersNo", dersno); // ✅ burası düzeltildi
                    guncelle.Parameters.AddWithValue("@islemID", seciliIslem);

                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Ders programı güncellendi.");
                    Listele();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex.Message);
                }
          
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDersAd.Clear();
            txtSaat.Clear();
            txtProgram.Clear();
            txtGun.Clear();
            txtSinif.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliIslem == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçin.");
                return;
            }

            DialogResult sonuc = MessageBox.Show("Bu dersi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    SqlCommand silKomut = new SqlCommand("DELETE FROM Ders_Programi WHERE islemID = @id", baglanti);
                    silKomut.Parameters.AddWithValue("@id", seciliIslem);

                    silKomut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Ders programı silindi.");
                    Listele();
                    baglanti.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi sırasında hata oluştu:\n" + ex.Message);
                }
            }
        }

        private void txtProgramAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtProgramAra.Text.Trim();

            string komut = @"
SELECT dp.islemID, dp.programID, s.sinifAdi, dp.gun, dp.dersSaati, d.dersAdi
FROM Ders_Programi dp
JOIN Siniflar s ON dp.sinifID = s.sinifID
JOIN Dersler d ON dp.dersNo = d.dersNo
WHERE CAST(dp.programID AS NVARCHAR) LIKE @aranan";

            SqlCommand cmd = new SqlCommand(komut, baglanti);
            cmd.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataDersProgram.DataSource = dt;

            baglanti.Close();

        }
    }
}
