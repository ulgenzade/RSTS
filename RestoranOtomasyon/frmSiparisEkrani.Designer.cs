namespace RestoranOtomasyon
{
    partial class frmSiparisEkrani
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
            this.flowMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSiparis = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.lblGarsonAdi = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.panelSiparisListesi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.panelKategoriler = new System.Windows.Forms.Panel();
            this.panelSiparis.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowMasalar
            // 
            this.flowMasalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowMasalar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowMasalar.Location = new System.Drawing.Point(0, 0);
            this.flowMasalar.Name = "flowMasalar";
            this.flowMasalar.Size = new System.Drawing.Size(462, 577);
            this.flowMasalar.TabIndex = 0;
            this.flowMasalar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowMasalar_Paint);
            // 
            // panelSiparis
            // 
            this.panelSiparis.Controls.Add(this.btnGeriDon);
            this.panelSiparis.Controls.Add(this.txtArama);
            this.panelSiparis.Controls.Add(this.btnOdeme);
            this.panelSiparis.Controls.Add(this.lblGarsonAdi);
            this.panelSiparis.Controls.Add(this.btnOnayla);
            this.panelSiparis.Controls.Add(this.btnVazgec);
            this.panelSiparis.Controls.Add(this.panelKategoriler);
            this.panelSiparis.Controls.Add(this.panelSiparisListesi);
            this.panelSiparis.Controls.Add(this.label1);
            this.panelSiparis.Location = new System.Drawing.Point(468, 0);
            this.panelSiparis.Name = "panelSiparis";
            this.panelSiparis.Size = new System.Drawing.Size(475, 577);
            this.panelSiparis.TabIndex = 1;
            this.panelSiparis.Visible = false;
            this.panelSiparis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSiparis_Paint);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(36, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(403, 22);
            this.txtArama.TabIndex = 1;
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(276, 542);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(195, 23);
            this.btnOdeme.TabIndex = 6;
            this.btnOdeme.Text = "ÖDE";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // lblGarsonAdi
            // 
            this.lblGarsonAdi.AutoSize = true;
            this.lblGarsonAdi.Location = new System.Drawing.Point(3, 515);
            this.lblGarsonAdi.Name = "lblGarsonAdi";
            this.lblGarsonAdi.Size = new System.Drawing.Size(44, 16);
            this.lblGarsonAdi.TabIndex = 5;
            this.lblGarsonAdi.Text = "label2";
            this.lblGarsonAdi.Click += new System.EventHandler(this.lblGarsonAdi_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(379, 495);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(93, 36);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(276, 495);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(93, 36);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // panelSiparisListesi
            // 
            this.panelSiparisListesi.AutoScroll = true;
            this.panelSiparisListesi.Location = new System.Drawing.Point(3, 170);
            this.panelSiparisListesi.Name = "panelSiparisListesi";
            this.panelSiparisListesi.Size = new System.Drawing.Size(468, 319);
            this.panelSiparisListesi.TabIndex = 2;
            this.panelSiparisListesi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSiparisListesi_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞLER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(3, 542);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(195, 23);
            this.btnGeriDon.TabIndex = 7;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelKategoriler
            // 
            this.panelKategoriler.AutoScroll = true;
            this.panelKategoriler.Location = new System.Drawing.Point(3, 56);
            this.panelKategoriler.Name = "panelKategoriler";
            this.panelKategoriler.Size = new System.Drawing.Size(468, 108);
            this.panelKategoriler.TabIndex = 3;
            this.panelKategoriler.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmSiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelSiparis);
            this.Controls.Add(this.flowMasalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSiparisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ EKRANI";
            this.Load += new System.EventHandler(this.frmSiparisEkrani_Load);
            this.panelSiparis.ResumeLayout(false);
            this.panelSiparis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowMasalar;
        private System.Windows.Forms.Panel panelSiparis;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGarsonAdi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel panelSiparisListesi;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Panel panelKategoriler;
    }
}