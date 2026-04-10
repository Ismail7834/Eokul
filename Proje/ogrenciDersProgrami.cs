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
    public partial class ogrenciDersProgrami : Form
    {
        veriTabaniIslemleri vt = new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogrenciDersProgrami()
        {
            InitializeComponent();
        }
        public string ogrenciTc;
        public string ogrenciNo;
        private void NotGeri1_Click(object sender, EventArgs e)
        {
            ogrenciMenu ogrmenu = new ogrenciMenu(ogrenciNo,ogrenciTc);
            ogrmenu.Show();
            this.Hide();
        }

        private void ogrenciDersProgrami_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ogrenciDersProgrami_Load(object sender, EventArgs e)
        {
            
            this.Icon = new Icon("Icon.ico");
            try
            {
                baglanti = vt.baglan();
                baglanti.Open();
                SqlCommand cmdSinif = new SqlCommand("SELECT sinifID FROM Ogrenciler WHERE ogrenciTC = @tc", baglanti);
                cmdSinif.Parameters.AddWithValue("@tc", ogrenciTc); 
                object sinifIDObj = cmdSinif.ExecuteScalar();

                if (sinifIDObj != null)
                {
                    int sinifID = Convert.ToInt32(sinifIDObj);

                    string query = @"
                SELECT 
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

                    SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@sinifID", sinifID);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataOgrenciDers.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("öğretmene  ait sınıf bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu: " + ex.Message);
            }
        }
    }
}
        
    
