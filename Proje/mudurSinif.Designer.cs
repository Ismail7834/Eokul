namespace Proje
{
    partial class mudurSinif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mudurSinif));
            this.dataSinif = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSinifNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.mtbSinifSubesi = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSinifSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSinifGuncelle = new System.Windows.Forms.Button();
            this.btnSinifEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSinifAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cbSinifNumara = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSinif)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSinif
            // 
            this.dataSinif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSinif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSinif.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataSinif.Location = new System.Drawing.Point(415, 1);
            this.dataSinif.Name = "dataSinif";
            this.dataSinif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSinif.Size = new System.Drawing.Size(269, 459);
            this.dataSinif.TabIndex = 3;
            this.dataSinif.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSinif_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sınıf No :";
            // 
            // txtSinifNo
            // 
            this.txtSinifNo.Enabled = false;
            this.txtSinifNo.Location = new System.Drawing.Point(154, 42);
            this.txtSinifNo.Name = "txtSinifNo";
            this.txtSinifNo.Size = new System.Drawing.Size(120, 24);
            this.txtSinifNo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSinifNumara);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.mtbSinifSubesi);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSinifSil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSinifGuncelle);
            this.groupBox1.Controls.Add(this.btnSinifEkle);
            this.groupBox1.Controls.Add(this.txtSinifNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Ekleme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Temizle";
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(303, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 68;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(299, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 19);
            this.label23.TabIndex = 67;
            this.label23.Text = "Sil";
            // 
            // mtbSinifSubesi
            // 
            this.mtbSinifSubesi.Location = new System.Drawing.Point(154, 116);
            this.mtbSinifSubesi.Mask = "A";
            this.mtbSinifSubesi.Name = "mtbSinifSubesi";
            this.mtbSinifSubesi.Size = new System.Drawing.Size(120, 24);
            this.mtbSinifSubesi.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(160, 272);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 19);
            this.label22.TabIndex = 66;
            this.label22.Text = "Güncelle";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(33, 272);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 19);
            this.label20.TabIndex = 65;
            this.label20.Text = "Sınıf Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınıf Şubesi :";
            // 
            // btnSinifSil
            // 
            this.btnSinifSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSinifSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSinifSil.BackgroundImage")));
            this.btnSinifSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinifSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinifSil.FlatAppearance.BorderSize = 0;
            this.btnSinifSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSinifSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSinifSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifSil.Location = new System.Drawing.Point(276, 187);
            this.btnSinifSil.Name = "btnSinifSil";
            this.btnSinifSil.Size = new System.Drawing.Size(80, 80);
            this.btnSinifSil.TabIndex = 62;
            this.btnSinifSil.UseVisualStyleBackColor = false;
            this.btnSinifSil.Click += new System.EventHandler(this.btnSinifSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınıf Numarası :";
            // 
            // btnSinifGuncelle
            // 
            this.btnSinifGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnSinifGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSinifGuncelle.BackgroundImage")));
            this.btnSinifGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinifGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinifGuncelle.FlatAppearance.BorderSize = 0;
            this.btnSinifGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSinifGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSinifGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifGuncelle.Location = new System.Drawing.Point(154, 187);
            this.btnSinifGuncelle.Name = "btnSinifGuncelle";
            this.btnSinifGuncelle.Size = new System.Drawing.Size(80, 80);
            this.btnSinifGuncelle.TabIndex = 63;
            this.btnSinifGuncelle.UseVisualStyleBackColor = false;
            this.btnSinifGuncelle.Click += new System.EventHandler(this.btnSinifGuncelle_Click);
            // 
            // btnSinifEkle
            // 
            this.btnSinifEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSinifEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSinifEkle.BackgroundImage")));
            this.btnSinifEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinifEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinifEkle.FlatAppearance.BorderSize = 0;
            this.btnSinifEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSinifEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSinifEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinifEkle.Location = new System.Drawing.Point(22, 187);
            this.btnSinifEkle.Name = "btnSinifEkle";
            this.btnSinifEkle.Size = new System.Drawing.Size(80, 80);
            this.btnSinifEkle.TabIndex = 64;
            this.btnSinifEkle.UseVisualStyleBackColor = false;
            this.btnSinifEkle.Click += new System.EventHandler(this.btnSinifEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSinifAra);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınıf Arama";
            // 
            // txtSinifAra
            // 
            this.txtSinifAra.Location = new System.Drawing.Point(164, 39);
            this.txtSinifAra.Name = "txtSinifAra";
            this.txtSinifAra.Size = new System.Drawing.Size(125, 24);
            this.txtSinifAra.TabIndex = 1;
            this.txtSinifAra.TextChanged += new System.EventHandler(this.txtSinifAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Ara :";
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
            this.btnGeri.Location = new System.Drawing.Point(12, 1);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(50, 50);
            this.btnGeri.TabIndex = 58;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cbSinifNumara
            // 
            this.cbSinifNumara.FormattingEnabled = true;
            this.cbSinifNumara.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.cbSinifNumara.Location = new System.Drawing.Point(154, 76);
            this.cbSinifNumara.Name = "cbSinifNumara";
            this.cbSinifNumara.Size = new System.Drawing.Size(121, 27);
            this.cbSinifNumara.TabIndex = 70;
            // 
            // mudurSinif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataSinif);
            this.Controls.Add(this.groupBox1);
            this.Name = "mudurSinif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınıf İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mudurSinif_FormClosed);
            this.Load += new System.EventHandler(this.mudurSinif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSinif)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataSinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSinifNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbSinifSubesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSinifAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSinifSil;
        private System.Windows.Forms.Button btnSinifGuncelle;
        private System.Windows.Forms.Button btnSinifEkle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSinifNumara;
    }
}