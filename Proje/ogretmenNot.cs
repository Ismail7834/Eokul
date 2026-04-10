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
    public partial class ogretmenNot : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogretmenNot()
        {
            InitializeComponent();
        }

        private void ogretmenNot_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            notListele();
            comboDoldur();
        }
        private void comboDoldur()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();
                SqlDataAdapter daD = new SqlDataAdapter("SELECT dersNo, dersAdi FROM Dersler", baglanti);
                DataTable dtD = new DataTable();
                daD.Fill(dtD);
                cbDers.DataSource = dtD;
                cbDers.DisplayMember = "dersAdi";
                cbDers.ValueMember = "dersNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ogretmenNot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string ogretmenTC;
        public string sifre;
        private void btnGeri_Click(object sender, EventArgs e)
        {
            ogretmenMenu om=new ogretmenMenu(ogretmenTC,sifre);
            om.Show();
            this.Hide();
        }
        private void notListele()
        {
            baglanti = vt.baglan();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();
            }

            string komutSatiri = "SELECT o.ogrenciNo, o.ogrenciAd, " +
                     "n.not1, n.not2, n.sozlu1, n.sozlu2, n.performansOdevi, n.donemNo, d.dersAdi, d.dersNo " +
                     "FROM Ogrenciler o " +
                     "LEFT JOIN Notlar n ON o.ogrenciNo = n.ogrenciNo " +
                     "LEFT JOIN Dersler d ON n.dersNo = d.dersNo";

            SqlCommand komut = new SqlCommand(komutSatiri, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataOgretmenNot.DataSource = dt;

            dataOgretmenNot.Columns["ogrenciNo"].HeaderText = "Öğrenci No";
            dataOgretmenNot.Columns["ogrenciAd"].HeaderText = "Adı";
            dataOgretmenNot.Columns["not1"].HeaderText = "Not 1";
            dataOgretmenNot.Columns["not2"].HeaderText = "Not 2";
            dataOgretmenNot.Columns["sozlu1"].HeaderText = "Sözlü 1";
            dataOgretmenNot.Columns["sozlu2"].HeaderText = "Sözlü 2";
            dataOgretmenNot.Columns["performansOdevi"].HeaderText = "Performans";
            dataOgretmenNot.Columns["donemNo"].HeaderText = "Dönem";
            dataOgretmenNot.Columns["dersAdi"].HeaderText = "Ders Adı";
            dataOgretmenNot.Columns["dersNo"].Visible = false;

        }
        private void dataOgretmenNot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciNo.Text = dataOgretmenNot.CurrentRow.Cells["ogrenciNo"].Value.ToString();
            cbDers.Text = dataOgretmenNot.CurrentRow.Cells["dersAdi"].Value.ToString();
            txtNot1.Text = dataOgretmenNot.CurrentRow.Cells["not1"].Value.ToString();
            txtNot2.Text = dataOgretmenNot.CurrentRow.Cells["not2"].Value.ToString();
            txtSozlu1.Text = dataOgretmenNot.CurrentRow.Cells["sozlu1"].Value.ToString();
            txtSozlu2.Text = dataOgretmenNot.CurrentRow.Cells["sozlu2"].Value.ToString();
            txtPerformans.Text = dataOgretmenNot.CurrentRow.Cells["performansOdevi"].Value.ToString();
            cbDonem.Text = dataOgretmenNot.CurrentRow.Cells["donemNo"].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtOgrenciNo.Text) || string.IsNullOrEmpty(cbDers.Text))
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
                dersBul.Parameters.AddWithValue("@dAd", cbDers.Text.Trim());
                object dersObj = dersBul.ExecuteScalar();
                if (dersObj == null) { MessageBox.Show("Ders bulunamadı!"); return; }
                int dersID = Convert.ToInt32(dersObj);

                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM Notlar WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn", baglanti);
                kontrol.Parameters.AddWithValue("@o", txtOgrenciNo.Text);
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
                cmd.Parameters.AddWithValue("@o", txtOgrenciNo.Text);
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

        private void txtSinifAra_TextChanged(object sender, EventArgs e)
        {
            string aranan=txtOgrenciAra.Text;
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
            dataOgretmenNot.DataSource = dtNot;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle(this);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

              
                SqlCommand dersBul = new SqlCommand("SELECT dersNo FROM Dersler WHERE dersAdi = @dAd", baglanti);
                dersBul.Parameters.AddWithValue("@dAd", cbDers.Text.Trim());
                object dersObj = dersBul.ExecuteScalar();
                if (dersObj == null) return;
                int dersID = Convert.ToInt32(dersObj);

               
                string sql = @"UPDATE Notlar SET 
                        not1=@n1, not2=@n2, sozlu1=@s1, sozlu2=@s2, performansOdevi=@po 
                      WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn";

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.AddWithValue("@o", txtOgrenciNo.Text);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciNo.Text))
            {
                MessageBox.Show("Lütfen silinecek dersi ve öğrenciyi seçin!"); return;
            }

            DialogResult sor = MessageBox.Show("Bu ders kaydı tamamen silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open) baglanti.Open();

                    
                    int dersID = Convert.ToInt32(cbDers.SelectedValue);

                    string sql = "DELETE FROM Notlar WHERE ogrenciNo=@o AND dersNo=@d AND donemNo=@dn";
                    SqlCommand cmd = new SqlCommand(sql, baglanti);
                    cmd.Parameters.AddWithValue("@o", txtOgrenciNo.Text);
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
    }
}
