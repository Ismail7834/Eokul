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
    public partial class ogrenciMenu : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogrenciMenu()
        {
            InitializeComponent();
        }
        public string ogrenciTc;
        public string ogrenciNo;
        public ogrenciMenu(string no,string tc)
        {
            InitializeComponent();
            ogrenciNo = no;
            ogrenciTc = tc;
        }

        private void OgrenciGeri_Click(object sender, EventArgs e)
        {
            ogrenciGiris ogrenci=new ogrenciGiris();
            ogrenci.Show();
            this.Hide();
        }

        private void AnasayfaGeri_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            ogrenciNot not = new ogrenciNot();
            not.ogrenciTc = ogrenciTc;
            not.ogrenciNo= ogrenciNo;
            not.Show();
            this.Hide();
        }

 
        
        private void ogrenciMenu_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            baglanti = vt.baglan();
            baglanti.Open();
            SqlCommand ogrenci = new SqlCommand(@"
        SELECT 
            o.ogrenciAd, 
            o.ogrenciSoyad,
            o.ogrenciNo,
            o.ogrenciFoto,
            s.sinifAdi, 
            k.klubAdi
        FROM Ogrenciler o
        LEFT JOIN Siniflar s ON o.sinifID = s.sinifID
        LEFT JOIN Klubler k ON o.klubID = k.klubID
        WHERE o.ogrenciNo = @no", baglanti);

            ogrenci.Parameters.AddWithValue("@no",ogrenciNo);
            
            SqlDataReader dr = ogrenci.ExecuteReader();
            if (dr.Read())
            {
                
                lblNo.Text = dr["ogrenciNo"].ToString();
                lblIsim.Text = dr["ogrenciAd"] + " " + dr["ogrenciSoyad"];
                lblSinif.Text = dr["sinifAdi"].ToString(); ;
                lblKlub.Text = dr["klubAdi"].ToString();
                if (dr["ogrenciFoto"] != DBNull.Value)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["ogrenciFoto"];
                    MemoryStream ms = new MemoryStream(resim);
                    pbOgrenci.Image = Image.FromStream(ms);
                    pbOgrenci.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            dr.Close();
            SqlCommand devamsizlik = new SqlCommand(@"
                    SELECT ozurluDevamsizlik, ozursuzDevamsizlik
                    FROM Devamsizlik
                    WHERE ogrenciNo = @no", baglanti);
            devamsizlik.Parameters.AddWithValue("@no", ogrenciNo);
            SqlDataReader drDevam = devamsizlik.ExecuteReader();
            if (drDevam.Read())
            {
                lblOzurlu.Text = drDevam["ozurluDevamsizlik"].ToString();
                lblOzursuz.Text = drDevam["ozursuzDevamsizlik"].ToString();
            }
            drDevam.Close();
            baglanti.Close();
        }

        private void ogrenciMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            ogrenciDersProgrami ders=new ogrenciDersProgrami();
            ders.ogrenciTc=ogrenciTc;
            ders.ogrenciNo = ogrenciNo;
            ders.Show();
            this.Hide();
        }
    }
}
