namespace Proje
{
    partial class ogretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenGiris));
            this.Geri2 = new System.Windows.Forms.Button();
            this.btnOgretmenGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ogretmenTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogretmenSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Geri2
            // 
            this.Geri2.BackColor = System.Drawing.Color.Transparent;
            this.Geri2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Geri2.BackgroundImage")));
            this.Geri2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Geri2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri2.FlatAppearance.BorderSize = 0;
            this.Geri2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Geri2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Geri2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri2.Location = new System.Drawing.Point(1, 0);
            this.Geri2.Name = "Geri2";
            this.Geri2.Size = new System.Drawing.Size(50, 50);
            this.Geri2.TabIndex = 0;
            this.Geri2.UseVisualStyleBackColor = false;
            this.Geri2.Click += new System.EventHandler(this.Geri2_Click);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenGiris.Location = new System.Drawing.Point(123, 220);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(179, 40);
            this.btnOgretmenGiris.TabIndex = 1;
            this.btnOgretmenGiris.Text = "Giris";
            this.btnOgretmenGiris.UseVisualStyleBackColor = true;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC No :";
            // 
            // ogretmenTc
            // 
            this.ogretmenTc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenTc.Location = new System.Drawing.Point(203, 101);
            this.ogretmenTc.Name = "ogretmenTc";
            this.ogretmenTc.Size = new System.Drawing.Size(100, 24);
            this.ogretmenTc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // ogretmenSifre
            // 
            this.ogretmenSifre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogretmenSifre.Location = new System.Drawing.Point(203, 156);
            this.ogretmenSifre.Name = "ogretmenSifre";
            this.ogretmenSifre.Size = new System.Drawing.Size(100, 24);
            this.ogretmenSifre.TabIndex = 5;
            // 
            // ogretmenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ogretmenSifre);
            this.Controls.Add(this.Geri2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogretmenTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgretmenGiris);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ogretmenGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogretmenGiris_FormClosed);
            this.Load += new System.EventHandler(this.OgretmenGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri2;
        private System.Windows.Forms.Button btnOgretmenGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ogretmenTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogretmenSifre;
    }
}