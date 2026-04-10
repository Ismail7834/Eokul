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
    public partial class mudurSinif : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutsatiri;
        public mudurSinif()
        {
            InitializeComponent();
        }

        private void mudurSinif_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mudurSinif_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            dataSinif.AutoResizeRows();
            Listele();
        }
        public void Listele()
        {
            try
            {
                baglanti = vt.baglan();
                komutsatiri = "Select * From Siniflar";
                SqlDataAdapter da = new SqlDataAdapter(komutsatiri, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataSinif.DataSource = dt;
                dataSinif.Columns["sinifID"].HeaderText = "Sınıf No";
                dataSinif.Columns["sinifAdi"].HeaderText = "Sınıf Adı ";
                dataSinif.Columns["sinifSayisi"].Visible = false;
                dataSinif.Columns["sube"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: ", ex.Message);
            }

        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            mudurMenu menu= new mudurMenu(); 
            menu.Show();
            this.Hide();    
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            
            DialogResult cevap= MessageBox.Show("Kayıt yapmak istiyor musunuz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string sinifNo = cbSinifNumara.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(sinifNo))
                    {
                        MessageBox.Show("Lütfen Sınıf Numarasını Seçiniz !");
                        return;
                    }
                    string sube = mtbSinifSubesi.Text.Trim().ToUpper();
                    if (string.IsNullOrEmpty(sube))
                    {
                        MessageBox.Show("Lütfen Şubeyi Giriniz !");
                        return;
                    }
                        string sinifAdi = sinifNo + sube;
                        string komutsatiri = "INSERT INTO Siniflar (sinifSayisi, sube,sinifAdi) VALUES ( @sinifSayisi, @sube,@sinifAdi)";
                        SqlCommand komut = new SqlCommand(komutsatiri, baglanti);
                        komut.Parameters.AddWithValue("@sinifSayisi",sinifNo);
                        komut.Parameters.AddWithValue("@sube", sube);
                        komut.Parameters.AddWithValue("@sinifAdi", sinifAdi);

                   
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Yeni sınıf kaydı başarıyla eklendi!");
                        Listele();
                        cbSinifNumara.SelectedItem = "";
                        mtbSinifSubesi.Clear();
                        baglanti.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu: " + ex.Message);
                }
            }
        }

        private void dataSinif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSinifNo.Text = dataSinif.CurrentRow.Cells["sinifID"].Value.ToString();
            mtbSinifSubesi.Text = dataSinif.CurrentRow.Cells["sube"].Value.ToString();
            cbSinifNumara.Text = dataSinif.CurrentRow.Cells["sinifSayisi"].Value.ToString();
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show(" Sınıfı Silmek İstiyormusunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string sinifNo = cbSinifNumara.SelectedItem?.ToString();
                    string sube = mtbSinifSubesi.Text.Trim().ToUpper();
                    string sinifAdi = sinifNo + sube;
                    komutsatiri = "DELETE FROM Siniflar WHERE sinifID = @sinifID";
                    komut = new SqlCommand(komutsatiri, baglanti);
                    komut.Parameters.AddWithValue("@sinifID", txtSinifNo.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi!");
                    Listele();

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: ",ex.Message);
            }
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Güncellemek İstiyor musunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string sinifID = txtSinifNo.Text;
                    if (string.IsNullOrEmpty(sinifID))
                    {
                        MessageBox.Show("Güncellenecek sınıfı seçiniz !");
                        return;
                    }

                    string sinifNo = cbSinifNumara.SelectedItem?.ToString();
                    string sube = mtbSinifSubesi.Text.Trim().ToUpper();
                    string yeniSinifAdi = sinifNo + sube;
                    komutsatiri = "UPDATE Siniflar SET sinifSayisi = @sinifSayisi, sube = @sube, sinifAdi = @sinifAdi WHERE sinifID = @sinifID";
                    komut = new SqlCommand(komutsatiri, baglanti);
                    komut.Parameters.AddWithValue("@sinifSayisi", sinifNo);
                    komut.Parameters.AddWithValue("@sube", sube);
                    komut.Parameters.AddWithValue("@sinifAdi", yeniSinifAdi);
                    komut.Parameters.AddWithValue("@sinifID", sinifID);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi!");
                    Listele();
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: ", ex.Message);
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSinifAra.Clear();
            txtSinifNo.Clear();
            mtbSinifSubesi.Clear();
            cbSinifNumara.SelectedItem = null;
        }

        private void txtSinifAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txtSinifAra.Text.Trim();

            komutsatiri = "SELECT * FROM Siniflar WHERE sinifAdi LIKE @kelime";
            komut = new SqlCommand(komutsatiri, baglanti);
            
            komut.Parameters.AddWithValue("@kelime", "%" + aramaKelimesi + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataSinif.DataSource = dt; 
        }
    }
}
