namespace Proje
{
    partial class Duyurular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Duyurular));
            this.rtbDuyuru = new System.Windows.Forms.RichTextBox();
            this.lbDuyuru = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaslık = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOgrenci = new System.Windows.Forms.CheckBox();
            this.cbOgretmen = new System.Windows.Forms.CheckBox();
            this.gbDuyuruIslemler = new System.Windows.Forms.GroupBox();
            this.gbDuyuruIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDuyuru
            // 
            this.rtbDuyuru.Enabled = false;
            this.rtbDuyuru.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbDuyuru.Location = new System.Drawing.Point(161, 106);
            this.rtbDuyuru.Name = "rtbDuyuru";
            this.rtbDuyuru.Size = new System.Drawing.Size(627, 290);
            this.rtbDuyuru.TabIndex = 0;
            this.rtbDuyuru.Text = "";
            // 
            // lbDuyuru
            // 
            this.lbDuyuru.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDuyuru.FormattingEnabled = true;
            this.lbDuyuru.ItemHeight = 22;
            this.lbDuyuru.Location = new System.Drawing.Point(12, 106);
            this.lbDuyuru.Name = "lbDuyuru";
            this.lbDuyuru.Size = new System.Drawing.Size(143, 290);
            this.lbDuyuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(295, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(446, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "-----";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(72, 64);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(15, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(72, 64);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(93, 17);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(72, 64);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(171, 19);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(72, 64);
            this.btnSil.TabIndex = 12;
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alıcılar :";
            // 
            // txtBaslık
            // 
            this.txtBaslık.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBaslık.Location = new System.Drawing.Point(346, 53);
            this.txtBaslık.Name = "txtBaslık";
            this.txtBaslık.Size = new System.Drawing.Size(168, 28);
            this.txtBaslık.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(272, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Başlık :";
            // 
            // cbOgrenci
            // 
            this.cbOgrenci.AutoSize = true;
            this.cbOgrenci.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgrenci.Location = new System.Drawing.Point(512, 19);
            this.cbOgrenci.Name = "cbOgrenci";
            this.cbOgrenci.Size = new System.Drawing.Size(113, 26);
            this.cbOgrenci.TabIndex = 17;
            this.cbOgrenci.Text = "Öğrenciler";
            this.cbOgrenci.UseVisualStyleBackColor = true;
            // 
            // cbOgretmen
            // 
            this.cbOgretmen.AutoSize = true;
            this.cbOgretmen.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgretmen.Location = new System.Drawing.Point(346, 19);
            this.cbOgretmen.Name = "cbOgretmen";
            this.cbOgretmen.Size = new System.Drawing.Size(132, 26);
            this.cbOgretmen.TabIndex = 18;
            this.cbOgretmen.Text = "Öğretmenler";
            this.cbOgretmen.UseVisualStyleBackColor = true;
            this.cbOgretmen.Visible = false;
            // 
            // gbDuyuruIslemler
            // 
            this.gbDuyuruIslemler.Controls.Add(this.btnGuncelle);
            this.gbDuyuruIslemler.Controls.Add(this.cbOgretmen);
            this.gbDuyuruIslemler.Controls.Add(this.btnEkle);
            this.gbDuyuruIslemler.Controls.Add(this.cbOgrenci);
            this.gbDuyuruIslemler.Controls.Add(this.btnSil);
            this.gbDuyuruIslemler.Controls.Add(this.label4);
            this.gbDuyuruIslemler.Controls.Add(this.label3);
            this.gbDuyuruIslemler.Controls.Add(this.txtBaslık);
            this.gbDuyuruIslemler.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDuyuruIslemler.Location = new System.Drawing.Point(110, 12);
            this.gbDuyuruIslemler.Name = "gbDuyuruIslemler";
            this.gbDuyuruIslemler.Size = new System.Drawing.Size(678, 88);
            this.gbDuyuruIslemler.TabIndex = 19;
            this.gbDuyuruIslemler.TabStop = false;
            this.gbDuyuruIslemler.Text = "İşlemler";
            this.gbDuyuruIslemler.Visible = false;
            // 
            // Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.gbDuyuruIslemler);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDuyuru);
            this.Controls.Add(this.rtbDuyuru);
            this.Name = "Duyurular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyurular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Duyurular_FormClosed);
            this.Load += new System.EventHandler(this.Duyurular_Load);
            this.gbDuyuruIslemler.ResumeLayout(false);
            this.gbDuyuruIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDuyuru;
        private System.Windows.Forms.ListBox lbDuyuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaslık;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbOgrenci;
        private System.Windows.Forms.CheckBox cbOgretmen;
        private System.Windows.Forms.GroupBox gbDuyuruIslemler;
    }
}