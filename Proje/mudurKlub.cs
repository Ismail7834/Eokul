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
    public partial class mudurKlub : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        SqlCommand komut;
        string komutsatiri;
        public mudurKlub()
        {
            InitializeComponent();
        }

        private void mudurKlub_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            dataKlub.AutoResizeRows();
            Listele();
        }
        public void Listele()
        {
            baglanti = vt.baglan();
            string komutSatiri = 
            @"
            SELECT 
            klubID,
            klubAdi
            FROM Klubler ";

            SqlDataAdapter da = new SqlDataAdapter(komutSatiri, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataKlub.DataSource = dt;

            
            dataKlub.Columns["klubID"].HeaderText = "Kulüp No";
            dataKlub.Columns["klubAdi"].HeaderText = "Kulüp Adı";
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            mudurMenu menu=new mudurMenu();
            menu.Show();
            this.Hide();
        }

        private void btnKlubEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Kaydetmek İstediğinize Eminmisiniz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    if (string.IsNullOrEmpty(txtKlubAdi.Text))
                    {
                        MessageBox.Show("Klub Adı Boş Bırakılamaz!");
                    }
                    string komut = "INSERT INTO Klubler (klubAdi) VALUES (@adi)";
                    SqlCommand cmd = new SqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@adi", txtKlubAdi.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kulüp eklendi.");
                    Listele();
                    baglanti.Close();

                }
            }catch (Exception ex) 
            {
                MessageBox.Show("Hata Oluştu: ", ex.Message);
            }
        }

        private void dataKlub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKlubAdi.Text = dataKlub.CurrentRow.Cells["klubAdi"].Value.ToString();
            txtKlubNo.Text = dataKlub.CurrentRow.Cells["klubID"].Value.ToString();
        }

        private void txtKlubAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKelimesi = txtKlubAra.Text.Trim();

            komutsatiri = "SELECT * FROM Klubler WHERE klubAdi LIKE @kelime";
            komut = new SqlCommand(komutsatiri, baglanti);

            komut.Parameters.AddWithValue("@kelime", "%" + aramaKelimesi + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataKlub.DataSource = dt;
        }

        private void btnKlubGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Güncellemek İstiyor musunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if(baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    komutsatiri = "UPDATE Klubler SET klubAdi=@klubAdi WHERE klubID=@klubID";
                    komut = new SqlCommand(komutsatiri,baglanti);
                    komut.Parameters.AddWithValue("@klubAdi",txtKlubAdi.Text);
                    komut.Parameters.AddWithValue("@klubID",txtKlubNo.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("İşlem Başarıyla Gerçekleştirildi");
                    Listele();
                    baglanti.Close();
                }
            }
            catch(Exception ex)
            {  
                MessageBox.Show("Hata Oluştu: ",ex.Message);
            }
        }

        private void btnKlubSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap = MessageBox.Show("Silmek İstiyormusunuz ?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    
                    komutsatiri = "DELETE FROM Klubler WHERE klubID = @klubID";
                    komut = new SqlCommand(komutsatiri, baglanti);
                    komut.Parameters.AddWithValue("@klubID", txtKlubNo.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi Başarıyla Gerçekleştirildi!");
                    Listele();

                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: ", ex.Message);
            }
        }

        private void mudurKlub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKlubNo.Clear();
            txtKlubAdi.Clear();
        }
    }
}
