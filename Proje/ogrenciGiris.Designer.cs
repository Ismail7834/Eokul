namespace Proje
{
    partial class ogrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciGiris));
            this.Geri1 = new System.Windows.Forms.Button();
            this.ogrenciTc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.ogrenciNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Geri1
            // 
            this.Geri1.BackColor = System.Drawing.Color.Transparent;
            this.Geri1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Geri1.BackgroundImage")));
            this.Geri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Geri1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri1.FlatAppearance.BorderSize = 0;
            this.Geri1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Geri1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Geri1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri1.Location = new System.Drawing.Point(1, 0);
            this.Geri1.Name = "Geri1";
            this.Geri1.Size = new System.Drawing.Size(50, 50);
            this.Geri1.TabIndex = 0;
            this.Geri1.UseVisualStyleBackColor = false;
            this.Geri1.Click += new System.EventHandler(this.Geri1_Click);
            // 
            // ogrenciTc
            // 
            this.ogrenciTc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciTc.Location = new System.Drawing.Point(215, 99);
            this.ogrenciTc.Name = "ogrenciTc";
            this.ogrenciTc.Size = new System.Drawing.Size(100, 24);
            this.ogrenciTc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Okul No :";
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciGiris.Location = new System.Drawing.Point(115, 227);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(200, 40);
            this.btnOgrenciGiris.TabIndex = 6;
            this.btnOgrenciGiris.Text = "Giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // ogrenciNo
            // 
            this.ogrenciNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciNo.Location = new System.Drawing.Point(215, 168);
            this.ogrenciNo.Name = "ogrenciNo";
            this.ogrenciNo.Size = new System.Drawing.Size(100, 24);
            this.ogrenciNo.TabIndex = 7;
            // 
            // ogrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.ogrenciNo);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenciTc);
            this.Controls.Add(this.Geri1);
            this.Name = "ogrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogrenciGiris_FormClosed);
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri1;
        private System.Windows.Forms.MaskedTextBox ogrenciTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.TextBox ogrenciNo;
    }
}