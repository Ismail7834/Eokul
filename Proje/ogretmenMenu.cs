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
    public partial class ogretmenMenu : Form
    {
        public ogretmenMenu()
        {
            InitializeComponent();
        }
        public ogretmenMenu(string tc,string parola)
        {
            InitializeComponent();
            ogretmenTc = tc;
            sifre = parola;
            
        }
        public string ogretmenTc;
        public string sifre;
        private void ogretmenMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ogretmenMenu_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            ogretmenNot on = new ogretmenNot();
            on.ogretmenTC = ogretmenTc;
            on.sifre = sifre;
            on.Show();
            this.Hide();
        }

        private void btnParolaDegis_Click(object sender, EventArgs e)
        {
            ogretmenParola parola = new ogretmenParola();
            parola.ogretmenTc = ogretmenTc;
            parola.sifre = sifre;
            parola.Show();
            this.Hide();
        }

  

        private void btnDersProgrami_Click(object sender, EventArgs e)
        {
            ogretmenDersProgrami Dprogram = new ogretmenDersProgrami();
            Dprogram.ogretmenTc = ogretmenTc;
            Dprogram.sifre = sifre;
            Dprogram.Show();
            this.Hide();
        }

        private void btnBilgilerim_Click(object sender, EventArgs e)
        {
            ogretmenBilgileri bilgi = new ogretmenBilgileri();
            bilgi.ogretmenTc = ogretmenTc;
            bilgi.sifre = sifre;
            bilgi.Show();
            this.Hide();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Giris gr = new Giris();
            gr.Show();
            this.Hide();
        }

        private void btnOgretmenDegis_Click(object sender, EventArgs e)
        {
            ogretmenGiris og = new ogretmenGiris();
            og.Show();
            this.Hide();
        }
    }
}
