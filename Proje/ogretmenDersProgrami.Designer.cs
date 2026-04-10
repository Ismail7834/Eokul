namespace Proje
{
    partial class ogretmenDersProgrami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenDersProgrami));
            this.dataOgretmenDers = new System.Windows.Forms.DataGridView();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataOgretmenDers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOgretmenDers
            // 
            this.dataOgretmenDers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOgretmenDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOgretmenDers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataOgretmenDers.Location = new System.Drawing.Point(2, 58);
            this.dataOgretmenDers.Name = "dataOgretmenDers";
            this.dataOgretmenDers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOgretmenDers.Size = new System.Drawing.Size(797, 393);
            this.dataOgretmenDers.TabIndex = 0;
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
            this.Geri.Location = new System.Drawing.Point(2, 2);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(50, 50);
            this.Geri.TabIndex = 7;
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // ogretmenDersProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.dataOgretmenDers);
            this.Name = "ogretmenDersProgrami";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programım";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ogretmenDersProgrami_FormClosed);
            this.Load += new System.EventHandler(this.ogretmenDersProgrami_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOgretmenDers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOgretmenDers;
        private System.Windows.Forms.Button Geri;
    }
}