using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class mudurDers : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutsatiri;
        public mudurDers()
        {
            InitializeComponent();
        }

        private void mudurDers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mudurDers_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            dataDers.AutoResizeRows();
            Listele();
            comboDoldur();
        }
        private void comboDoldur()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                SqlDataAdapter daD = new SqlDataAdapter("SELECT ogretmenNo, ogretmenAd FROM Ogretmenler", baglanti);
                DataTable dtD = new DataTable();
                daD.Fill(dtD);
                cbOgretmen.DataSource = dtD;
                cbOgretmen.DisplayMember = "ogretmenAd";
                cbOgretmen.ValueMember = "ogretmenNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        SELECT 
            d.dersNo AS [Ders No],
            d.dersAdi AS [Ders Adı],
            o.ogretmenAd + ' ' + o.ogretmenSoyad AS [Öğretmen]
        FROM Dersler d
        LEFT JOIN Ogretmenler o ON d.ogretmenNo = o.ogretmenNo", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataDers.DataSource = dt;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                
                SqlCommand komutOgretmen = new SqlCommand("SELECT ogretmenNo FROM Ogretmenler WHERE ogretmenAd =@ad", baglanti);
                komutOgretmen.Parameters.AddWithValue("@ad", cbOgretmen.Text);
                object ogretmenNoObj = komutOgretmen.ExecuteScalar();

                if (ogretmenNoObj == null)
                {
                    MessageBox.Show("Girilen öğretmen bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int ogretmenNo = Convert.ToInt32(ogretmenNoObj);

               
                SqlCommand komutEkle = new SqlCommand("INSERT INTO Dersler (dersAdi, ogretmenNo) VALUES (@ad, @ogretmenNo)", baglanti);
                komutEkle.Parameters.AddWithValue("@ad", txtDers.Text);
                komutEkle.Parameters.AddWithValue("@ogretmenNo", ogretmenNo);

                komutEkle.ExecuteNonQuery();
                MessageBox.Show("Ders başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele(); 
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Guncellemek İstiyor musunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    
                    SqlCommand ogretmenCmd = new SqlCommand("SELECT ogretmenNo FROM Ogretmenler WHERE ogretmenAd =@ad", baglanti);
                    ogretmenCmd.Parameters.AddWithValue("@ad", cbOgretmen.Text);
                    object ogretmenNoObj = ogretmenCmd.ExecuteScalar();

                    if (ogretmenNoObj == null)
                    {
                        MessageBox.Show("Girilen ad soyada ait bir öğretmen bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        baglanti.Close();
                        return;
                    }

                    int ogretmenNo = Convert.ToInt32(ogretmenNoObj);

                   
                    SqlCommand guncelle = new SqlCommand("UPDATE Dersler SET dersAdi = @ad, ogretmenNo = @ogretmen WHERE dersNo = @no", baglanti);
                    guncelle.Parameters.AddWithValue("@ad", txtDers.Text);
                    guncelle.Parameters.AddWithValue("@ogretmen", ogretmenNo);
                    guncelle.Parameters.AddWithValue("@no", txtDersNo.Text);
                    guncelle.ExecuteNonQuery();
                    Listele();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult cevap = MessageBox.Show("Bu dersi tamamen silmek istediğinizden emin misiniz? (Bu derse ait tüm notlar da silinebilir!)", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }

                  
                    komutsatiri = "DELETE FROM Dersler WHERE dersNo = @dersNo";

                    komut = new SqlCommand(komutsatiri, baglanti);

                    komut.Parameters.AddWithValue("@dersNo", txtDersNo.Text);

                    
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Ders Başarıyla Silindi!");

                   
                    Listele();

                   
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("Hata Oluştu: Bu ders başka tablolarda (Notlar vb.) kullanıldığı için silinemiyor olabilir.\n\nDetay: " + ex.Message);
            }
        }

        private void txtDersAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txtDersAra.Text.Trim();

            komutsatiri = "SELECT * FROM Dersler WHERE dersAdi LIKE @kelime";
            komut = new SqlCommand(komutsatiri, baglanti);

            komut.Parameters.AddWithValue("@kelime", "%" + aramaKelimesi + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataDers.DataSource = dt;
        }

        private void dataDers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersNo.Text = dataDers.CurrentRow.Cells[0].Value.ToString();
            txtDers.Text = dataDers.CurrentRow.Cells[1].Value.ToString();
            cbOgretmen.Text = dataDers.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDers.Text = "";
            txtDersNo.Text = "";
            cbOgretmen.Text = "";
        }
    }
}
