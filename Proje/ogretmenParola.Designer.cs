namespace Proje
{
    partial class ogretmenParola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenParola));
            this.txtMParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGuvenlik = new System.Windows.Forms.Label();
            this.txtYParola = new System.Windows.Forms.TextBox();
            this.txtGuvenlik = new System.Windows.Forms.TextBox();
            this.Geri = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMParola
            // 
            this.txtMParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMParola.Location = new System.Drawing.Point(179, 65);
            this.txtMParola.Name = "txtMParola";
            this.txtMParola.Size = new System.Drawing.Size(126, 28);
            this.txtMParola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Parola :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(108, 279);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 55);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Parola :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güvenlik Kodu :";
            // 
            // lblGuvenlik
            // 
            this.lblGuvenlik.AutoSize = true;
            this.lblGuvenlik.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlik.Location = new System.Drawing.Point(175, 231);
            this.lblGuvenlik.Name = "lblGuvenlik";
            this.lblGuvenlik.Size = new System.Drawing.Size(45, 22);
            this.lblGuvenlik.TabIndex = 5;
            this.lblGuvenlik.Text = "-----";
            // 
            // txtYParola
            // 
            this.txtYParola.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYParola.Location = new System.Drawing.Point(179, 118);
            this.txtYParola.Name = "txtYParola";
            this.txtYParola.Size = new System.Drawing.Size(126, 28);
            this.txtYParola.TabIndex = 6;
            // 
            // txtGuvenlik
            // 
            this.txtGuvenlik.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlik.Location = new System.Drawing.Point(179, 176);
            this.txtGuvenlik.Name = "txtGuvenlik";
            this.txtGuvenlik.Size = new System.Drawing.Size(126, 28);
            this.txtGuvenlik.TabIndex = 7;
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
            this.Geri.Location = new System.Drawing.Point(-2, -2);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 8;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(243, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 18;
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
            this.button1.Location = new System.Drawing.Point(247, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ogretmenParola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.txtGuvenlik);
            this.Controls.Add(this.txtYParola);
            this.Controls.Add(this.lblGuvenlik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMParola);
            this.Name = "ogretmenParola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OgretmenParola_FormClosed);
            this.Load += new System.EventHandler(this.OgretmenParola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGuvenlik;
        private System.Windows.Forms.TextBox txtYParola;
        private System.Windows.Forms.TextBox txtGuvenlik;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}