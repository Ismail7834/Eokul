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
    public partial class ogretmenDersProgrami : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogretmenDersProgrami()
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

        private void ogretmenDersProgrami_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            try
            {
                baglanti = vt.baglan();
                baglanti.Open();
                SqlCommand cmdSinif = new SqlCommand("SELECT sinifID FROM Ogretmenler WHERE ogretmenTC = @tc", baglanti);
                cmdSinif.Parameters.AddWithValue("@tc", ogretmenTc); 
                object sinifIDObj = cmdSinif.ExecuteScalar();

                if (sinifIDObj != null)
                {
                    int sinifID = Convert.ToInt32(sinifIDObj);

                    string komutsatiri = 
@"SELECT 
dp.gun AS [Gün], 
dp.dersSaati AS [Saat], 
d.dersAdi AS [Ders],
o.ogretmenAd + ' ' + o.ogretmenSoyad AS [Öğretmen]
FROM Ders_Programi dp
LEFT JOIN Dersler d ON dp.dersNo = d.dersNo
LEFT JOIN Ogretmenler o ON d.ogretmenNo = o.ogretmenNo
WHERE dp.sinifID = @sinifID
ORDER BY 
CASE 
WHEN dp.gun = 'Pazartesi' THEN 1
WHEN dp.gun = 'Salı' THEN 2
WHEN dp.gun = 'Çarşamba' THEN 3
WHEN dp.gun = 'Perşembe' THEN 4
WHEN dp.gun = 'Cuma' THEN 5
ELSE 6
END,
dp.dersSaati";
                    SqlDataAdapter da = new SqlDataAdapter(komutsatiri,baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@sinifID", sinifID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataOgretmenDers.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Öğrenciye ait sınıf bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }

        private void ogretmenDersProgrami_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
