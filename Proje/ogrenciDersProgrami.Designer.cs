namespace Proje
{
    partial class ogrenciDersProgrami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciDersProgrami));
            this.dataOgrenciDers = new System.Windows.Forms.DataGridView();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenciDers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOgrenciDers
            // 
            this.dataOgrenciDers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOgrenciDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOgrenciDers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOgrenciDers.Location = new System.Drawing.Point(-1, 55);
            this.dataOgrenciDers.Name = "dataOgrenciDers";
            this.dataOgrenciDers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOgrenciDers.Size = new System.Drawing.Size(808, 406);
            this.dataOgrenciDers.TabIndex = 0;
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
            this.Geri.Location = new System.Drawing.Point(-1, -1);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 6;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.NotGeri1_Click);
            // 
            // ogrenciDersProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.dataOgrenciDers);
            this.Name = "ogrenciDersProgrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogrenciDersProgrami_FormClosed);
            this.Load += new System.EventHandler(this.ogrenciDersProgrami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOgrenciDers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOgrenciDers;
        private System.Windows.Forms.Button Geri;
    }
}