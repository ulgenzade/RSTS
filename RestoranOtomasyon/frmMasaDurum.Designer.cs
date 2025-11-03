namespace RestoranOtomasyon
{
    partial class frmMasaDurum
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
            this.lblMasaAdi = new System.Windows.Forms.Label();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.btnRezerve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMasaAdi
            // 
            this.lblMasaAdi.AutoSize = true;
            this.lblMasaAdi.Location = new System.Drawing.Point(79, 27);
            this.lblMasaAdi.Name = "lblMasaAdi";
            this.lblMasaAdi.Size = new System.Drawing.Size(221, 16);
            this.lblMasaAdi.TabIndex = 0;
            this.lblMasaAdi.Text = "MASA - X DURUMUNU GÜNCELLE";
            // 
            // btnDolu
            // 
            this.btnDolu.BackColor = System.Drawing.Color.Salmon;
            this.btnDolu.Location = new System.Drawing.Point(41, 98);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(75, 23);
            this.btnDolu.TabIndex = 1;
            this.btnDolu.Text = "DOLU";
            this.btnDolu.UseVisualStyleBackColor = false;
            // 
            // btnBos
            // 
            this.btnBos.BackColor = System.Drawing.Color.LightGreen;
            this.btnBos.Location = new System.Drawing.Point(147, 98);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(75, 23);
            this.btnBos.TabIndex = 2;
            this.btnBos.Text = "BOŞ";
            this.btnBos.UseVisualStyleBackColor = false;
            // 
            // btnRezerve
            // 
            this.btnRezerve.BackColor = System.Drawing.Color.LightBlue;
            this.btnRezerve.Location = new System.Drawing.Point(253, 98);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(86, 23);
            this.btnRezerve.TabIndex = 3;
            this.btnRezerve.Text = "REZERVE";
            this.btnRezerve.UseVisualStyleBackColor = false;
            // 
            // frmMasaDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.btnRezerve);
            this.Controls.Add(this.btnBos);
            this.Controls.Add(this.btnDolu);
            this.Controls.Add(this.lblMasaAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMasaDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMasaDurum";
            this.Load += new System.EventHandler(this.frmMasaDurum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaAdi;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnBos;
        private System.Windows.Forms.Button btnRezerve;
    }
}