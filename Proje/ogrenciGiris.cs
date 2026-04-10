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
    public partial class ogrenciGiris : Form
    {
        veriTabaniIslemleri vt=new veriTabaniIslemleri();
        SqlConnection baglanti;
        public ogrenciGiris()
        {
            InitializeComponent();
        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
            ogrenciTc.Mask = "00000000000";

        }

        private void Geri1_Click(object sender, EventArgs e)
        {
            Giris gr=new Giris();
            this.Hide();
            gr.Show();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            baglanti= vt.baglan();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM Ogrenciler WHERE ogrenciTc = @tc AND ogrenciNo = @no", baglanti);
            komut.Parameters.AddWithValue("@tc", ogrenciTc.Text);
            komut.Parameters.AddWithValue("@no", ogrenciNo.Text);
            if ((int)komut.ExecuteScalar() > 0)
            {
                ogrenciMenu panel = new ogrenciMenu();
                panel.ogrenciTc = ogrenciTc.Text;
                panel.ogrenciNo= ogrenciNo.Text;
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Numara yanlış!");
            }
            baglanti.Close();
        }

        private void ogrenciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
