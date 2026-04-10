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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Icon = new Icon("unnamed.ico");
        }

        private void btnogrenci_Click(object sender, EventArgs e)
        {
            ogrenciGiris ogr=new ogrenciGiris();
            ogr.Show();
            this.Hide();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            ogretmenGiris ogretmen= new ogretmenGiris();
            ogretmen.Show();
            this.Hide();
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("Icon.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mudurMenu menu=new mudurMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mudurMenu mm=new mudurMenu();
            mm.Show();
            this.Hide();    
        }
    }
}
