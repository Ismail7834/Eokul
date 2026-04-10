namespace Proje
{
    partial class ogrenciNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciNot));
            this.btnDonem1 = new System.Windows.Forms.Button();
            this.btnDonem2 = new System.Windows.Forms.Button();
            this.dataOgrenciNot = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDonemOrt = new System.Windows.Forms.Label();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenciNot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDonem1
            // 
            this.btnDonem1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonem1.Location = new System.Drawing.Point(146, 49);
            this.btnDonem1.Name = "btnDonem1";
            this.btnDonem1.Size = new System.Drawing.Size(165, 55);
            this.btnDonem1.TabIndex = 0;
            this.btnDonem1.Text = "1. Dönem";
            this.btnDonem1.UseVisualStyleBackColor = true;
            this.btnDonem1.Click += new System.EventHandler(this.btnDonem1_Click);
            // 
            // btnDonem2
            // 
            this.btnDonem2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonem2.Location = new System.Drawing.Point(478, 49);
            this.btnDonem2.Name = "btnDonem2";
            this.btnDonem2.Size = new System.Drawing.Size(165, 55);
            this.btnDonem2.TabIndex = 1;
            this.btnDonem2.Text = "2. Dönem";
            this.btnDonem2.UseVisualStyleBackColor = true;
            this.btnDonem2.Click += new System.EventHandler(this.btnDonem2_Click);
            // 
            // dataOgrenciNot
            // 
            this.dataOgrenciNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOgrenciNot.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOgrenciNot.Location = new System.Drawing.Point(1, 131);
            this.dataOgrenciNot.Name = "dataOgrenciNot";
            this.dataOgrenciNot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOgrenciNot.Size = new System.Drawing.Size(784, 248);
            this.dataOgrenciNot.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dönem Ortalaması =";
            // 
            // lblDonemOrt
            // 
            this.lblDonemOrt.AutoSize = true;
            this.lblDonemOrt.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonemOrt.Location = new System.Drawing.Point(402, 402);
            this.lblDonemOrt.Name = "lblDonemOrt";
            this.lblDonemOrt.Size = new System.Drawing.Size(48, 28);
            this.lblDonemOrt.TabIndex = 4;
            this.lblDonemOrt.Text = "----";
            // 
            // Geri
            // 
            this.Geri.BackColor = System.Drawing.Color.Transparent;
            this.Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Geri.BackgroundImage")));
            this.Geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Geri.FlatAppearance.BorderSize = 0;
            this.Geri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri.Location = new System.Drawing.Point(1, 0);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 5;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // ogrenciNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.lblDonemOrt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataOgrenciNot);
            this.Controls.Add(this.btnDonem2);
            this.Controls.Add(this.btnDonem1);
            this.Name = "ogrenciNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notlarım";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogrenciNot_FormClosed);
            this.Load += new System.EventHandler(this.ogrenciNot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenciNot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonem1;
        private System.Windows.Forms.Button btnDonem2;
        private System.Windows.Forms.DataGridView dataOgrenciNot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDonemOrt;
        private System.Windows.Forms.Button Geri;
    }
}