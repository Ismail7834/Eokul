namespace Proje
{
    partial class mudurDersProgrami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mudurDersProgrami));
            this.dataDersProgram = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProgramAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDersProgram)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDersProgram
            // 
            this.dataDersProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDersProgram.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataDersProgram.Location = new System.Drawing.Point(401, 0);
            this.dataDersProgram.Name = "dataDersProgram";
            this.dataDersProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDersProgram.Size = new System.Drawing.Size(400, 452);
            this.dataDersProgram.TabIndex = 2;
            this.dataDersProgram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDersProgram_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSinif);
            this.groupBox1.Controls.Add(this.txtGun);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtSaat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDersAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProgram);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 306);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Programı İşlemleri";
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(129, 264);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(121, 24);
            this.txtSinif.TabIndex = 37;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(129, 231);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(121, 24);
            this.txtGun.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Sil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Güncelle ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Ekle";
            // 
            // btnSil
            // 
            this.btnSil.AllowDrop = true;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(289, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 70);
            this.btnSil.TabIndex = 31;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AllowDrop = true;
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(170, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 70);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.AllowDrop = true;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(41, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 70);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSaat
            // 
            this.txtSaat.Location = new System.Drawing.Point(129, 198);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(121, 24);
            this.txtSaat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Program No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sınıf :";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(129, 163);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(121, 24);
            this.txtDersAd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Saati :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gün :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dersin Adı :";
            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(129, 132);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(121, 24);
            this.txtProgram.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Temizle";
            // 
            // btnTemizle
            // 
            this.btnTemizle.AllowDrop = true;
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Location = new System.Drawing.Point(289, 168);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 50);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProgramAra);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ders Programı Ara";
            // 
            // txtProgramAra
            // 
            this.txtProgramAra.Location = new System.Drawing.Point(170, 42);
            this.txtProgramAra.Name = "txtProgramAra";
            this.txtProgramAra.Size = new System.Drawing.Size(151, 24);
            this.txtProgramAra.TabIndex = 36;
            this.txtProgramAra.TextChanged += new System.EventHandler(this.txtProgramAra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Program No :";
            // 
            // Geri
            // 
            this.Geri.AllowDrop = true;
            this.Geri.BackColor = System.Drawing.Color.Transparent;
            this.Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Geri.BackgroundImage")));
            this.Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.FlatAppearance.BorderSize = 0;
            this.Geri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri.Location = new System.Drawing.Point(12, 0);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 19;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // mudurDersProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataDersProgram);
            this.Name = "mudurDersProgrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mudurDersProgrami_FormClosed);
            this.Load += new System.EventHandler(this.mudurDersProgrami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDersProgram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDersProgram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtProgramAra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtGun;
    }
}