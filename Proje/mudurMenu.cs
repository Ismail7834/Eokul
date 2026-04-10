using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class mudurMenu : Form
    {
        public mudurMenu()
        {
            InitializeComponent();
        }
       
        private void mudurMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mudurMenu_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
        }

        private void OgretmenGeri_Click(object sender, EventArgs e)
        {
            ogretmenGiris giris = new ogretmenGiris();
            giris.Show();
            this.Hide();
        }

        private void AnasayfaGeri_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            mudurOgrenci ogrenci = new mudurOgrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            mudurOgretmen ogretmen = new mudurOgretmen();
            ogretmen.Show();
            this.Hide();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            mudurDers ders = new mudurDers();
            ders.Show();
            this.Hide();
        }

        private void btnDersProgrami_Click(object sender, EventArgs e)
        {
            mudurDersProgrami program = new mudurDersProgrami();
            program.Show();
            this.Hide();
        }

    

        private void btnSinif_Click(object sender, EventArgs e)
        {
            mudurSinif sinif = new mudurSinif();
            sinif.Show();
            this.Hide();
        }

        private void btnKlub_Click(object sender, EventArgs e)
        {
            mudurKlub klub=new mudurKlub();
            klub.Show();
            this.Hide();
        }
    }
}
