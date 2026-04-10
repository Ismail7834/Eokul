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
    public partial class ogretmenGiris : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogretmenGiris()
        {
            InitializeComponent();
        }
      
        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            baglanti = vt.baglan();
            baglanti.Open();

            string tc = ogretmenTc.Text.Trim();
            string parola = ogretmenSifre.Text.Trim();

            SqlCommand komut = new SqlCommand(@"
SELECT * FROM Ogretmenler 
WHERE ogretmenTC = @tc AND sifre = @parola", baglanti);

            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@parola", parola);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                string brans = dr["ogretmenBrans"].ToString();

                if (brans == "Müdür")
                {

                    mudurMenu mudur = new mudurMenu();
                    mudur.Show();
                }
                else
                {
                    ogretmenMenu ogretmen = new ogretmenMenu();
                    ogretmen.ogretmenTc = ogretmenTc.Text;
                    ogretmen.sifre = ogretmenSifre.Text;
                    ogretmen.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya parola hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            baglanti.Close();
        }

        private void Geri2_Click(object sender, EventArgs e)
        {
            Giris gr = new Giris();
            gr.Show();
            this.Hide();
            
                    
        }

        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            ogretmenTc.Mask = "00000000000";
            this.Icon = new Icon("Icon.ico");
        }

        private void ogretmenGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
