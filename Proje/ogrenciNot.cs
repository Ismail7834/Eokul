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
    public partial class ogrenciNot : Form
    {
        veriTabaniIslemleri vt =new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogrenciNot()
        {
            InitializeComponent();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            ogrenciMenu menu = new ogrenciMenu(ogrenciNo,ogrenciTc);
            menu.Show();
            this.Hide();
        }

        private void ogrenciNot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public string ogrenciTc;
        public string ogrenciNo;

        private void ogrenciNot_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            baglanti = vt.baglan();
            baglanti.Open();
        }

        private void NotlariYukle(int donemNo)
        {
            try
            {
                baglanti = vt.baglan();
                baglanti.Open();

                string komutsatiri =
                @"SELECT 
            d.dersAdi AS [Ders],
            n.not1 AS [1. Yazılı],
            n.not2 AS [2. Yazılı],
            n.sozlu1 AS [1. Sözlü],
            n.sozlu2 AS [2. Sözlü],
            n.performansOdevi AS [Performans],
            n.ortalama AS [Ortalama]
        FROM Notlar n
        INNER JOIN Dersler d ON n.dersNo = d.dersNo
        WHERE n.ogrenciNo = @ogrenciNo AND n.donemNo = @donemNo";

                SqlCommand komut = new SqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);
                komut.Parameters.AddWithValue("@donemNo", donemNo);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataOgrenciNot.DataSource = dt;

                double genelToplam = 0;  // Genel toplam notları
                int genelSayac = 0;      // Genel sayac

                foreach (DataRow row in dt.Rows)
                {
                    double dersToplam = 0; // Her dersin toplamı
                    int dersSayac = 0;     // Her dersin not sayısı

                    // Notları tek tek kontrol et ve geçerli notları al
                    if (row["1. Yazılı"] != DBNull.Value && Convert.ToDouble(row["1. Yazılı"]) != 0)
                    {
                        dersToplam += Convert.ToDouble(row["1. Yazılı"]);
                        dersSayac++;
                    }
                    if (row["2. Yazılı"] != DBNull.Value && Convert.ToDouble(row["2. Yazılı"]) != 0)
                    {
                        dersToplam += Convert.ToDouble(row["2. Yazılı"]);
                        dersSayac++;
                    }
                    if (row["Performans"] != DBNull.Value && Convert.ToDouble(row["Performans"]) != 0)
                    {
                        dersToplam += Convert.ToDouble(row["Performans"]);
                        dersSayac++;
                    }
                    if (row["1. Sözlü"] != DBNull.Value && Convert.ToDouble(row["1. Sözlü"]) != 0)
                    {
                        dersToplam += Convert.ToDouble(row["1. Sözlü"]);
                        dersSayac++;
                    }
                    if (row["2. Sözlü"] != DBNull.Value && Convert.ToDouble(row["2. Sözlü"]) != 0)
                    {
                        dersToplam += Convert.ToDouble(row["2. Sözlü"]);
                        dersSayac++;
                    }

                    double dersOrtalama = 0;
                    if (dersSayac > 0)
                    {
                        dersOrtalama = dersToplam / dersSayac;
                        row["Ortalama"] = dersOrtalama;

                        genelToplam += dersOrtalama;
                        genelSayac++;
                    }
                }

                if (genelSayac > 0)
                {
                    double genelOrtalama = genelToplam / genelSayac;
                    lblDonemOrt.Text = genelOrtalama.ToString("0.00"); // Ortalamayı iki ondalıklı göster
                }
                else
                {
                    lblDonemOrt.Text = "---";
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnDonem1_Click(object sender, EventArgs e)
        {
            NotlariYukle(1);
        }

        private void btnDonem2_Click(object sender, EventArgs e)
        {
            NotlariYukle(2);
        }
    }
}
