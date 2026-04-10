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
    public partial class ogretmenBilgileri : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogretmenBilgileri()
        {
            InitializeComponent();
        }
        public string ogretmenTc;
        public string sifre;
        private void ogretmenBilgileri_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            baglanti = vt.baglan();
            baglanti.Open();

            SqlCommand komut = new SqlCommand(@"
        SELECT 
            o.ogretmenAd,
            o.ogretmenSoyad,
            o.ogretmenTelefon,
            o.ogretmenEmail,
            o.dogumTarihi,
            o.ogretmenAdres,
            o.ogretmenBrans,
            k.klubAdi,
            o.ogretmenFoto
        FROM Ogretmenler o
        LEFT JOIN Klubler k ON o.klubID = k.klubID
        WHERE o.ogretmenTC = @tc", baglanti);

            komut.Parameters.AddWithValue("@tc", ogretmenTc);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblAd.Text = dr["ogretmenAd"].ToString();
                lblSoyad.Text = dr["ogretmenSoyad"].ToString();
                lblTelefon.Text = dr["ogretmenTelefon"].ToString();
                lblEmail.Text = dr["ogretmenEmail"].ToString();
                lblDogum.Text = Convert.ToDateTime(dr["dogumTarihi"]).ToShortDateString();
                rtbAdres.Text = dr["ogretmenAdres"].ToString();
                lblBrans.Text = dr["ogretmenBrans"].ToString();
                lblKlub.Text = dr["klubAdi"].ToString();

                if (dr["ogretmenFoto"] != DBNull.Value)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])dr["ogretmenFoto"];
                    MemoryStream ms = new MemoryStream(resim);
                    pbOgretmen.Image = Image.FromStream(ms);
                    pbOgretmen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            dr.Close();
            baglanti.Close();
        }

        private void ogretmenBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            ogretmenMenu om=new ogretmenMenu(ogretmenTc,sifre);
            om.Show();
            this.Hide();
        }
    }
}
