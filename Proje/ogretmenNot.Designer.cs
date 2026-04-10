namespace Proje
{
    partial class ogretmenNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenNot));
            this.dataOgretmenNot = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciAra = new System.Windows.Forms.TextBox();
            this.txtPerformans = new System.Windows.Forms.TextBox();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtSozlu1 = new System.Windows.Forms.TextBox();
            this.txtSozlu2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cbDers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgretmenNot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOgretmenNot
            // 
            this.dataOgretmenNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOgretmenNot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOgretmenNot.Location = new System.Drawing.Point(431, -1);
            this.dataOgretmenNot.Name = "dataOgretmenNot";
            this.dataOgretmenNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOgretmenNot.Size = new System.Drawing.Size(553, 551);
            this.dataOgretmenNot.TabIndex = 0;
            this.dataOgretmenNot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOgretmenNot_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtOgrenciNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbDonem);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOgrenciAra);
            this.groupBox1.Controls.Add(this.txtPerformans);
            this.groupBox1.Controls.Add(this.txtNot1);
            this.groupBox1.Controls.Add(this.txtNot2);
            this.groupBox1.Controls.Add(this.txtSozlu1);
            this.groupBox1.Controls.Add(this.txtSozlu2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 499);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ders Adı :";
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(122, 139);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(144, 28);
            this.txtOgrenciNo.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Öğrenci No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Temizle";
            // 
            // cbDonem
            // 
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbDonem.Location = new System.Drawing.Point(122, 406);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(144, 30);
            this.cbDonem.TabIndex = 30;
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
            this.button1.Location = new System.Drawing.Point(330, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Öğrenci Ara :";
            // 
            // txtOgrenciAra
            // 
            this.txtOgrenciAra.Location = new System.Drawing.Point(134, 460);
            this.txtOgrenciAra.Name = "txtOgrenciAra";
            this.txtOgrenciAra.Size = new System.Drawing.Size(137, 28);
            this.txtOgrenciAra.TabIndex = 28;
            this.txtOgrenciAra.TextChanged += new System.EventHandler(this.txtSinifAra_TextChanged);
            // 
            // txtPerformans
            // 
            this.txtPerformans.Location = new System.Drawing.Point(179, 375);
            this.txtPerformans.Name = "txtPerformans";
            this.txtPerformans.Size = new System.Drawing.Size(87, 28);
            this.txtPerformans.TabIndex = 27;
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(122, 219);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(144, 28);
            this.txtNot1.TabIndex = 26;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(122, 263);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(144, 28);
            this.txtNot2.TabIndex = 25;
            // 
            // txtSozlu1
            // 
            this.txtSozlu1.Location = new System.Drawing.Point(122, 303);
            this.txtSozlu1.Name = "txtSozlu1";
            this.txtSozlu1.Size = new System.Drawing.Size(144, 28);
            this.txtSozlu1.TabIndex = 24;
            // 
            // txtSozlu2
            // 
            this.txtSozlu2.Location = new System.Drawing.Point(122, 341);
            this.txtSozlu2.Name = "txtSozlu2";
            this.txtSozlu2.Size = new System.Drawing.Size(144, 28);
            this.txtSozlu2.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dönem :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Performans Ödevi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sözlu 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sözlu 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ders Not 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ders Not 1 :";
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
            this.btnGuncelle.Location = new System.Drawing.Point(151, 27);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 80);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnEkle.Location = new System.Drawing.Point(16, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 80);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
            this.btnSil.Location = new System.Drawing.Point(293, 27);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 80);
            this.btnSil.TabIndex = 15;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnGeri.Location = new System.Drawing.Point(12, -1);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(50, 50);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cbDers
            // 
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(122, 174);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(144, 30);
            this.cbDers.TabIndex = 36;
            // 
            // ogretmenNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(984, 548);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataOgretmenNot);
            this.Name = "ogretmenNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogretmenNot_FormClosed);
            this.Load += new System.EventHandler(this.ogretmenNot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOgretmenNot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOgretmenNot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtSozlu1;
        private System.Windows.Forms.TextBox txtSozlu2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciAra;
        private System.Windows.Forms.TextBox txtPerformans;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDers;
    }
}